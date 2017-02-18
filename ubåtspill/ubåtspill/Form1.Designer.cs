namespace ubåtspill
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttSpillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagreSpillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hentSpillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halOfFameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBåter = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.powerBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.life1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.life2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.life3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTorpedo = new System.Windows.Forms.Timer(this.components);
            this.labelPoeng = new System.Windows.Forms.Label();
            this.labelPoengSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHighscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.resultaterToolStripMenuItem,
            this.omToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttSpillToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.lagreSpillToolStripMenuItem,
            this.hentSpillToolStripMenuItem,
            this.avsluttToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(51, 36);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // nyttSpillToolStripMenuItem
            // 
            this.nyttSpillToolStripMenuItem.Name = "nyttSpillToolStripMenuItem";
            this.nyttSpillToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.nyttSpillToolStripMenuItem.Text = "Nytt spill";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.pauseToolStripMenuItem.Text = "Pause spill";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // lagreSpillToolStripMenuItem
            // 
            this.lagreSpillToolStripMenuItem.Name = "lagreSpillToolStripMenuItem";
            this.lagreSpillToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.lagreSpillToolStripMenuItem.Text = "Lagre spill";
            // 
            // hentSpillToolStripMenuItem
            // 
            this.hentSpillToolStripMenuItem.Name = "hentSpillToolStripMenuItem";
            this.hentSpillToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.hentSpillToolStripMenuItem.Text = "Hent spill";
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.avsluttToolStripMenuItem.Text = "Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // resultaterToolStripMenuItem
            // 
            this.resultaterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top10ListeToolStripMenuItem,
            this.halOfFameToolStripMenuItem});
            this.resultaterToolStripMenuItem.Name = "resultaterToolStripMenuItem";
            this.resultaterToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.resultaterToolStripMenuItem.Text = "Resultater";
            // 
            // top10ListeToolStripMenuItem
            // 
            this.top10ListeToolStripMenuItem.Name = "top10ListeToolStripMenuItem";
            this.top10ListeToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.top10ListeToolStripMenuItem.Text = "Top 10 liste";
            // 
            // halOfFameToolStripMenuItem
            // 
            this.halOfFameToolStripMenuItem.Name = "halOfFameToolStripMenuItem";
            this.halOfFameToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.halOfFameToolStripMenuItem.Text = "Hall of fame";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipsToolStripMenuItem,
            this.omToolStripMenuItem1});
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.omToolStripMenuItem.Text = "Hjelp";
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.tipsToolStripMenuItem.Text = "Tips";
            // 
            // omToolStripMenuItem1
            // 
            this.omToolStripMenuItem1.Name = "omToolStripMenuItem1";
            this.omToolStripMenuItem1.Size = new System.Drawing.Size(157, 38);
            this.omToolStripMenuItem1.Text = "Om";
            // 
            // timerBåter
            // 
            this.timerBåter.Interval = 1;
            this.timerBåter.Tick += new System.EventHandler(this.timerBåter_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.powerBar,
            this.toolStripStatusLabel2,
            this.life1,
            this.life2,
            this.life3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 784);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1306, 38);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 33);
            this.toolStripStatusLabel1.Text = "Power";
            // 
            // powerBar
            // 
            this.powerBar.Name = "powerBar";
            this.powerBar.Size = new System.Drawing.Size(200, 32);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 33);
            this.toolStripStatusLabel2.Text = "Life: ";
            // 
            // life1
            // 
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(45, 33);
            this.life1.Text = "_-_";
            // 
            // life2
            // 
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(45, 33);
            this.life2.Text = "_-_";
            // 
            // life3
            // 
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(45, 33);
            this.life3.Text = "_-_";
            // 
            // timerTorpedo
            // 
            this.timerTorpedo.Interval = 15;
            this.timerTorpedo.Tick += new System.EventHandler(this.timerTorpedo_Tick);
            // 
            // labelPoeng
            // 
            this.labelPoeng.AutoSize = true;
            this.labelPoeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoeng.Location = new System.Drawing.Point(12, 68);
            this.labelPoeng.Name = "labelPoeng";
            this.labelPoeng.Size = new System.Drawing.Size(158, 46);
            this.labelPoeng.TabIndex = 4;
            this.labelPoeng.Text = "Poeng: ";
            // 
            // labelPoengSum
            // 
            this.labelPoengSum.AutoSize = true;
            this.labelPoengSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoengSum.Location = new System.Drawing.Point(248, 68);
            this.labelPoengSum.Name = "labelPoengSum";
            this.labelPoengSum.Size = new System.Drawing.Size(42, 46);
            this.labelPoengSum.TabIndex = 5;
            this.labelPoengSum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1075, 788);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1181, 788);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(1106, 790);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(0, 25);
            this.labelX.TabIndex = 8;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(1208, 788);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(0, 25);
            this.labelY.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Highscore:";
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighscore.Location = new System.Drawing.Point(1066, 68);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(42, 46);
            this.labelHighscore.TabIndex = 11;
            this.labelHighscore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(332, 329);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(553, 217);
            this.labelLevel.TabIndex = 12;
            this.labelLevel.Text = "Level";
            this.labelLevel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 822);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHighscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPoengSum);
            this.Controls.Add(this.labelPoeng);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttSpillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreSpillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hentSpillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avsluttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10ListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halOfFameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem1;
        private System.Windows.Forms.Timer timerBåter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar powerBar;
        private System.Windows.Forms.Timer timerTorpedo;
        private System.Windows.Forms.Label labelPoeng;
        private System.Windows.Forms.Label labelPoengSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel life1;
        private System.Windows.Forms.ToolStripStatusLabel life2;
        private System.Windows.Forms.ToolStripStatusLabel life3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHighscore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLevel;
    }
}

