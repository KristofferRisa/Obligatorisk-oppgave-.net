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
        private int _score;
        private string _name;
        public HighscoreForm(int score)
        {
            InitializeComponent();

            labelPoengsum.Text = score.ToString();
            _score = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUserName.Text))
            {
                //Lagrer data
                _name = textBoxUserName.Text;
            }
            else
            {
                MessageBox.Show("Mangler brukernavn","Lagre poeng",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
