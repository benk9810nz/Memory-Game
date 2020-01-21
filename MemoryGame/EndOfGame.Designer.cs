namespace MemoryGame
{
    partial class EndOfGame
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
            this.button2 = new System.Windows.Forms.Button();
            this.LB_End = new System.Windows.Forms.Label();
            this.LB_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button2.Location = new System.Drawing.Point(175, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "I Admit Defeat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LB_End
            // 
            this.LB_End.AutoSize = true;
            this.LB_End.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_End.Location = new System.Drawing.Point(14, 11);
            this.LB_End.Name = "LB_End";
            this.LB_End.Size = new System.Drawing.Size(422, 48);
            this.LB_End.TabIndex = 2;
            this.LB_End.Text = "The End has Arisen";
            // 
            // LB_Score
            // 
            this.LB_Score.AutoSize = true;
            this.LB_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Score.Location = new System.Drawing.Point(69, 84);
            this.LB_Score.Name = "LB_Score";
            this.LB_Score.Size = new System.Drawing.Size(170, 29);
            this.LB_Score.TabIndex = 3;
            this.LB_Score.Text = "Your Score is: ";
            // 
            // EndOfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 258);
            this.Controls.Add(this.LB_Score);
            this.Controls.Add(this.LB_End);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EndOfGame";
            this.Text = "Da Da THE END";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LB_End;
        private System.Windows.Forms.Label LB_Score;
    }
}