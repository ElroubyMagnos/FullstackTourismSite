namespace BoardingDashboard.Windows
{
    partial class TravelsManager
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
            New = new Button();
            Save = new Button();
            Delete = new Button();
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
            // TravelsManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 342);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(New);
            Controls.Add(wcugrid);
            Name = "TravelsManager";
            Text = "WCUManager";
            Load += TravelsManager_Load;
            ((System.ComponentModel.ISupportInitialize)wcugrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView wcugrid;
        private Button New;
        private Button Save;
        private Button Delete;
    }
}