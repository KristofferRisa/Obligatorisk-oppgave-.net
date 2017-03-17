using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listBox1.AllowDrop = true;
            this.listBox1.MouseDown += new MouseEventHandler(listBox1_MouseDown);
            this.listBox1.DragOver += new DragEventHandler(listBox1_DragOver);


            var data = new List<string>()
            {
                "Arne"
                ,
                "Thor"
            };
            listBox1.DataSource = data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 4; i++)
            {
                Label l = new Label();
                l.AutoSize = true;
                l.BackColor = System.Drawing.Color.LightGreen;
                l.Location = new System.Drawing.Point(30, 40*i);
                l.Name = $"Rom{i}";
                l.Size = new System.Drawing.Size(109, 37);
                l.TabIndex = i;
                l.Text = $"Rom {i}";
                panel2etasje.Controls.Add(l);
                
            }
            Refresh();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
