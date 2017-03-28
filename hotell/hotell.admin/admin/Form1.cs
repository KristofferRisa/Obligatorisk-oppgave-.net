using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using admin.Models;
using Newtonsoft.Json;

namespace admin
{
    public partial class Form1 : Form
    {
        private List<Room> rooms;
        private List<Booking> bookings;
        private string valgtDato;
        private List<Label> roomsLabels; //cache a reference to each label

        public Form1()
        {
            InitializeComponent();

            this.listBox1.AllowDrop = true;
            this.listBox1.MouseDown += new MouseEventHandler(listBox1_MouseDown);
            this.listBox1.DragOver += new DragEventHandler(listBox1_DragOver);

            valgtDato = DateTime.Today.ToString("yyyy.MM.dd");
            roomsLabels = new List<Label>();
            HentRom();
            HentBookinger();
            
            //listBox1.DataSource = data;
        }

        private void HentRom()
        {
            using (var client = new WebClient())
            {
                rooms =
                    JsonConvert.DeserializeObject<List<Room>>(
                        client.DownloadString("https://booking-online.azurewebsites.net/api/Rooms"));
            }
        }

        private void HentBookinger()
        {
            using (var client = new WebClient())
            {
                
                bookings =
                    JsonConvert.DeserializeObject<List<Booking>>(
                        client.DownloadString($"https://booking-online.azurewebsites.net/api/Booking?date={valgtDato}"));
                listBox1.DataSource = bookings;
            }
        }

        private static void SendData()
        {
            using (var client = new HttpClient())
            {
                var data = new List<KeyValuePair<string, string>>
                {
                    //new KeyValuePair<string, string>("Name", _name),
                    //new KeyValuePair<string, string>("Score", _score.ToString()),
                    //new KeyValuePair<string, string>("Level", _level.ToString()),
                    new KeyValuePair<string, string>("Date", DateTime.Now.ToString("yyyy-MM-dd"))
                };
                var content = new FormUrlEncodedContent(data);

                //client.DefaultRequestHeaders.Add("Token", "12414141414");

                var response = client.PostAsync("https://booking-online.azurewebsites.net/api/Booking", content).Result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpprettRom();

            Refresh();
        }

        private void OpprettRom()
        {
            if (rooms != null)
            {
                //setup rooms
                var row = 1;
                var col = 1;
                var floor = 1;
                foreach (var room in rooms)
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

                    Label l = new Label();
                    l.AutoSize = true;
                    l.BackColor = System.Drawing.Color.LightGreen;
                    if (col == 1)
                    {
                        l.Location = new System.Drawing.Point(10 , 60 * row);
                    }
                    else
                    {
                        l.Location = new System.Drawing.Point(100 * col + 100, 60 * row);
                    }
                    l.Name = $"{room.RoomName}";
                    l.MinimumSize = new System.Drawing.Size(90, 40);
                    l.TabIndex = room.RoomId;
                    l.Text = $"{room.RoomName}";
                    switch (room.Floor)
                    {
                        case 1:
                            tabPage1.Controls.Add(l);
                            roomsLabels.Add(l);
                            break;
                        case 2:
                            tabPage2.Controls.Add(l);
                            break;
                        case 3:
                            tabPage3.Controls.Add(l);
                            break;
                    }

                    col++;
                    floor = room.Floor;
                }
            }
        }

        private void OppdaterRomStatus()
        {
            foreach (var label in roomsLabels)
            {
                label.BackColor = Color.Red;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            valgtDato = monthCalendar1.SelectionEnd.ToString("yyyy.MM.dd");
            HentBookinger();
            HentRom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OppdaterRomStatus();
        }
    }
}
