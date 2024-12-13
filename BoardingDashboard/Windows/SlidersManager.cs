using boardingdata;
using boardingdata.Models;
using DesktopSupport;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardingDashboard.Windows
{
    public partial class SlidersManager : Form
    {
        public SlidersManager()
        {
            InitializeComponent();
        }

        private async void Picture_Click(object sender, EventArgs e)
        {
            if (OpenPictureDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Load(OpenPictureDialog.FileName);
                Width.Text = Height.Text = "";

                if (Picture.Image != null)
                {
                    Width.Text = Picture.Image.Width.ToString();
                    Height.Text = Picture.Image.Height.ToString();
                }
            }
        }

        private async void SlidersManager_Load(object sender, EventArgs e)
        {
            boarding b = new boarding();

            PicGrid.DataSource = await b.SliderImages.ToArrayAsync();
            (PicGrid.Columns[1] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            if (Picture.Image == null)
            {
                MessageBox.Show("Invalid Image");
            }
            else if (PictureName.Text.Length == 0)
            {
                MessageBox.Show("Missing Picture Name");
            }
            else if (PictureDesc.Text.Length == 0)
            {
                MessageBox.Show("Missing Picture Description");
            }
            else if (Width.Text.IntOrDefault() < 500 || Height.Text.IntOrDefault() < 500)
            {
                MessageBox.Show("Image is Small for Showing in Slider Home Page on the site");
            }
            else
            {
                var b = new boarding();

                var slider = await b.SliderImages.FirstOrDefaultAsync(x => x.ID == IDofimage.Text.IntOrDefault());

                if (slider != null)
                {
                    slider.Image = Picture.Image.ToArray();
                    slider.Title = PictureName.Text;
                    slider.Desc = PictureDesc.Text;

                    b.SliderImages.Update(slider);
                    await b.SaveChangesAsync();
                }
                else
                {
                    var sliderimg = new HeaderSliderImage();

                    sliderimg.Image = Picture.Image.ToArray();
                    sliderimg.Title = PictureName.Text;
                    sliderimg.Desc = PictureDesc.Text;

                    await b.SliderImages.AddAsync(sliderimg);
                    await b.SaveChangesAsync();
                }

                SlidersManager_Load(sender, e);
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            Picture.Image = null;
            Width.Text = Height.Text = "";
            PictureName.Text = PictureDesc.Text = "";
            IDofimage.Text = "0";
        }

        private void PicGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (PicGrid.SelectedRows.Count > 0)
            {
                IDofimage.Text = PicGrid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private async void IDofimage_TextChanged(object sender, EventArgs e)
        {
            if (IDofimage.Text.Length > 0)
            {
                var b = new boarding();

                var Current = await b.SliderImages.FirstOrDefaultAsync(x => x.ID == int.Parse(IDofimage.Text));
                if (Current != null)
                {
                    PictureName.Text = Current.Title;
                    PictureDesc.Text = Current.Desc;

                    Picture.Image = Current.Image.ToImage();

                    Width.Text = Picture.Image.Width.ToString();
                    Height.Text = Picture.Image.Height.ToString();
                }
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            var b = new boarding();

            var selected = await b.SliderImages.FirstOrDefaultAsync(x => x.ID == IDofimage.Text.IntOrDefault());

            if (selected != null)
            {
                b.SliderImages.Remove(selected);
                await b.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Can't target the line to delete");
            }

            SlidersManager_Load(sender, e);
        }
    }
}
