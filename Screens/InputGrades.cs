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
    public partial class InputGrades : Form
    {
        public InputGrades()
        {
            InitializeComponent();
        }

        private void InputGrades_Load(object sender, EventArgs e)
        {
            foreach (var item in new tDersOperations().list())
            {
                box_ders_ad.Items.Add(item.dersAd);
            }
        }

        private void InputGrades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void box_ders_ad_TextChanged(object sender, EventArgs e)
        {
            string dersAd = box_ders_ad.Text.Trim();
            if (dersAd != null && dersAd.Length > 0)
            {
                var data = new tOgrenciDersOperations().list();
                NotlarGridView.DataSource = data.FindAll(x => x.ders.dersAd == dersAd).Select(x => new
                {
                    ID = x.ogrenciDersID,
                    Öğrenci = x.ogrenci.ad + " " + x.ogrenci.soyad,
                    Ders = x.ders.dersAd,
                    Vize = x.vize,
                    Final = x.final,
                }).ToList();
            }                
        }

        private void NotlarGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            string id = e.Row.Cells[0].Value.ToString();
            string vize = e.Row.Cells[3].Value.ToString();
            string final = e.Row.Cells[4].Value.ToString();

            txt_id.Text = id;
            txt_vize.Text = vize;
            txt_final.Text = final;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            if (id.Length < 1) return;

            string vize = txt_vize.Text.Trim();
            string final = txt_final.Text.Trim();

            tOgrenciDers ogrenciDers = new tOgrenciDersOperations().read(id);
            tOgrenciDers temp = null;

            if(vize.Length < 1 && final.Length < 1)
            {
                MessageBox.Show("Vize veya Final alanını doldurun!");
                return;
            } else if (vize.Length > 0 && final.Length < 1)
            {
                temp = new tOgrenciDers
                {
                    ogrenciDersID = id,
                    ogrenciID = ogrenciDers.ogrenciID,
                    dersID = ogrenciDers.dersID,
                    yil = ogrenciDers.yil,
                    yariyil = ogrenciDers.yariyil,
                    vize = Convert.ToDouble(vize),
                    final = ogrenciDers.final,
                };
            } else if (vize.Length < 1 && final.Length > 0)
            {
                temp = new tOgrenciDers
                {
                    ogrenciDersID = id,
                    ogrenciID = ogrenciDers.ogrenciID,
                    dersID = ogrenciDers.dersID,
                    yil = ogrenciDers.yil,
                    yariyil = ogrenciDers.yariyil,
                    vize = ogrenciDers.vize,
                    final = Convert.ToDouble(final),               
                };
            } else if (vize.Length > 0 && final.Length > 0)
            {
                temp = new tOgrenciDers
                {
                    ogrenciDersID = id,
                    ogrenciID = ogrenciDers.ogrenciID,
                    dersID = ogrenciDers.dersID,
                    yil = ogrenciDers.yil,
                    yariyil = ogrenciDers.yariyil,
                    vize = Convert.ToDouble(vize),
                    final = Convert.ToDouble(final),
                };
            } else if (temp == null) { return;  }

            new tOgrenciDersOperations().update(temp);
            MessageBox.Show("Not Güncellemesi Yapıldı!");

            string dersAd = box_ders_ad.Text.Trim();
            if (dersAd != null && dersAd.Length > 0)
            {
                var data = new tOgrenciDersOperations().list();
                NotlarGridView.DataSource = data.FindAll(x => x.ders.dersAd == dersAd).Select(x => new
                {
                    ID = x.ogrenciDersID,
                    Öğrenci = x.ogrenci.ad + " " + x.ogrenci.soyad,
                    Ders = x.ders.dersAd,
                    Vize = x.vize,
                    Final = x.final,
                }).ToList();
            }

            txt_id.Clear();
            txt_vize.Clear();
            txt_final.Clear();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            btn_guncelle.Enabled = txt_id.Text.Length > 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
