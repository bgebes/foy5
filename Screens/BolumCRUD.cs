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
    public partial class BolumCRUD : Form
    {
        public BolumCRUD()
        {
            InitializeComponent();
        }

        private void BolumCRUD_Load(object sender, EventArgs e)
        {
            BolumGridView.DataSource = new tBolumOperations().list().Select(x => new
            {
                Ad = x.bolumAd,
                Fakülte = x.fakulte.fakulteAd,
            }).ToList();

            foreach (var item in new tFakulteOperations().list())
            {
                box_fakulte.Items.Add(item.fakulteAd);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();

            tFakulte fakulte = new tFakulteOperations().list().SingleOrDefault((x) => x.fakulteAd == box_fakulte.Text);

            if (ad.Length < 1)
            {
                MessageBox.Show("Ad alanı boş olamaz!");
                return;
            }
            else if (fakulte == null)
            {
                MessageBox.Show("Fakülte alanı boş olamaz!");
                return;
            }

            tBolum bolum = new tBolum
            {
                bolumID = Guid.NewGuid().ToString(),
                bolumAd = ad,
                fakulteID = fakulte.fakulteID,
                fakulte = fakulte,
            };

            new tBolumOperations().create(bolum);

            MessageBox.Show("Bölüm eklendi!");
            BolumGridView.DataSource = new tBolumOperations().list().Select(x => new
            {
                Ad = x.bolumAd,
                Fakülte = x.fakulte.fakulteAd,
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            btn_ekle.Enabled = txt_id.Text.Trim().Length < 1;
            btn_sil.Enabled = btn_guncelle.Enabled = txt_id.Text.Trim().Length > 0;
        }

        private void BolumCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string ad = txt_ad.Text.Trim();

            tFakulte fakulte = new tFakulteOperations().list().SingleOrDefault((x) => x.fakulteAd == box_fakulte.Text);

            if (ad.Length < 1)
            {
                MessageBox.Show("Ad alanı boş olamaz!");
                return;
            }
            else if (fakulte == null)
            {
                MessageBox.Show("Fakülte alanı boş olamaz!");
                return;
            }

            tBolum bolum = new tBolum
            {
                bolumID = id,
                bolumAd = ad,
                fakulteID = fakulte.fakulteID,
                fakulte = fakulte,
            };

            new tBolumOperations().update(bolum);

            MessageBox.Show("Bölüm güncellendi!");
            BolumGridView.DataSource = new tBolumOperations().list().Select(x => new
            {
                Ad = x.bolumAd,
                Fakülte = x.fakulte.fakulteAd,
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;

            new tBolumOperations().delete(id);

            MessageBox.Show("Bölüm silindi!");
            BolumGridView.DataSource = new tBolumOperations().list().Select(x => new
            {
                Ad = x.bolumAd,
                Fakülte = x.fakulte.fakulteAd,
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
        }

        private void BolumGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string ad = e.Row.Cells[0].Value.ToString();
            string fakulte = e.Row.Cells[1].Value.ToString();

            tBolum bolum = new tBolumOperations().list().SingleOrDefault((x) => x.bolumAd == ad && x.fakulte.fakulteAd == fakulte);
            if (bolum == null) return;

            txt_id.Text = bolum.bolumID;
            txt_ad.Text = bolum.bolumAd;
        }
    }
}
