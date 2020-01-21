namespace MemoryGame
{
    partial class MessageBoxW
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
            this.BT_OK = new System.Windows.Forms.Button();
            this.LB_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_OK
            // 
            this.BT_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_OK.Location = new System.Drawing.Point(195, 111);
            this.BT_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(119, 54);
            this.BT_OK.TabIndex = 0;
            this.BT_OK.Text = "Continue";
            this.BT_OK.UseVisualStyleBackColor = true;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.Location = new System.Drawing.Point(34, 30);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(418, 26);
            this.LB_Text.TabIndex = 1;
            this.LB_Text.Text = "Sorry mate, those cards do not match!";
            // 
            // MessageBoxW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(485, 197);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.BT_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MessageBoxW";
            this.Text = "Incorrect Match";
            this.Load += new System.EventHandler(this.MessageBoxW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.Label LB_Text;
    }
}