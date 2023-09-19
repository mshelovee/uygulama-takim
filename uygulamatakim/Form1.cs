using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulamatakim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHilal_Click(object sender, EventArgs e)
        {
            lblAd.BackColor = Color.Blue;
            lblAd.ForeColor = Color.Yellow;
            lblAd.Text = "Hilal De Souza";
        }

        private void btnBuse_Click(object sender, EventArgs e)
        {
            lblAd.BackColor = Color.Black;
            lblAd.ForeColor = Color.White;
            lblAd.Text = "Buse Turan";
        }

        private void btnRavza_Click(object sender, EventArgs e)
        {
            lblAd.BackColor = Color.Red;
            lblAd.ForeColor = Color.Yellow;
            lblAd.Text = "Ravza Muslera";
        }

        private void btnNur_Click(object sender, EventArgs e)
        {
            lblAd.BackColor = Color.Black;
            lblAd.ForeColor = Color.White;
            lblAd.Text = "Nur Quaresma";
        }
    }
}
