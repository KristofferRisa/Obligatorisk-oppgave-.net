namespace ubåtspill.Views
{
    partial class Spill
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
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halOfFameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSlow = new System.Windows.Forms.Timer(this.components);
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLevelName = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelHitpoints = new System.Windows.Forms.Label();
            this.timerMid = new System.Windows.Forms.Timer(this.components);
            this.timerFast = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.labelTreff = new System.Windows.Forms.Label();
            this.labelTreffSum = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1307, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttSpillToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.lagreSpillToolStripMenuItem,
            this.avsluttToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(51, 36);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // nyttSpillToolStripMenuItem
            // 
            this.nyttSpillToolStripMenuItem.Name = "nyttSpillToolStripMenuItem";
            this.nyttSpillToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.nyttSpillToolStripMenuItem.Text = "Nytt spill";
            this.nyttSpillToolStripMenuItem.Click += new System.EventHandler(this.nyttSpillToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.pauseToolStripMenuItem.Text = "Pause spill";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // lagreSpillToolStripMenuItem
            // 
            this.lagreSpillToolStripMenuItem.Name = "lagreSpillToolStripMenuItem";
            this.lagreSpillToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.lagreSpillToolStripMenuItem.Text = "Fortsett spill";
            this.lagreSpillToolStripMenuItem.Click += new System.EventHandler(this.lagreSpillToolStripMenuItem_Click);
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.avsluttToolStripMenuItem.Text = "Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // resultaterToolStripMenuItem
            // 
            this.resultaterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halOfFameToolStripMenuItem});
            this.resultaterToolStripMenuItem.Name = "resultaterToolStripMenuItem";
            this.resultaterToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.resultaterToolStripMenuItem.Text = "Resultater";
            // 
            // halOfFameToolStripMenuItem
            // 
            this.halOfFameToolStripMenuItem.Name = "halOfFameToolStripMenuItem";
            this.halOfFameToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.halOfFameToolStripMenuItem.Text = "Hall of fame";
            this.halOfFameToolStripMenuItem.Click += new System.EventHandler(this.halOfFameToolStripMenuItem_Click);
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
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.tipsToolStripMenuItem.Text = "Hjelp";
            this.tipsToolStripMenuItem.Click += new System.EventHandler(this.tipsToolStripMenuItem_Click);
            // 
            // omToolStripMenuItem1
            // 
            this.omToolStripMenuItem1.Name = "omToolStripMenuItem1";
            this.omToolStripMenuItem1.Size = new System.Drawing.Size(170, 38);
            this.omToolStripMenuItem1.Text = "Om";
            this.omToolStripMenuItem1.Click += new System.EventHandler(this.omToolStripMenuItem1_Click);
            // 
            // timerSlow
            // 
            this.timerSlow.Interval = 40;
            this.timerSlow.Tick += new System.EventHandler(this.timerSlow_Tick);
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
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1307, 38);
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
            this.labelPoengSum.Location = new System.Drawing.Point(281, 68);
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
            this.labelX.Location = new System.Drawing.Point(1107, 790);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // labelLevelName
            // 
            this.labelLevelName.AutoSize = true;
            this.labelLevelName.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelName.Location = new System.Drawing.Point(791, 69);
            this.labelLevelName.Name = "labelLevelName";
            this.labelLevelName.Size = new System.Drawing.Size(125, 46);
            this.labelLevelName.TabIndex = 12;
            this.labelLevelName.Text = "Level:";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(1067, 69);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(42, 46);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "1";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(507, 400);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 46);
            this.labelStatus.TabIndex = 14;
            // 
            // labelHitpoints
            // 
            this.labelHitpoints.AutoSize = true;
            this.labelHitpoints.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelHitpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHitpoints.ForeColor = System.Drawing.Color.Red;
            this.labelHitpoints.Location = new System.Drawing.Point(507, 444);
            this.labelHitpoints.Margin = new System.Windows.Forms.Padding(0);
            this.labelHitpoints.Name = "labelHitpoints";
            this.labelHitpoints.Size = new System.Drawing.Size(0, 46);
            this.labelHitpoints.TabIndex = 15;
            // 
            // timerMid
            // 
            this.timerMid.Interval = 25;
            this.timerMid.Tick += new System.EventHandler(this.timerMid_Tick);
            // 
            // timerFast
            // 
            this.timerFast.Interval = 10;
            this.timerFast.Tick += new System.EventHandler(this.timerFast_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 10;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // labelTreff
            // 
            this.labelTreff.AutoSize = true;
            this.labelTreff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreff.Location = new System.Drawing.Point(12, 114);
            this.labelTreff.Name = "labelTreff";
            this.labelTreff.Size = new System.Drawing.Size(112, 46);
            this.labelTreff.TabIndex = 16;
            this.labelTreff.Text = "Treff:";
            // 
            // labelTreffSum
            // 
            this.labelTreffSum.AutoSize = true;
            this.labelTreffSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreffSum.Location = new System.Drawing.Point(281, 112);
            this.labelTreffSum.Name = "labelTreffSum";
            this.labelTreffSum.Size = new System.Drawing.Size(42, 46);
            this.labelTreffSum.TabIndex = 17;
            this.labelTreffSum.Text = "0";
            // 
            // Spill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 822);
            this.Controls.Add(this.labelTreffSum);
            this.Controls.Add(this.labelTreff);
            this.Controls.Add(this.labelHitpoints);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelLevelName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPoengSum);
            this.Controls.Add(this.labelPoeng);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Spill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubåt spill";
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
        private System.Windows.Forms.ToolStripMenuItem avsluttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halOfFameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem1;
        private System.Windows.Forms.Timer timerSlow;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLevelName;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelHitpoints;
        private System.Windows.Forms.Timer timerMid;
        private System.Windows.Forms.Timer timerFast;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelTreff;
        private System.Windows.Forms.Label labelTreffSum;
    }
}

