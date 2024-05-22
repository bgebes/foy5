using Foy5.Model.Entity;
using Foy5.Model.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foy5.Screens
{
    public partial class DersCRUD : Form
    {
        public DersCRUD()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void DersCRUD_Load(object sender, EventArgs e)
        {
            DersGridView.DataSource = new tDersOperations().list().Select(x => new
            {
                ID = x.dersID,
                Ad = x.dersAd
            }).ToList();
        }

        private void DersCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();

            if (ad.Length < 1)
            {
                MessageBox.Show("Ad alanı boş olamaz!");
                return;
            }

            tDers ders = new tDers
            {
               dersID = Guid.NewGuid().ToString(),
               dersAd = ad,
            };

            new tDersOperations().create(ders);

            MessageBox.Show("Ders eklendi!");
            DersGridView.DataSource = new tDersOperations().list().Select(x => new
            {
                ID = x.dersID,
                Ad = x.dersAd
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string ad = txt_ad.Text.Trim();


            if (ad.Length < 1)
            {
                MessageBox.Show("Ad alanı boş olamaz!");
                return;
            }

            tDers ders = new tDers
            {
                dersID = id,
                dersAd = ad,
            };

            new tDersOperations().update(ders);

            MessageBox.Show("Ders güncellendi!");
            DersGridView.DataSource = new tDersOperations().list().Select(x => new
            {
                ID = x.dersID,
                Ad = x.dersAd
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;

            new tDersOperations().delete(id);

            MessageBox.Show("Ders silindi!");
            DersGridView.DataSource = new tDersOperations().list().Select(x => new
            {
                ID = x.dersID,
                Ad = x.dersAd
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            btn_ekle.Enabled = txt_id.Text.Trim().Length < 1;
            btn_sil.Enabled = btn_guncelle.Enabled = txt_id.Text.Trim().Length > 0;
        }

        private void DersGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string id = e.Row.Cells[0].Value.ToString();
            string ad = e.Row.Cells[1].Value.ToString();

            tDers ders = new tDersOperations().list().SingleOrDefault((x) => x.dersID == id);
            if (ders == null) return;

            txt_id.Text = ders.dersID;
            txt_ad.Text = ders.dersAd;
        }
    }
}
