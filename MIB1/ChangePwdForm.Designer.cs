namespace MIB1
{
    partial class ChangePwdForm
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
            this.reg_button = new System.Windows.Forms.Button();
            this.pwd1_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwd2_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(13, 102);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(196, 23);
            this.reg_button.TabIndex = 16;
            this.reg_button.Text = "Сменить пароль";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // pwd1_textBox
            // 
            this.pwd1_textBox.Location = new System.Drawing.Point(109, 44);
            this.pwd1_textBox.Name = "pwd1_textBox";
            this.pwd1_textBox.Size = new System.Drawing.Size(100, 23);
            this.pwd1_textBox.TabIndex = 15;
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(109, 12);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(100, 23);
            this.login_textBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "старый пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "логин";
            // 
            // pwd2_textBox
            // 
            this.pwd2_textBox.Location = new System.Drawing.Point(109, 73);
            this.pwd2_textBox.Name = "pwd2_textBox";
            this.pwd2_textBox.Size = new System.Drawing.Size(100, 23);
            this.pwd2_textBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "новый пароль";
            // 
            // ChangePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 141);
            this.Controls.Add(this.pwd2_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.pwd1_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePwdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button reg_button;
        private TextBox pwd1_textBox;
        private TextBox login_textBox;
        private Label label2;
        private Label label1;
        private TextBox pwd2_textBox;
        private Label label3;
    }
}