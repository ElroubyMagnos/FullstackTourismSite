namespace BoardingDashboard.Windows
{
    partial class WCUManager
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
            wcugrid = new DataGridView();
            FaFa = new TextBox();
            Title = new TextBox();
            Description = new TextBox();
            New = new Button();
            Save = new Button();
            Delete = new Button();
            GetFA = new LinkLabel();
            IDOfWCU = new TextBox();
            ((System.ComponentModel.ISupportInitialize)wcugrid).BeginInit();
            SuspendLayout();
            // 
            // wcugrid
            // 
            wcugrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wcugrid.Location = new Point(12, 12);
            wcugrid.Name = "wcugrid";
            wcugrid.Size = new Size(447, 174);
            wcugrid.TabIndex = 0;
            wcugrid.SelectionChanged += wcugrid_SelectionChanged;
            // 
            // FaFa
            // 
            FaFa.Location = new Point(12, 192);
            FaFa.Name = "FaFa";
            FaFa.PlaceholderText = "Fontawesome ID";
            FaFa.Size = new Size(121, 23);
            FaFa.TabIndex = 1;
            // 
            // Title
            // 
            Title.Location = new Point(12, 221);
            Title.Name = "Title";
            Title.PlaceholderText = "Title";
            Title.Size = new Size(274, 23);
            Title.TabIndex = 2;
            // 
            // Description
            // 
            Description.Location = new Point(12, 250);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.PlaceholderText = "Description";
            Description.Size = new Size(274, 80);
            Description.TabIndex = 3;
            // 
            // New
            // 
            New.Location = new Point(384, 192);
            New.Name = "New";
            New.Size = new Size(75, 23);
            New.TabIndex = 4;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Save
            // 
            Save.Location = new Point(384, 221);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(384, 307);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 6;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // GetFA
            // 
            GetFA.AutoSize = true;
            GetFA.Location = new Point(188, 196);
            GetFA.Name = "GetFA";
            GetFA.Size = new Size(124, 15);
            GetFA.TabIndex = 7;
            GetFA.TabStop = true;
            GetFA.Text = "https://cutt.us/xhXHY";
            // 
            // IDOfWCU
            // 
            IDOfWCU.Location = new Point(139, 192);
            IDOfWCU.Name = "IDOfWCU";
            IDOfWCU.PlaceholderText = "ID";
            IDOfWCU.ReadOnly = true;
            IDOfWCU.Size = new Size(43, 23);
            IDOfWCU.TabIndex = 8;
            IDOfWCU.Text = "0";
            // 
            // WCUManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 342);
            Controls.Add(IDOfWCU);
            Controls.Add(GetFA);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(New);
            Controls.Add(Description);
            Controls.Add(Title);
            Controls.Add(FaFa);
            Controls.Add(wcugrid);
            Name = "WCUManager";
            Text = "WCUManager";
            Load += WCUManager_Load;
            ((System.ComponentModel.ISupportInitialize)wcugrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView wcugrid;
        private TextBox FaFa;
        private TextBox Title;
        private TextBox Description;
        private Button New;
        private Button Save;
        private Button Delete;
        private LinkLabel GetFA;
        private TextBox IDOfWCU;
    }
}