namespace MIB1
{
    partial class AdminForm
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
            this.loginpasswords_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // loginpasswords_listBox
            // 
            this.loginpasswords_listBox.FormattingEnabled = true;
            this.loginpasswords_listBox.ItemHeight = 15;
            this.loginpasswords_listBox.Location = new System.Drawing.Point(12, 12);
            this.loginpasswords_listBox.Name = "loginpasswords_listBox";
            this.loginpasswords_listBox.Size = new System.Drawing.Size(438, 364);
            this.loginpasswords_listBox.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 391);
            this.Controls.Add(this.loginpasswords_listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox loginpasswords_listBox;
    }
}