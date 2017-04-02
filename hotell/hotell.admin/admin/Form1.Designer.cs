namespace admin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oversiktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etasjeOversiktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omHotellBooking10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEtasjer = new System.Windows.Forms.TabControl();
            this.tabOversikt = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTildelt = new System.Windows.Forms.Label();
            this.labelIkkeTildeltRom = new System.Windows.Forms.Label();
            this.labelTotaltAntGjester = new System.Windows.Forms.Label();
            this.labelValgtDato = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabNyBooking = new System.Windows.Forms.TabPage();
            this.dateTimePickerTildato = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFradato = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxNavn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Bookinger = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabEtasjer.SuspendLayout();
            this.tabOversikt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabNyBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1130);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1582, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.omToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyBookingToolStripMenuItem,
            this.oversiktToolStripMenuItem,
            this.etasjeOversiktToolStripMenuItem,
            this.avsluttToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(51, 36);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // nyBookingToolStripMenuItem
            // 
            this.nyBookingToolStripMenuItem.Name = "nyBookingToolStripMenuItem";
            this.nyBookingToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.nyBookingToolStripMenuItem.Text = "Ny Booking";
            this.nyBookingToolStripMenuItem.Click += new System.EventHandler(this.nyBookingToolStripMenuItem_Click);
            // 
            // oversiktToolStripMenuItem
            // 
            this.oversiktToolStripMenuItem.Name = "oversiktToolStripMenuItem";
            this.oversiktToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.oversiktToolStripMenuItem.Text = "Oversikt";
            this.oversiktToolStripMenuItem.Click += new System.EventHandler(this.oversiktToolStripMenuItem_Click);
            // 
            // etasjeOversiktToolStripMenuItem
            // 
            this.etasjeOversiktToolStripMenuItem.Name = "etasjeOversiktToolStripMenuItem";
            this.etasjeOversiktToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.etasjeOversiktToolStripMenuItem.Text = "Etasje oversikt";
            this.etasjeOversiktToolStripMenuItem.Click += new System.EventHandler(this.etasjeOversiktToolStripMenuItem_Click);
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.avsluttToolStripMenuItem.Text = "Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omHotellBooking10ToolStripMenuItem});
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.omToolStripMenuItem.Text = "Om";
            // 
            // omHotellBooking10ToolStripMenuItem
            // 
            this.omHotellBooking10ToolStripMenuItem.Name = "omHotellBooking10ToolStripMenuItem";
            this.omHotellBooking10ToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.omHotellBooking10ToolStripMenuItem.Text = "Om Hotell Booking 1.0";
            this.omHotellBooking10ToolStripMenuItem.Click += new System.EventHandler(this.omHotellBooking10ToolStripMenuItem_Click);
            // 
            // tabEtasjer
            // 
            this.tabEtasjer.Controls.Add(this.tabOversikt);
            this.tabEtasjer.Controls.Add(this.tabPage1);
            this.tabEtasjer.Controls.Add(this.tabPage2);
            this.tabEtasjer.Controls.Add(this.tabPage3);
            this.tabEtasjer.Controls.Add(this.tabNyBooking);
            this.tabEtasjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEtasjer.Location = new System.Drawing.Point(573, 116);
            this.tabEtasjer.Name = "tabEtasjer";
            this.tabEtasjer.SelectedIndex = 0;
            this.tabEtasjer.Size = new System.Drawing.Size(799, 929);
            this.tabEtasjer.TabIndex = 8;
            // 
            // tabOversikt
            // 
            this.tabOversikt.Controls.Add(this.listBox2);
            this.tabOversikt.Controls.Add(this.label8);
            this.tabOversikt.Controls.Add(this.label7);
            this.tabOversikt.Controls.Add(this.labelTildelt);
            this.tabOversikt.Controls.Add(this.labelIkkeTildeltRom);
            this.tabOversikt.Controls.Add(this.labelTotaltAntGjester);
            this.tabOversikt.Controls.Add(this.labelValgtDato);
            this.tabOversikt.Controls.Add(this.button1);
            this.tabOversikt.Controls.Add(this.label6);
            this.tabOversikt.Controls.Add(this.label5);
            this.tabOversikt.Location = new System.Drawing.Point(8, 51);
            this.tabOversikt.Name = "tabOversikt";
            this.tabOversikt.Padding = new System.Windows.Forms.Padding(3);
            this.tabOversikt.Size = new System.Drawing.Size(783, 870);
            this.tabOversikt.TabIndex = 3;
            this.tabOversikt.Text = "Oversikt";
            this.tabOversikt.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 37);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dagens gjester";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // labelTildelt
            // 
            this.labelTildelt.AllowDrop = true;
            this.labelTildelt.AutoSize = true;
            this.labelTildelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTildelt.Location = new System.Drawing.Point(673, 263);
            this.labelTildelt.Name = "labelTildelt";
            this.labelTildelt.Size = new System.Drawing.Size(35, 37);
            this.labelTildelt.TabIndex = 17;
            this.labelTildelt.Text = "0";
            // 
            // labelIkkeTildeltRom
            // 
            this.labelIkkeTildeltRom.AllowDrop = true;
            this.labelIkkeTildeltRom.AutoSize = true;
            this.labelIkkeTildeltRom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIkkeTildeltRom.Location = new System.Drawing.Point(554, 263);
            this.labelIkkeTildeltRom.Name = "labelIkkeTildeltRom";
            this.labelIkkeTildeltRom.Size = new System.Drawing.Size(35, 37);
            this.labelIkkeTildeltRom.TabIndex = 16;
            this.labelIkkeTildeltRom.Text = "0";
            // 
            // labelTotaltAntGjester
            // 
            this.labelTotaltAntGjester.AllowDrop = true;
            this.labelTotaltAntGjester.AutoSize = true;
            this.labelTotaltAntGjester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotaltAntGjester.Location = new System.Drawing.Point(673, 187);
            this.labelTotaltAntGjester.Name = "labelTotaltAntGjester";
            this.labelTotaltAntGjester.Size = new System.Drawing.Size(35, 37);
            this.labelTotaltAntGjester.TabIndex = 15;
            this.labelTotaltAntGjester.Text = "0";
            // 
            // labelValgtDato
            // 
            this.labelValgtDato.AllowDrop = true;
            this.labelValgtDato.AutoSize = true;
            this.labelValgtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValgtDato.Location = new System.Drawing.Point(47, 54);
            this.labelValgtDato.Name = "labelValgtDato";
            this.labelValgtDato.Size = new System.Drawing.Size(0, 55);
            this.labelValgtDato.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 698);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 134);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ny booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ikke tildelt / tildelt rom";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Antall gjester:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(8, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 870);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1.etasje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Romoversikt";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(8, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 870);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2.etasje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "Romoversikt";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(8, 51);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(783, 870);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3.etg";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 44);
            this.label4.TabIndex = 1;
            this.label4.Text = "Romoversikt";
            // 
            // tabNyBooking
            // 
            this.tabNyBooking.Controls.Add(this.dateTimePickerTildato);
            this.tabNyBooking.Controls.Add(this.dateTimePickerFradato);
            this.tabNyBooking.Controls.Add(this.button2);
            this.tabNyBooking.Controls.Add(this.textBoxAdr);
            this.tabNyBooking.Controls.Add(this.textBoxTelefon);
            this.tabNyBooking.Controls.Add(this.textBoxNavn);
            this.tabNyBooking.Controls.Add(this.label14);
            this.tabNyBooking.Controls.Add(this.label13);
            this.tabNyBooking.Controls.Add(this.label12);
            this.tabNyBooking.Controls.Add(this.label11);
            this.tabNyBooking.Controls.Add(this.label10);
            this.tabNyBooking.Controls.Add(this.label9);
            this.tabNyBooking.Location = new System.Drawing.Point(8, 51);
            this.tabNyBooking.Name = "tabNyBooking";
            this.tabNyBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabNyBooking.Size = new System.Drawing.Size(783, 870);
            this.tabNyBooking.TabIndex = 5;
            this.tabNyBooking.Text = "Ny booking";
            this.tabNyBooking.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTildato
            // 
            this.dateTimePickerTildato.Location = new System.Drawing.Point(438, 272);
            this.dateTimePickerTildato.Name = "dateTimePickerTildato";
            this.dateTimePickerTildato.Size = new System.Drawing.Size(244, 44);
            this.dateTimePickerTildato.TabIndex = 22;
            // 
            // dateTimePickerFradato
            // 
            this.dateTimePickerFradato.Location = new System.Drawing.Point(438, 178);
            this.dateTimePickerFradato.Name = "dateTimePickerFradato";
            this.dateTimePickerFradato.Size = new System.Drawing.Size(244, 44);
            this.dateTimePickerFradato.TabIndex = 21;
            this.dateTimePickerFradato.ValueChanged += new System.EventHandler(this.dateTimePickerFradato_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(48, 718);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 134);
            this.button2.TabIndex = 20;
            this.button2.Text = "Lagre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Location = new System.Drawing.Point(438, 548);
            this.textBoxAdr.Multiline = true;
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(244, 130);
            this.textBoxAdr.TabIndex = 19;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(438, 460);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(244, 44);
            this.textBoxTelefon.TabIndex = 18;
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.Location = new System.Drawing.Point(438, 362);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(244, 44);
            this.textBoxNavn.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 37);
            this.label14.TabIndex = 16;
            this.label14.Text = "Adresse:";
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 37);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telefon:";
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "Navn:";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "Til dato:";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(359, 55);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ny reservasjon";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fra dato:";
            // 
            // Bookinger
            // 
            this.Bookinger.AutoSize = true;
            this.Bookinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookinger.Location = new System.Drawing.Point(39, 500);
            this.Bookinger.Name = "Bookinger";
            this.Bookinger.Size = new System.Drawing.Size(264, 37);
            this.Bookinger.TabIndex = 12;
            this.Bookinger.Text = "Gjester uten rom:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(46, 562);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 479);
            this.listBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Velg en dato:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(39, 133);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected_1);
            // 
            // listBox2
            // 
            this.listBox2.DisplayMember = "CustomerName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 37;
            this.listBox2.Location = new System.Drawing.Point(54, 396);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(654, 263);
            this.listBox2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1152);
            this.Controls.Add(this.tabEtasjer);
            this.Controls.Add(this.Bookinger);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hotell Booking 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEtasjer.ResumeLayout(false);
            this.tabOversikt.ResumeLayout(false);
            this.tabOversikt.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabNyBooking.ResumeLayout(false);
            this.tabNyBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabEtasjer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Bookinger;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelValgtDato;
        private System.Windows.Forms.TabPage tabOversikt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTildelt;
        private System.Windows.Forms.Label labelIkkeTildeltRom;
        private System.Windows.Forms.Label labelTotaltAntGjester;
        private System.Windows.Forms.TabPage tabNyBooking;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNavn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTildato;
        private System.Windows.Forms.DateTimePicker dateTimePickerFradato;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oversiktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etasjeOversiktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avsluttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omHotellBooking10ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
    }
}

