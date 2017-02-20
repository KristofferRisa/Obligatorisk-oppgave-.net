using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ubåtspill
{
    public partial class HighscoreForm : Form
    {
        private readonly int _score;
        private string _name;
        private List<Highscore> _data;

        public HighscoreForm(int score,bool active)
        {
            InitializeComponent();

            labelPoengsum.Text = score.ToString();
            _score = score;

            groupBoxRegScore.Visible = active;
            labelPoengsum.Visible = active;
            labelDinPoengSum.Visible = active;
            
            HentHighscore();
        }

        private void HentHighscore()
        {
            //Henter data fra disk dersom det finnes, hvis ikke lages en tom data liste
            try
            {
                _data = HelperClass.ReadFromXmlFile<List<Highscore>>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //Maps data til riktig label
            if (_data.Count > 1)
            {
                labelFirst.Text = _data.OrderByDescending(x => x.Score).First().ToString();
            }
            if (_data.Count >= 2)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(1).First().ToString();
            }
            if (_data.Count >= 3)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(2).First().ToString();
            }
            if (_data.Count >= 4)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(3).First().ToString();
            }
            if (_data.Count >= 5)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(4).First().ToString();
            }
            if (_data.Count >= 6)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(5).First().ToString();
            }
            if (_data.Count >= 7)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(6).First().ToString();
            }
            if (_data.Count >= 8)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(7).First().ToString();
            }
            if (_data.Count >= 9)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(8).First().ToString();
            }
            if (_data.Count >= 10)
            {
                labelSecond.Text = _data.OrderByDescending(x => x.Score).Skip(9).First().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUserName.Text))
            {
                //Lagrer data
                _name = textBoxUserName.Text;
                SaveXml();
                this.Hide();
            }
            else
            {
                MessageBox.Show(@"Mangler brukernavn"
                    ,@"Lagre poeng"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Warning);
            }
        }

        private void SaveXml()
        {
            _data.Add(new Highscore(){ Name = _name, Score = _score, Date = DateTime.Now});
            HelperClass.WriteToXmlFile(_data,false);
        }

    }
}
