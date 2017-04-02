using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using admin.Models;
using admin.Properties;
using Newtonsoft.Json;
using static System.Drawing.Color;

namespace admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(tabEtasjer.Right + 50, tabEtasjer.Bottom + 50);
            this.listBox1.AllowDrop = true;
            this.listBox1.MouseDown += new MouseEventHandler(listBox1_MouseDown);
            this.listBox1.DragOver += new DragEventHandler(listBox1_DragOver);
            _roomsLabels = new List<Label>();
            monthCalendar1.SetDate(DateTime.Now);
            _valgtDato = monthCalendar1.SelectionEnd.ToString("yyyy.MM.dd");
            labelValgtDato.Text = monthCalendar1.SelectionEnd.ToLongDateString();
            dateTimePickerFradato.MinDate = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HentRom();
            OpprettRom();
            Oppdater();
            Refresh();
        }

        #region private fields
        private List<Room> _rooms;
        private List<Booking> _bookings;
        private string _valgtDato;
        private readonly List<Label> _roomsLabels; //cache a reference to each label
        #endregion

        #region private methods
        private void Oppdater()
        {
            HentBookinger();
            OppdaterRomoversik();
            OppdaterDagensOversikt();
        }

        private void OppdaterDagensOversikt()
        {
            labelTotaltAntGjester.Text = _bookings.Count().ToString();
            labelIkkeTildeltRom.Text = _bookings.Count(x => x.RoomNumber == 0).ToString();
            labelTildelt.Text = _bookings.Count(x => x.RoomNumber != 0).ToString();
        }

        private void OppdaterRomoversik()
        {
            foreach (var label in _roomsLabels)
            {
                label.BackColor = _bookings.Exists(x => x.RoomNumber == Convert.ToInt32(label.Name)) ? Red : Green;
            }
        }
     
        private void OpprettRom()
        {
            if (_rooms != null)
            {
                //setup rooms
                var row = 1;
                var col = 1;
                var floor = 1;
                foreach (var room in _rooms)
                {
                    if (col == 5)
                    {
                        col = 1;
                        row++;
                    }
                    if (room.Floor != floor)
                    {
                        row = 1;
                        col = 1;
                    }

                    OpprettLabel(col, row, room);

                    col++;
                    floor = room.Floor;
                }
            }
        }

        private void OpprettLabel(int col, int row, Room room)
        {
            var l = new Label()
            {
                AutoSize = true,

                BackColor = Green,

                Location = new Point(60 * col, 60 * row),

                Name = $"{room.RoomNumber}",
                MinimumSize = new Size(45, 45),
                TabIndex = room.RoomId,
                Text = $"{room.RoomName}",

                AllowDrop = true
            };
            l.Click += VisReservasjon;
            l.DragEnter += l_DragEnter;
            l.DragOver += l_DragOver;
            l.DragDrop += l_DragDrop;

            switch (room.Floor)
            {
                case 1:
                    tabPage1.Controls.Add(l);
                    _roomsLabels.Add(l);
                    break;
                case 2:
                    tabPage2.Controls.Add(l);
                    break;
                case 3:
                    tabPage3.Controls.Add(l);
                    break;
            }
        }

        private void VisReservasjon(object sender, EventArgs e)
        {
            var l = (Label) sender;
            var details = _bookings.FirstOrDefault(b => b.RoomNumber.ToString() == l.Name);
            if (details != null)
            {
                var result = MessageBox.Show(
                        $"Rom detaljer\r\n\r\nNavn: {details.CustomerName}\r\nReservert fra - til: {details.FromDate} - {details.ToDate}\r\nAdresse: {details.CustomerAdress}\r\nTelefon: {details.CustomerPhone}\r\n\r\nØnsker å du fjerne rom reservasjon trykk YES."
                        , "Detaljer"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (MessageBox.Show("Er du sikker?", "Bekreft sletting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        details.RoomNumber = 0;
                        SendRomBooking(details);
                        Oppdater();
                        tabEtasjer.SelectTab(0);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Ingen er sjekket inn på rom {l.Name}.", "Detaljer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events and button clicks
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.All);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void l_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void l_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void l_DragDrop(object sender, DragEventArgs e)
        {

            var booking = (Booking)e.Data.GetData(typeof(Booking));

            var l = (Label)sender;
            booking.RoomNumber = Convert.ToInt32(l.Name);

            if (SendRomBooking(booking).StatusCode == HttpStatusCode.NoContent)
            {

                l.BackColor = Red;
            }
            else
            {
                l.BackColor = Green;
            }
            Oppdater();

        }
        
        private void monthCalendar_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            _valgtDato = monthCalendar1.SelectionEnd.ToString("yyyy.MM.dd");
            labelValgtDato.Text = monthCalendar1.SelectionEnd.ToLongDateString();
            Oppdater();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabEtasjer.SelectTab(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Simple input validering
            if (string.IsNullOrEmpty(textBoxNavn.Text))
                MessageBox.Show(Resources.Form1_button2_Click_Mangler_brukernavn
                    , Resources.Form1_button2_Click_Feil_input
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(textBoxTelefon.Text))
                MessageBox.Show(Resources.Form1_button2_Click_Mangler_telefon_nr
                    , Resources.Form1_button2_Click_Feil_input
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(textBoxAdr.Text))
                MessageBox.Show(Resources.Form1_button2_Click_Mangler_adresse
                    , Resources.Form1_button2_Click_Feil_input
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            else
            {
                var booking = new Booking()
                {
                    FromDate = dateTimePickerFradato.Value,
                    ToDate = dateTimePickerTildato.Value,
                    CustomerName = textBoxNavn.Text,
                    CustomerAdress = textBoxAdr.Text,
                    CustomerPhone = textBoxTelefon.Text,
                    IsCheckedIn = true
                };

                if (!SendNewBooking(booking).IsSuccessStatusCode)
                {
                    MessageBox.Show(Resources.Form1_button2_Click_kontakt_support
                        , Resources.Form1_button2_Click_Error
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
                
                Oppdater();
                tabEtasjer.SelectTab(0);
                textBoxAdr.Text = "";
                textBoxNavn.Text = "";
                textBoxTelefon.Text = "";
                dateTimePickerFradato.MinDate = DateTime.Now; 
            }

        }

        private void dateTimePickerFradato_ValueChanged(object sender, EventArgs e)
        {
            var minDate = (DateTimePicker)sender;
            dateTimePickerTildato.MinDate = minDate.Value;
        }

        private void nyBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabEtasjer.SelectTab(4);
        }

        private void oversiktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabEtasjer.SelectTab(0);
        }

        private void etasjeOversiktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabEtasjer.SelectTab(1);
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void omHotellBooking10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hotell booking 1.0\r\n\r\nObligatorisk oppgave i .NET på Høyskolen i Sør-Øst Norge 2017\r\n\r\n\r\nLaget av Kristoffer Risa 2017");
        }
        #endregion

        #region REST Web API helper methods
        private void HentRom()
        {
            using (var client = new WebClient())
            {
                _rooms =
                    JsonConvert.DeserializeObject<List<Room>>(
                        client.DownloadString("https://booking-online.azurewebsites.net/api/Rooms"));
            }
        }

        private void HentBookinger()
        {
            using (var client = new WebClient())
            {

                _bookings =
                    JsonConvert.DeserializeObject<List<Booking>>(
                        client.DownloadString($"https://booking-online.azurewebsites.net/api/Booking?date={_valgtDato}"));
                listBox1.DataSource = _bookings.Where(x => x.RoomNumber == 0).ToList();
                listBox2.DataSource = _bookings;
            }
        }

        private HttpResponseMessage SendRomBooking(Booking booking)
        {
            using (var client = new HttpClient())
            {
                var data = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("id", booking.BookingId.ToString()),
                    new KeyValuePair<string, string>("roomnumber", booking.RoomNumber.ToString())
                };
                var content = new FormUrlEncodedContent(data);

                //return  client.PutAsync("http://localhost:49374/api/PutBooking", content).Result;
                return client.PutAsync("https://booking-online.azurewebsites.net/api/PutBooking", content).Result;
            }
        }

        private HttpResponseMessage SendNewBooking(Booking booking)
        {
            using (var client = new HttpClient())
            {
                var data = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("fromdate", booking.FromDate.ToString("yyyy.MM.dd")),
                    new KeyValuePair<string, string>("todate", booking.ToDate.ToString("yyyy.MM.dd")),
                    new KeyValuePair<string, string>("customername", booking.CustomerName),
                    new KeyValuePair<string, string>("customeradress", booking.CustomerAdress),
                    new KeyValuePair<string, string>("customerphone", booking.CustomerPhone),
                    new KeyValuePair<string, string>("ischeckedin", booking.IsCheckedIn.ToString())
                };
                var content = new FormUrlEncodedContent(data);

                //return client.PostAsync("http://localhost:49374/api/PostBooking", content).Result;
                return client.PostAsync("https://booking-online.azurewebsites.net/api/PostBooking", content).Result;
            }
        }
        #endregion

    }
}
