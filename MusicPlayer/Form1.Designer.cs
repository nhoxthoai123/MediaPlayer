namespace MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MusicBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VolumeBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.btnStop = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnPause = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnPlay = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnLoad = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPre = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnNext = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSet = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerPlayback = new System.Windows.Forms.Timer(this.components);
            this.btnUndo = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(0, 1);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(862, 46);
            this.musicPlayer.TabIndex = 0;
            this.musicPlayer.Visible = false;
            this.musicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlayer_PlayStateChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MusicBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VolumeBar);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 117);
            this.panel1.TabIndex = 1;
            // 
            // MusicBar
            // 
            this.MusicBar.Location = new System.Drawing.Point(29, 11);
            this.MusicBar.Name = "MusicBar";
            this.MusicBar.Size = new System.Drawing.Size(809, 23);
            this.MusicBar.TabIndex = 10;
            this.MusicBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(679, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lenght: 0:00 / 0:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(576, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volume";
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(576, 72);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(262, 23);
            this.VolumeBar.TabIndex = 8;
            this.VolumeBar.ThumbColor = System.Drawing.Color.Gray;
            this.VolumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeBar_Scroll);
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 10;
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(433, 47);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 59);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BorderRadius = 10;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(290, 47);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(137, 59);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "PAUSE";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BorderRadius = 10;
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(147, 47);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(137, 59);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 10;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(11, 47);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(130, 59);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 355);
            this.listBox1.TabIndex = 2;
            // 
            // btnPre
            // 
            this.btnPre.BorderRadius = 10;
            this.btnPre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPre.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPre.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.Location = new System.Drawing.Point(70, 442);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(155, 40);
            this.btnPre.TabIndex = 6;
            this.btnPre.Text = "<<";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 10;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(231, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 40);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(499, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(353, 316);
            this.listBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(174, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Import songs :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(650, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Timer :";
            // 
            // btnSet
            // 
            this.btnSet.BorderRadius = 10;
            this.btnSet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSet.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(699, 442);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(155, 40);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "SET";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker.Location = new System.Drawing.Point(732, 406);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 14;
            // 
            // timerPlayback
            // 
            this.timerPlayback.Interval = 850;
            this.timerPlayback.Tick += new System.EventHandler(this.timerPlayback_Tick);
            // 
            // btnUndo
            // 
            this.btnUndo.BorderRadius = 10;
            this.btnUndo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUndo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUndo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUndo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUndo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUndo.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(515, 442);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(155, 40);
            this.btnUndo.TabIndex = 15;
            this.btnUndo.Text = "UNDO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 618);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.musicPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnLoad;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnPlay;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnStop;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnPause;
        private System.Windows.Forms.ListBox listBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar VolumeBar;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnPre;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnSet;
        private System.Windows.Forms.TextBox textBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar MusicBar;
        private System.Windows.Forms.Timer timerPlayback;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnUndo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

