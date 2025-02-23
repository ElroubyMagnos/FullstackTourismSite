﻿using BoardingDashboard.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardingDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Sliders_Click(object sender, EventArgs e)
        {
            Hide();
            new SlidersManager().ShowDialog();
            Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void WCU_Click(object sender, EventArgs e)
        {
            Hide();
            new WCUManager().ShowDialog();
            Show();
        }

        private void Travels_Click(object sender, EventArgs e)
        {
            Hide();
            new TravelsManager().ShowDialog();
            Show();
        }
    }
}
