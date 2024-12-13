namespace BoardingDashboard.Windows
{
    partial class SlidersManager
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
            PicGrid = new DataGridView();
            Picture = new PictureBox();
            Width = new TextBox();
            Height = new TextBox();
            label1 = new Label();
            label2 = new Label();
            picdim = new GroupBox();
            Save = new Button();
            PictureDesc = new TextBox();
            PictureName = new TextBox();
            New = new Button();
            OpenPictureDialog = new OpenFileDialog();
            IDofimage = new TextBox();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)PicGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            picdim.SuspendLayout();
            SuspendLayout();
            // 
            // PicGrid
            // 
            PicGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PicGrid.Location = new Point(12, 12);
            PicGrid.Name = "PicGrid";
            PicGrid.Size = new Size(385, 150);
            PicGrid.TabIndex = 0;
            PicGrid.SelectionChanged += PicGrid_SelectionChanged;
            // 
            // Picture
            // 
            Picture.BackColor = SystemColors.ActiveBorder;
            Picture.BackgroundImageLayout = ImageLayout.Stretch;
            Picture.Location = new Point(403, 12);
            Picture.Name = "Picture";
            Picture.Size = new Size(221, 150);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 1;
            Picture.TabStop = false;
            Picture.Click += Picture_Click;
            // 
            // Width
            // 
            Width.Location = new Point(75, 28);
            Width.Name = "Width";
            Width.ReadOnly = true;
            Width.Size = new Size(100, 23);
            Width.TabIndex = 2;
            // 
            // Height
            // 
            Height.Location = new Point(75, 57);
            Height.Name = "Height";
            Height.ReadOnly = true;
            Height.Size = new Size(100, 23);
            Height.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 60);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Height:";
            // 
            // picdim
            // 
            picdim.Controls.Add(label1);
            picdim.Controls.Add(label2);
            picdim.Controls.Add(Width);
            picdim.Controls.Add(Height);
            picdim.Location = new Point(413, 168);
            picdim.Name = "picdim";
            picdim.Size = new Size(200, 100);
            picdim.TabIndex = 6;
            picdim.TabStop = false;
            picdim.Text = "Picture Dimensions";
            // 
            // Save
            // 
            Save.Location = new Point(93, 274);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // PictureDesc
            // 
            PictureDesc.Location = new Point(12, 196);
            PictureDesc.Multiline = true;
            PictureDesc.Name = "PictureDesc";
            PictureDesc.PlaceholderText = "Picture Description";
            PictureDesc.Size = new Size(385, 72);
            PictureDesc.TabIndex = 1;
            // 
            // PictureName
            // 
            PictureName.Location = new Point(12, 167);
            PictureName.Name = "PictureName";
            PictureName.PlaceholderText = "Picture Name";
            PictureName.Size = new Size(203, 23);
            PictureName.TabIndex = 9;
            // 
            // New
            // 
            New.Location = new Point(12, 274);
            New.Name = "New";
            New.Size = new Size(75, 23);
            New.TabIndex = 3;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // OpenPictureDialog
            // 
            OpenPictureDialog.DefaultExt = "jpg";
            OpenPictureDialog.Filter = "JPG files|*.jpg";
            // 
            // IDofimage
            // 
            IDofimage.Location = new Point(339, 167);
            IDofimage.Name = "IDofimage";
            IDofimage.PlaceholderText = "ID";
            IDofimage.ReadOnly = true;
            IDofimage.Size = new Size(58, 23);
            IDofimage.TabIndex = 11;
            IDofimage.Text = "0";
            IDofimage.TextAlign = HorizontalAlignment.Center;
            IDofimage.TextChanged += IDofimage_TextChanged;
            // 
            // Delete
            // 
            Delete.Location = new Point(322, 274);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // SlidersManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 314);
            Controls.Add(Delete);
            Controls.Add(IDofimage);
            Controls.Add(New);
            Controls.Add(PictureName);
            Controls.Add(PictureDesc);
            Controls.Add(Save);
            Controls.Add(picdim);
            Controls.Add(Picture);
            Controls.Add(PicGrid);
            Name = "SlidersManager";
            Text = "SlidersManager";
            Load += SlidersManager_Load;
            ((System.ComponentModel.ISupportInitialize)PicGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            picdim.ResumeLayout(false);
            picdim.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PicGrid;
        private PictureBox Picture;
        private TextBox Width;
        private TextBox Height;
        private Label label1;
        private Label label2;
        private GroupBox picdim;
        private Button Save;
        private TextBox PictureDesc;
        private TextBox PictureName;
        private Button New;
        private OpenFileDialog OpenPictureDialog;
        private TextBox IDofimage;
        private Button Delete;
    }
}