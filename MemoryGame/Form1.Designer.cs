namespace MemoryGame
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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LB_Score = new System.Windows.Forms.Label();
            this.bt_CheatHelp = new System.Windows.Forms.Button();
            this.PAN_Mode = new System.Windows.Forms.Panel();
            this.RB_Hard = new System.Windows.Forms.RadioButton();
            this.RB_Easy = new System.Windows.Forms.RadioButton();
            this.PAN_Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "clubs-a-75.png");
            this.imageList.Images.SetKeyName(1, "clubs-2-75.png");
            this.imageList.Images.SetKeyName(2, "clubs-3-75.png");
            this.imageList.Images.SetKeyName(3, "clubs-4-75.png");
            this.imageList.Images.SetKeyName(4, "clubs-5-75.png");
            this.imageList.Images.SetKeyName(5, "clubs-6-75.png");
            this.imageList.Images.SetKeyName(6, "clubs-7-75.png");
            this.imageList.Images.SetKeyName(7, "clubs-8-75.png");
            this.imageList.Images.SetKeyName(8, "diamonds-a-75.png");
            this.imageList.Images.SetKeyName(9, "diamonds-2-75.png");
            this.imageList.Images.SetKeyName(10, "diamonds-3-75.png");
            this.imageList.Images.SetKeyName(11, "diamonds-4-75.png");
            this.imageList.Images.SetKeyName(12, "diamonds-5-75.png");
            this.imageList.Images.SetKeyName(13, "diamonds-6-75.png");
            this.imageList.Images.SetKeyName(14, "diamonds-7-75.png");
            this.imageList.Images.SetKeyName(15, "diamonds-8-75.png");
            this.imageList.Images.SetKeyName(16, "hearts-a-75.png");
            this.imageList.Images.SetKeyName(17, "hearts-2-75.png");
            this.imageList.Images.SetKeyName(18, "hearts-3-75.png");
            this.imageList.Images.SetKeyName(19, "hearts-4-75.png");
            this.imageList.Images.SetKeyName(20, "hearts-5-75.png");
            this.imageList.Images.SetKeyName(21, "hearts-6-75.png");
            this.imageList.Images.SetKeyName(22, "hearts-7-75.png");
            this.imageList.Images.SetKeyName(23, "hearts-8-75.png");
            this.imageList.Images.SetKeyName(24, "spades-a-75.png");
            this.imageList.Images.SetKeyName(25, "spades-2-75.png");
            this.imageList.Images.SetKeyName(26, "spades-3-75.png");
            this.imageList.Images.SetKeyName(27, "spades-4-75.png");
            this.imageList.Images.SetKeyName(28, "spades-5-75.png");
            this.imageList.Images.SetKeyName(29, "spades-6-75.png");
            this.imageList.Images.SetKeyName(30, "spades-7-75.png");
            this.imageList.Images.SetKeyName(31, "spades-8-75.png");
            this.imageList.Images.SetKeyName(32, "joker-b-75.png");
            this.imageList.Images.SetKeyName(33, "joker-r-75.png");
            this.imageList.Images.SetKeyName(34, "back-blue-75-1.png");
            this.imageList.Images.SetKeyName(35, "back-blue-75-2.png");
            this.imageList.Images.SetKeyName(36, "back-blue-75-3.png");
            this.imageList.Images.SetKeyName(37, "back-red-75-1.png");
            this.imageList.Images.SetKeyName(38, "back-red-75-2.png");
            this.imageList.Images.SetKeyName(39, "back-red-75-3.png");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LB_Score
            // 
            this.LB_Score.AutoSize = true;
            this.LB_Score.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Score.ForeColor = System.Drawing.Color.Coral;
            this.LB_Score.Location = new System.Drawing.Point(168, 751);
            this.LB_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Score.Name = "LB_Score";
            this.LB_Score.Size = new System.Drawing.Size(257, 70);
            this.LB_Score.TabIndex = 0;
            this.LB_Score.Text = "Score:  0";
            // 
            // bt_CheatHelp
            // 
            this.bt_CheatHelp.Location = new System.Drawing.Point(1065, 751);
            this.bt_CheatHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_CheatHelp.Name = "bt_CheatHelp";
            this.bt_CheatHelp.Size = new System.Drawing.Size(142, 69);
            this.bt_CheatHelp.TabIndex = 1;
            this.bt_CheatHelp.Text = "Cheat Mode Instructions";
            this.bt_CheatHelp.UseVisualStyleBackColor = true;
            this.bt_CheatHelp.Click += new System.EventHandler(this.bt_CheatHelp_Click);
            // 
            // PAN_Mode
            // 
            this.PAN_Mode.BackColor = System.Drawing.Color.White;
            this.PAN_Mode.Controls.Add(this.RB_Hard);
            this.PAN_Mode.Controls.Add(this.RB_Easy);
            this.PAN_Mode.Location = new System.Drawing.Point(1065, 258);
            this.PAN_Mode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PAN_Mode.Name = "PAN_Mode";
            this.PAN_Mode.Size = new System.Drawing.Size(142, 95);
            this.PAN_Mode.TabIndex = 2;
            // 
            // RB_Hard
            // 
            this.RB_Hard.AutoSize = true;
            this.RB_Hard.Location = new System.Drawing.Point(18, 55);
            this.RB_Hard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Hard.Name = "RB_Hard";
            this.RB_Hard.Size = new System.Drawing.Size(110, 24);
            this.RB_Hard.TabIndex = 1;
            this.RB_Hard.Text = "Impossible";
            this.RB_Hard.UseVisualStyleBackColor = true;
            this.RB_Hard.CheckedChanged += new System.EventHandler(this.RB_Hard_CheckedChanged);
            // 
            // RB_Easy
            // 
            this.RB_Easy.AutoSize = true;
            this.RB_Easy.Checked = true;
            this.RB_Easy.Location = new System.Drawing.Point(18, 20);
            this.RB_Easy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Easy.Name = "RB_Easy";
            this.RB_Easy.Size = new System.Drawing.Size(69, 24);
            this.RB_Easy.TabIndex = 0;
            this.RB_Easy.TabStop = true;
            this.RB_Easy.Text = "Easy";
            this.RB_Easy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1226, 838);
            this.Controls.Add(this.PAN_Mode);
            this.Controls.Add(this.bt_CheatHelp);
            this.Controls.Add(this.LB_Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.PAN_Mode.ResumeLayout(false);
            this.PAN_Mode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LB_Score;
        private System.Windows.Forms.Button bt_CheatHelp;
        private System.Windows.Forms.Panel PAN_Mode;
        private System.Windows.Forms.RadioButton RB_Hard;
        private System.Windows.Forms.RadioButton RB_Easy;
    }
}

