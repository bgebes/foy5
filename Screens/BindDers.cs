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
    public partial class BindDers : Form
    {
        private tOgrenci storage_ogrenci;
        private tDers storage_ders;

        public BindDers()
        {
            InitializeComponent();
        }

        private void BindDers_Load(object sender, EventArgs e)
        {
            OgrenciGridView.DataSource = new tOgrenciOperations().list().Select(x => new
            {
                Ad = x.ad,
                Soyad = x.soyad,
                Bölüm = x.bolum.bolumAd
            }).ToList();

            DersGridView.DataSource = new tDersOperations().list().Select(x => new
            {
                ID = x.dersID,
                Ad = x.dersAd
            }).ToList();

            DersKayıtlarıGridView.DataSource = new tOgrenciDersOperations().list().Select(x => new
            {
                ID = x.ogrenciDersID,
                Öğrenci = x.ogrenci.ad + " " + x.ogrenci.soyad,
                Ders = x.ders.dersAd,
                Yıl = x.yil,
                Yarıyıl = x.yariyil,
            }).ToList();
        }

        private void OgrenciGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string ad = e.Row.Cells[0].Value.ToString();
            string soyad = e.Row.Cells[1].Value.ToString();
            string bolumAd = e.Row.Cells[2].Value.ToString();

            tOgrenci ogrenci = new tOgrenciOperations().list().SingleOrDefault((x) => x.ad == ad && x.soyad == soyad && x.bolum.bolumAd == bolumAd);
            if (ogrenci == null) return;

            storage_ogrenci = ogrenci;
            txt_ogrenci_ad.Text = ogrenci.ad + " " + ogrenci.soyad + " - " + ogrenci.bolum.bolumAd;
        }

        private void DersGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string id = e.Row.Cells[0].Value.ToString();
            string ad = e.Row.Cells[1].Value.ToString();

            tDers ders = new tDersOperations().list().SingleOrDefault((x) => x.dersID == id);
            if (ders == null) return;

            storage_ders = ders;
            txt_ders_ad.Text = ders.dersAd;
        }

        private void DersKayıtlarıGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string id = e.Row.Cells[0].Value.ToString();
            tOgrenciDers ogrenciDers = new tOgrenciDersOperations().read(id);
            if (ogrenciDers == null) return;

            storage_ogrenci = ogrenciDers.ogrenci;
            storage_ders = ogrenciDers.ders;

            txt_id.Text = id;
            txt_ogrenci_ad.Text = ogrenciDers.ogrenci.ad + " " + ogrenciDers.ogrenci.soyad;
            txt_ders_ad.Text = ogrenciDers.ders.dersAd;
            box_yil.Text = ogrenciDers.yil;
            box_yariyil.Text = ogrenciDers.yariyil;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            btn_ekle.Enabled = txt_id.Text.Trim().Length < 1;
            btn_sil.Enabled = btn_degistir.Enabled = txt_id.Text.Trim().Length > 0;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ogrenci_ad_soyad = txt_ogrenci_ad.Text.Trim();
            string ders_ad = txt_ders_ad.Text.Trim();
            string yil = box_yil.Text.Trim();
            string yariyil = box_yariyil.Text.Trim();

            if (ogrenci_ad_soyad.Length < 1)
            {
                MessageBox.Show("Öğrenci alanı boş olamaz!");
                return;
            }
            else if (ders_ad.Length < 1)
            {
                MessageBox.Show("Ders alanı boş olamaz!");
                return;
            }
            else if (yil.Length < 1)
            {
                MessageBox.Show("Yıl alanı boş olamaz!");
                return;
            }
            else if (yariyil.Length < 1)
            {
                MessageBox.Show("Yarıyıl alanı boş olamaz!");
                return;
            }

            tOgrenciDers ogrenciDers = new tOgrenciDers
            {
                ogrenciDersID = Guid.NewGuid().ToString(),
                ogrenciID = storage_ogrenci.ogrenciID,
                ogrenci = storage_ogrenci,
                dersID = storage_ders.dersID,
                ders = storage_ders,
                yil = box_yil.Text,
                yariyil = box_yariyil.Text,
                vize = 0,
                final = 0,
            };

            new tOgrenciDersOperations().create(ogrenciDers);

            MessageBox.Show("Ders Kayıtı eklendi!");
            DersKayıtlarıGridView.DataSource = new tOgrenciDersOperations().list().Select(x => new
            {
                ID = x.ogrenciDersID,
                Öğrenci = x.ogrenci.ad + " " + x.ogrenci.soyad,
                Ders = x.ders.dersAd,
                Yıl = x.yil,
                Yarıyıl = x.yariyil,
            }).ToList();

            txt_id.Clear();
            txt_ogrenci_ad.Clear();
            txt_ders_ad.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;

            new tOgrenciDersOperations().delete(id);

            MessageBox.Show("Ders Kayıtı silindi!");
            DersKayıtlarıGridView.DataSource = new tOgrenciDersOperations().list().Select(x => new
            {
                ID = x.ogrenciDersID,
                Öğrenci = x.ogrenci.ad + " " + x.ogrenci.soyad,
                Ders = x.ders.dersAd,
                Yıl = x.yil,
                Yarıyıl = x.yariyil,
            }).ToList();

            txt_id.Clear();
            txt_ogrenci_ad.Clear();
            txt_ders_ad.Clear();
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string ogrenci_ad_soyad = txt_ogrenci_ad.Text.Trim();
            string ders_ad = txt_ders_ad.Text.Trim();
            string yil = box_yil.Text.Trim();
            string yariyil = box_yariyil.Text.Trim();

            if (ogrenci_ad_soyad.Length < 1)
            {
                MessageBox.Show("Öğrenci alanı boş olamaz!");
                return;
            }
            else if (ders_ad.Length < 1)
            {
                MessageBox.Show("Ders alanı boş olamaz!");
                return;
            }
            else if (yil.Length < 1)
            {
                MessageBox.Show("Yıl alanı boş olamaz!");
                return;
            }
            else if (yariyil.Length < 1)
            {
                MessageBox.Show("Yarıyıl alanı boş olamaz!");
                return;
            }

            tOgrenciDers ogrenciDers = new tOgrenciDers
            {
                ogrenciDersID = id,
                ogrenciID = storage_ogrenci.ogrenciID,
                ogrenci = storage_ogrenci,
                dersID = storage_ders.dersID,
                ders = storage_ders,
                yil = box_yil.Text,
                yariyil = box_yariyil.Text,
                vize = 0,
                final = 0,
            };

            new tOgrenciDersOperations().update(ogrenciDers);

            MessageBox.Show("Ders Kayıtı değiştirildi!");
            DersKayıtlarıGridView.DataSource = new tOgrenciDersOperations().list().Select(x => new
            {
                ID = x.ogrenciDersID,
                Öğrenci = x.ogrenci.ad + " " + x.ogrenci.soyad,
                Ders = x.ders.dersAd,
                Yıl = x.yil,
                Yarıyıl = x.yariyil,
            }).ToList();

            txt_id.Clear();
            txt_ogrenci_ad.Clear();
            txt_ders_ad.Clear();
        }

        private void BindDers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
