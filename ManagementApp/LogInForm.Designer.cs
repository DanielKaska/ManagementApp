namespace ManagementApp
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.betterButton1 = new ManagementApp.BetterButton();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(86)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 10);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zaloguj";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betterButton1
            // 
            this.betterButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.betterButton1.ButtonSize = new System.Drawing.Size(150, 50);
            this.betterButton1.ButtonText = "Zaloguj";
            this.betterButton1.Location = new System.Drawing.Point(150, 280);
            this.betterButton1.Name = "betterButton1";
            this.betterButton1.Size = new System.Drawing.Size(150, 50);
            this.betterButton1.TabIndex = 2;
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LoginBox.Location = new System.Drawing.Point(150, 136);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(150, 20);
            this.LoginBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.PasswordBox.Location = new System.Drawing.Point(150, 196);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(150, 20);
            this.PasswordBox.TabIndex = 4;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(450, 382);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.betterButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "Zaloguj się";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Panel panel1;
        public Label label1;
        private BetterButton betterButton1;
        private TextBox LoginBox;
        private MaskedTextBox PasswordBox;
    }
}