namespace BoardingDashboard
{
    partial class Dashboard
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
            Sliders = new Button();
            label1 = new Label();
            WCU = new Button();
            label2 = new Label();
            label3 = new Label();
            Travels = new Button();
            SuspendLayout();
            // 
            // Sliders
            // 
            Sliders.BackgroundImage = Properties.Resources.slidershow;
            Sliders.BackgroundImageLayout = ImageLayout.Stretch;
            Sliders.Font = new Font("Segoe UI", 14F);
            Sliders.Location = new Point(12, 12);
            Sliders.Name = "Sliders";
            Sliders.Size = new Size(194, 195);
            Sliders.TabIndex = 0;
            Sliders.TextAlign = ContentAlignment.BottomCenter;
            Sliders.UseVisualStyleBackColor = true;
            Sliders.Click += Sliders_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 210);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Sliders";
            // 
            // WCU
            // 
            WCU.BackgroundImage = Properties.Resources.why_choose_us;
            WCU.BackgroundImageLayout = ImageLayout.Stretch;
            WCU.Font = new Font("Segoe UI", 14F);
            WCU.Location = new Point(227, 12);
            WCU.Name = "WCU";
            WCU.Size = new Size(194, 195);
            WCU.TabIndex = 2;
            WCU.TextAlign = ContentAlignment.BottomCenter;
            WCU.UseVisualStyleBackColor = true;
            WCU.Click += WCU_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 210);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Why Choose US";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 450);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Travels";
            // 
            // Travels
            // 
            Travels.BackgroundImage = Properties.Resources.travels;
            Travels.BackgroundImageLayout = ImageLayout.Stretch;
            Travels.Font = new Font("Segoe UI", 14F);
            Travels.Location = new Point(12, 252);
            Travels.Name = "Travels";
            Travels.Size = new Size(194, 195);
            Travels.TabIndex = 4;
            Travels.TextAlign = ContentAlignment.BottomCenter;
            Travels.UseVisualStyleBackColor = true;
            Travels.Click += Travels_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 473);
            Controls.Add(label3);
            Controls.Add(Travels);
            Controls.Add(label2);
            Controls.Add(WCU);
            Controls.Add(label1);
            Controls.Add(Sliders);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sliders;
        private Label label1;
        private Button WCU;
        private Label label2;
        private Label label3;
        private Button Travels;
    }
}