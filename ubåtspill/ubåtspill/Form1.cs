using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace ubåtspill
{
    public partial class Form1 : Form
    {
        //Spill brett er 1300 x 600 (X = 1300, Y = 600)
        #region private fields
        private List<Fi> _fiender = new List<Fi>();
        private Ubåt _ubåt;
        private Torpedo _torpedo;
        private int _score;
        private int _life;
        private int _level;

        #endregion

        #region ctor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            _ubåt = new Ubåt();
            _torpedo = new Torpedo();
            _fiender.Add(new Fi());
            timerBåter.Start();
            _life = 3;
            _level = 1;
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerBåter.Stop();
            Application.Exit();
        }
        
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerBåter.Stop();
        }

        private void timerBåter_Tick(object sender, EventArgs e)
        {
            foreach (var fi in _fiender)
            {
                if (fi.isActive)
                {
                    fi.Move();
                }
            }
            Refresh();
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
                            Restart();
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

        private void Restart()
        {
            Reset();

            _fiender.Clear();
            _fiender.Add(new Fi());
            
            labelPoengSum.Text = "0";

            life3.Visible = true;
            life2.Visible = true;

            _life = 3;
        }

        private void Reset()
        {
            _torpedo = new Torpedo();
            timerTorpedo.Interval = 15;
            powerBar.Value = 0;
            timerTorpedo.Stop();
        }

        private void Pause()
        {
            timerBåter.Stop();
            timerTorpedo.Stop();
        }

        private void UnPause()
        {
            timerBåter.Start();
            if (_torpedo.isActive)
            {
                timerTorpedo.Start();
            }
        }

        private void timerTorpedo_Tick(object sender, EventArgs e)
        {
            if(_torpedo != null && _torpedo.isActive)
            {
                _torpedo.Move();
            }
            else
            {
                if(powerBar.Value != 100)
                {
                    powerBar.PerformStep();
                    timerTorpedo.Interval--;
                    Console.WriteLine($"Torpedo interval = {timerTorpedo.Interval}");
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

        private void SjekkLevel()
        {
            if (_fiender.Count > (_level+3))
            {
                UpLevel();
            }
        }

        private void UpLevel()
        {
            _level++;
            Pause();

            labelLevel.Text = $"Level {_level}";
            labelLevel.Visible = true;

            Thread.Sleep(100);

            labelLevel.Text = "STARTING IN 3";

            Thread.Sleep(100);

            labelLevel.Text = "STARTING IN 2";

            Thread.Sleep(100);

            labelLevel.Text = "STARTING IN 1";

            Thread.Sleep(100);

            labelLevel.Visible = false;

            Restart();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Løkke for å loope gjennom alle fiender
            foreach (var fi in _fiender)
            {
                // TREFF!!
                if (fi.isHit(_torpedo))
                {
                    Reset();
                    //TODO: Verifiser denne
                    _score += fi.points;
                    labelPoengSum.Text = _score.ToString();
                    fi.isActive = false;
                    
                    return;
                }

                //Fi is out of bounce
                if (fi.X > pictureBox1.Width && fi.isActive)
                {
                    if (_life > 1)
                    {
                        _life--;
                        fi.isActive = false;
                        if (_life == 2) life3.Visible = false;
                        if (_life == 1) life2.Visible = false;
                    }
                    else
                    {
                        Pause();
                        if (MessageBox.Show("Game over", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                        {
                            //TODO: Add save highscore
                            labelHighscore.Text = _score.ToString();
                            Restart();
                        }
                    }
                }

                //tegner fi
                if (fi.isActive)
                {
                    Brush b1 = new SolidBrush(Color.AliceBlue);
                    g.FillEllipse(b1, fi.X, fi.Y, fi.Length, fi.Height);
                }
            }

            //torpedo is out of bounce
            if (_torpedo.Y < 0)
            {
                Reset();
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
    }
}
