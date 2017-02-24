using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ubåtspill
{
    public partial class Spill : Form
    {
        //Spill brett er 1300 x 600 (X = 1300, Y = 600)
        #region private fields
        private List<Fiende> _fiender = new List<Fiende>();
        private Ubåt _ubåt;
        private Torpedo _torpedo;
        private int _score;
        private int _life;
        private int _level;
        private bool _gameOver;
        private int _labelStatusTicker;
        private int _hitCount;

        #endregion

        #region ctor
        public Spill()
        {
            InitializeComponent();
        }
        #endregion
      
        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            _ubåt = new Ubåt();
            _torpedo = new Torpedo();
            _hitCount = 0;
            NyttSpill();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Space:
                    {
                        if (!_torpedo.isActive)
                        {
                            timerTorpedo.Start();
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if(_ubåt.X > 0)
                        {
                            _ubåt.MoveLeft();
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if(_ubåt.X < (pictureBox1.Width - _ubåt.Length))
                        {
                            _ubåt.MoveRight();
                        }
                        break;
                    }
                case Keys.Escape:
                    {
                        this.Close();
                        break;
                    }
                case Keys.R:
                    {
                        Pause();
                        if(MessageBox.Show(
                            "Restarte spill?"
                            , "Restart"
                            , MessageBoxButtons.OKCancel
                            ,MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            NyttSpill();
                        }
                        UnPause();
                        break;
                    }
                default:
                {
                    break;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                if (!_torpedo.isActive)
                {
                    _torpedo.Shoot(_ubåt.X + 50, _ubåt.Y - 10);
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (_gameOver == false)
            {
                //Løkke for å loope gjennom alle fiender
                foreach (var fi in _fiender.Where(x => x.IsActive))
                {
                    // TREFF!!
                    if (fi.IsHit(_torpedo))
                    {
                        ResetTorpedo();
                        labelHitpoints.Text = $"Treff!! {fi.Points} poeng!";

                        _labelStatusTicker = 0;

                        _score += fi.Points;
                        _hitCount++;
                        labelTreffSum.Text = _hitCount.ToString();
                        labelPoengSum.Text = _score.ToString();
                        fi.IsActive = false;

                        return;
                    }

                    //Fiende is out of bounce
                    if (fi.X > pictureBox1.Width)
                    {
                        if (_life > 1)
                        {
                            _life--;
                            fi.IsActive = false;
                            if (_life == 2) life3.Visible = false;
                            if (_life == 1) life2.Visible = false;
                        }
                        else
                        {
                            _gameOver = true;
                            break;
                        }
                    }

                    //tegner fienden
                    g.FillEllipse(fi.Brush, fi.X, fi.Y, fi.Length, fi.Height);
                    //tegner kanonen
                    //g.FillEllipse(fi.Brush
                    //    , fi.X + (fi.Length / 4)// X
                    //    , fi.Y -5 // Y
                    //    , fi.Length - (fi.Length / 2)  // Lengde
                    //    , fi.Height); // Høyde
                }
                
            }
            
            //torpedo is out of bounce
            if (_torpedo.Y < 0)
            {
                ResetTorpedo();
            }
            
            //Tegner ubåt
            if (_ubåt != null)
            {
                g.FillEllipse(_ubåt.Brush, _ubåt.X, _ubåt.Y, _ubåt.Length, 25);
                //tegner kanon
                g.FillEllipse(_ubåt.Brush, _ubåt.X + 50, _ubåt.Y - 10, _torpedo.Length, 25);
            }

            //tegner torpedo
            if (_torpedo != null && _torpedo.isActive)
            {
                g.FillEllipse(_torpedo.Brush, _torpedo.X, _torpedo.Y, _torpedo.Height, _torpedo.Length);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = e.X.ToString();
            labelY.Text = e.Y.ToString();
        }

        #region ticks
        
        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (_fiender.Count() < _level + 3)
            {
                //if (_level < 3)
                //{
                //    //Legger bare til slow fiender på nivå lavere enn 3
                //    _fiender.Add(new Fiende(0));
                //}
                //else
                //{
                var speed = new Random();
                _fiender.Add(new Fiende(speed.Next(0, 2)));
                //}
            }
            else
            {
                //sjekk om noen av fiendene er i live
                if (_fiender.All(x => x.IsActive == false))
                {
                    NyttLevel();
                }
            }
            //Gameover!
            if (_gameOver)
            {
                ShowHighscoreForm(true);

                if (MessageBox.Show(@"Ønsker du å starte et nytt spill?",
                        @"Game over",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    labelHighscore.Text = _score.ToString();
                    ResetGame();
                }
                else
                {
                    ResetGame();
                    Pause();
                }
            }

            if (_labelStatusTicker > 45)
            {
                labelHitpoints.Text = "";
                _labelStatusTicker++;
            }
            else
            {
                _labelStatusTicker++;
            }
            Refresh();
        }

        private void timerTorpedo_Tick(object sender, EventArgs e)
        {
            if (_torpedo != null && _torpedo.isActive)
            {
                _torpedo.Move();
            }
            else
            {
                if (powerBar.Value < 100)
                {
                    powerBar.PerformStep();
                    if (powerBar.Value % 20 == 0)
                    {
                          timerTorpedo.Interval--;
                    }
                }
            }
        }

        private void timerSlow_Tick(object sender, EventArgs e)
        {
            
            //Flytter fienden
            foreach (var fi in _fiender)
            {
                if (fi.IsActive && fi.Speed == Speed.Slow)
                {
                    fi.Move();
                }
            }
        }

        private void timerMid_Tick(object sender, EventArgs e)
        {
            foreach (var fi in _fiender)
            {
                if (fi.IsActive && fi.Speed == Speed.Mid)
                {
                    fi.Move();
                }
            }
        }

        private void timerFast_Tick(object sender, EventArgs e)
        {
            foreach (var fi in _fiender)
            {
                if (fi.IsActive && fi.Speed == Speed.Fast)
                {
                    fi.Move();
                }
            }
        }

        #endregion

        #endregion

        #region menu buttons

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerSlow.Stop();
            Application.Exit();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void halOfFameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHighscoreForm(false);
            var result = MessageBox.Show(@"Fortsette spill?"
                , @"Fortsette"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if (result == DialogResult.Yes) UnPause();
        }

        #endregion

        #region helper methods

        private static void Wait(int millisecondsToWait)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                //some other processing to do possible
                if (stopwatch.ElapsedMilliseconds >= millisecondsToWait)
                {
                    break;
                }
            }
        }

        private void ShowHighscoreForm(bool active)
        {
            Pause();
            HighscoreForm form = new HighscoreForm(_score, active);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ResetGame()
        {
            ResetLife();
            _gameOver = false;

            _level = 1;
            labelLevel.Text = $@"{_level}";
            labelTreffSum.Text = "0";
            labelPoengSum.Text = "0";
            Refresh();

            ResetTorpedo();
        }

        private void ResetTorpedo()
        {
            _torpedo = new Torpedo();
            timerTorpedo.Interval = 15;

            powerBar.Value = 0;
            timerTorpedo.Stop();
        }

        private void Pause()
        {
            timerGame.Stop();
            timerMid.Stop();
            timerSlow.Stop();
            timerFast.Stop();
            timerTorpedo.Stop();
        }

        private void UnPause()
        {
            timerGame.Start();
            timerSlow.Start();
            timerMid.Start();
            timerFast.Start();
            if (_torpedo.isActive)
            {
                timerTorpedo.Start();
            }
        }

        private void NyttSpill()
        {
            ResetGame();
        }

        private void NyttLevel()
        {
            _level++;

            labelHitpoints.Text = "";

            Pause();

            labelStatus.Text = $@"Ny level!";
            Refresh();
            Wait(1000);

            labelLevel.Text = $@"{_level}";
            Refresh();
            Wait(1000);

            labelStatus.Text = @"Starter om 3";
            Refresh();
            Wait(1000);

            labelStatus.Text = @"Starter om 2";
            Refresh();
            Wait(1000);

            labelStatus.Text = @"Starter om 1";
            Refresh();
            Wait(1000);

            labelStatus.Text = "";
            Refresh();

            ResetLife();

            ResetTorpedo();

            UnPause();

        }

        private void ResetLife()
        {
            _fiender = new List<Fiende>();

            life3.Visible = true;
            life2.Visible = true;

            _life = 3;

            timerGame.Start();
            timerSlow.Start();
            timerMid.Start();
            timerFast.Start();

        }

        #endregion

        private void nyttSpillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyttSpill();
        }

        private void lagreSpillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnPause();
        }

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HjelpForm help = new HjelpForm();
            help.Show();
        }

        private void omToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OmForm om = new OmForm();
            om.Show();
        }

    }
}
