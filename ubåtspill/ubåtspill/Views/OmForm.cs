using System.Windows.Forms;

namespace ubåtspill.Views
{
    public partial class OmForm : Form
    {
        public OmForm()
        {
            InitializeComponent();
        }

        private void OmForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    {
                        this.Close();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/KristofferRisa/Obligatorisk-oppgave-.net");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://xn--ubt-vla.azurewebsites.net/");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
