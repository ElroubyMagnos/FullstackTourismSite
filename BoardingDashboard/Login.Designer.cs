namespace BoardingDashboard
{
    partial class Login
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
            Username = new TextBox();
            Password = new TextBox();
            Enter = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(12, 12);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(186, 23);
            Username.TabIndex = 0;
            Username.KeyDown += Username_KeyDown;
            // 
            // Password
            // 
            Password.Location = new Point(12, 41);
            Password.MaxLength = 6;
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(186, 23);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            Password.KeyDown += Username_KeyDown;
            // 
            // Enter
            // 
            Enter.Location = new Point(123, 70);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 2;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 104);
            Controls.Add(Enter);
            Controls.Add(Password);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Button Enter;
    }
}
