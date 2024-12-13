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
    public partial class WCUManager : Form
    {
        public WCUManager()
        {
            InitializeComponent();
        }

        private async void WCUManager_Load(object sender, EventArgs e)
        {
            var b = new boarding();

            wcugrid.DataSource = await b.WCUBoxs.ToArrayAsync();
        }

        private void New_Click(object sender, EventArgs e)
        {
            IDOfWCU.Text = "0";
            FaFa.Text = Title.Text = Description.Text = "";
        }

        private async void wcugrid_SelectionChanged(object sender, EventArgs e)
        {
            if (wcugrid.SelectedRows.Count > 0)
            {
                IDOfWCU.Text = wcugrid.SelectedRows[0].Cells[0].Value.ToString();

                var b = new boarding();

                var Selected = await b.WCUBoxs.FirstOrDefaultAsync(x => x.ID == IDOfWCU.Text.IntOrDefault());

                if (Selected != null)
                {
                    FaFa.Text = Selected.IconIDFA;
                    Title.Text = Selected.Title;
                    Description.Text = Selected.Desc;
                }
                else IDOfWCU.Text = "0";
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            var b = new boarding();

            var Selected = await b.WCUBoxs.FirstOrDefaultAsync(x => x.ID == IDOfWCU.Text.IntOrDefault());

            if (Selected != null)
            {
                b.WCUBoxs.Remove(Selected);

                await b.SaveChangesAsync();

                WCUManager_Load(sender, e);
            }
            else MessageBox.Show("Undetectable ID");
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text.Length == 0)
                {
                    MessageBox.Show("Please Fill all Fields");
                    return;
                }
            }

            var b = new boarding();

            var Selected = await b.WCUBoxs.FirstOrDefaultAsync(x => x.ID == IDOfWCU.Text.IntOrDefault());

            if (Selected == null)
            {
                var NewSelected = new WCUBox()
                {
                   Title = Title.Text,
                   Desc = Description.Text,
                   IconIDFA = FaFa.Text
                };

                await b.WCUBoxs.AddAsync(NewSelected);

                await b.SaveChangesAsync();
            }
            else
            {
                Selected.Title = Title.Text;
                Selected.Desc = Description.Text;
                Selected.IconIDFA = FaFa.Text;

                b.WCUBoxs.Update(Selected);

                await b.SaveChangesAsync();
            }

            WCUManager_Load(sender, e);
        }
    }
}
