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
    public partial class OgrenciCRUD : Form
    {
        public OgrenciCRUD()
        {
            InitializeComponent();
        }

        private void OgrenciCRUD_Load(object sender, EventArgs e)
        {
            OgrenciGridView.DataSource = new tOgrenciOperations().list().Select(x => new
            {
                Ad = x.ad, Soyad = x.soyad, Bölüm = x.bolum.bolumAd
            }).ToList();

            foreach (var item in new tBolumOperations().list())
            {
                box_bolum.Items.Add(item.bolumAd);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();
            string soyad = txt_soyad.Text.Trim();

            tBolum bolum = new tBolumOperations().list().SingleOrDefault((x) => x.bolumAd == box_bolum.Text);

            if(ad.Length < 1)
            {
                MessageBox.Show("Ad alanı boş olamaz!");
                return;
            } else if (soyad.Length < 1)
            {
                MessageBox.Show("Soyad alanı boş olamaz!");
                return;
            } else if (bolum == null)
            {
                MessageBox.Show("Bölüm alanı boş olamaz!");
                return;
            }

            tOgrenci ogrenci = new tOgrenci
            {
                ogrenciID = Guid.NewGuid().ToString(),
                ad = ad,
                soyad = soyad,
                bolum = bolum
            };

            new tOgrenciOperations().create(ogrenci);

            MessageBox.Show("Öğrenci eklendi!");
            OgrenciGridView.DataSource = new tOgrenciOperations().list().Select(x => new
            {
                Ad = x.ad,
                Soyad = x.soyad,
                Bölüm = x.bolum.bolumAd
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string ad = txt_ad.Text.Trim();
            string soyad = txt_soyad.Text.Trim();

            tBolum bolum = new tBolumOperations().list().SingleOrDefault((x) => x.bolumAd == box_bolum.Text);

            if (ad.Length < 1)
            {
                MessageBox.Show("Ad alanı boş olamaz!");
                return;
            }
            else if (soyad.Length < 1)
            {
                MessageBox.Show("Soyad alanı boş olamaz!");
                return;
            }
            else if (bolum == null)
            {
                MessageBox.Show("Bölüm alanı boş olamaz!");
                return;
            }

            tOgrenci ogrenci = new tOgrenci
            {
                ogrenciID = id,
                ad = ad,
                soyad = soyad,
                bolumID = bolum.bolumID,
                bolum = bolum
            };

            new tOgrenciOperations().update(ogrenci);

            MessageBox.Show("Öğrenci güncellendi!");
            OgrenciGridView.DataSource = new tOgrenciOperations().list().Select(x => new
            {
                Ad = x.ad,
                Soyad = x.soyad,
                Bölüm = x.bolum.bolumAd
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            btn_ekle.Enabled = txt_id.Text.Trim().Length < 1;
            btn_sil.Enabled = btn_guncelle.Enabled = txt_id.Text.Trim().Length > 0;
        }
        private void OgrenciCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string ad = e.Row.Cells[0].Value.ToString();
            string soyad = e.Row.Cells[1].Value.ToString();
            string bolumAd = e.Row.Cells[2].Value.ToString();

            tOgrenci ogrenci = new tOgrenciOperations().list().SingleOrDefault((x) => x.ad == ad && x.soyad == soyad && x.bolum.bolumAd == bolumAd);
            if (ogrenci == null) return;

            txt_id.Text = ogrenci.ogrenciID;
            txt_ad.Text = ogrenci.ad;
            txt_soyad.Text = ogrenci.soyad;
            box_bolum.Text = ogrenci.bolum.bolumAd;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;

            new tOgrenciOperations().delete(id);

            MessageBox.Show("Öğrenci silindi!");
            OgrenciGridView.DataSource = new tOgrenciOperations().list().Select(x => new
            {
                Ad = x.ad,
                Soyad = x.soyad,
                Bölüm = x.bolum.bolumAd
            }).ToList();

            txt_id.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
