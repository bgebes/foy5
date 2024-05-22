using Foy5.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foy5
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void navigate_ogrenciCRUD(object sender, EventArgs e)
        {
            OgrenciCRUD ogrenciCRUD = new OgrenciCRUD();
            ogrenciCRUD.Show();
            this.Hide();
        }

        private void navigate_dersCRUD(object sender, EventArgs e)
        {
            DersCRUD dersCRUD = new DersCRUD();
            dersCRUD.Show();
            this.Hide();
        }

        private void navigate_bolumCRUD(object sender, EventArgs e)
        {
            BolumCRUD bolumCRUD = new BolumCRUD();
            bolumCRUD.Show();
            this.Hide();
        }

        private void navigate_bindDers(object sender, EventArgs e)
        {
            BindDers bindDers = new BindDers();
            bindDers.Show();
            this.Hide();
        }

        private void navigate_listing(object sender, EventArgs e)
        {
            Listing listing = new Listing();
            listing.Show();
            this.Hide();
        }

        private void navigate_inputGrades(object sender, EventArgs e)
        {
            InputGrades inputGrades = new InputGrades();
            inputGrades.Show();
            this.Hide();
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
