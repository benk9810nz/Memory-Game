namespace MemoryGame
{
    partial class MessageBoxR
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
            this.LB_Text = new System.Windows.Forms.Label();
            this.BT_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.Location = new System.Drawing.Point(1, 34);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(392, 26);
            this.LB_Text.TabIndex = 3;
            this.LB_Text.Text = "Congratulations, those Cards Match";
            // 
            // BT_OK
            // 
            this.BT_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_OK.Location = new System.Drawing.Point(130, 130);
            this.BT_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(119, 54);
            this.BT_OK.TabIndex = 2;
            this.BT_OK.Text = "Continue";
            this.BT_OK.UseVisualStyleBackColor = true;
            // 
            // MessageBoxR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 234);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.BT_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MessageBoxR";
            this.Text = "Correct Match";
            this.Load += new System.EventHandler(this.MessageBoxR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.Button BT_OK;
    }
}