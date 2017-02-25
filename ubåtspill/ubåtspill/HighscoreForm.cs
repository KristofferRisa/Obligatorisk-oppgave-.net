﻿using System;
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
        #region private fields
        private readonly int _score;
        private string _name;
        private List<Highscore> _data;
        private readonly int _level;

        #endregion

        public HighscoreForm(int score, int level, bool active)
        {
            InitializeComponent();

            labelPoengsum.Text = score.ToString();
            _score = score;
            _level = level;

            groupBoxRegScore.Visible = active;
            labelPoengsum.Visible = active;
            labelDinPoengSum.Visible = active;
            
            LoadXmlData();

            this.ClientSize = new Size(groupBoxRegScore.Bottom + 25, groupBoxRegScore.Right + 100);

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUserName.Text))
            {
                //Lagrer data
                _name = textBoxUserName.Text;
                SaveXmlData();
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

        private void LoadXmlData()
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
            if (_data.Count >= 1)
            {
                labelScore1.Text = _data.OrderByDescending(x => x.Score).First().ToString();
            }
            if (_data.Count >= 2)
            {
                labelScore2.Text = _data.OrderByDescending(x => x.Score).Skip(1).First().ToString();
            }
            if (_data.Count >= 3)
            {
                labelScore3.Text = _data.OrderByDescending(x => x.Score).Skip(2).First().ToString();
            }
            if (_data.Count >= 4)
            {
                labelScore4.Text = _data.OrderByDescending(x => x.Score).Skip(3).First().ToString();
            }
            if (_data.Count >= 5)
            {
                labelScore5.Text = _data.OrderByDescending(x => x.Score).Skip(4).First().ToString();
            }
            if (_data.Count >= 6)
            {
                labelScore6.Text = _data.OrderByDescending(x => x.Score).Skip(5).First().ToString();
            }
            if (_data.Count >= 7)
            {
                labelScore7.Text = _data.OrderByDescending(x => x.Score).Skip(6).First().ToString();
            }
            if (_data.Count >= 8)
            {
                labelScore8.Text = _data.OrderByDescending(x => x.Score).Skip(7).First().ToString();
            }
            if (_data.Count >= 9)
            {
                labelScore9.Text = _data.OrderByDescending(x => x.Score).Skip(8).First().ToString();
            }
            if (_data.Count >= 10)
            {
                labelScore10.Text = _data.OrderByDescending(x => x.Score).Skip(9).First().ToString();
            }
        }

        private void SaveXmlData()
        {
            _data.Add(
                new Highscore()
                {
                        Name = _name
                        , Score = _score
                        , Level = _level
                        , Date = DateTime.Now
                });
            HelperClass.SkrivXmlFile(_data);
        }
    }
}
