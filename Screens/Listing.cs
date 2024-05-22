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
    public partial class Listing : Form
    {
        tOgrenci storage_ogrenci;
        string storage_yil;
        string storage_yariyil;

        public Listing()
        {
            InitializeComponent();
        }

        private void Listing_Load(object sender, EventArgs e)
        {
            foreach (var item in new tOgrenciOperations().list())
            {
                box_ogrenci.Items.Add(item.ogrenciID + " " + item.ad + " " + item.soyad);
            }
        }

        private void box_yil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yil = box_yil.Text.Trim();
            if(yil != null && yil.Length > 0)
            {
                storage_yil = yil;
            }

            if(storage_yariyil != null)
            {
                var data = new tOgrenciDersOperations().list();

                dataGridView2.DataSource = data.FindAll(x => x.yil == storage_yil && x.yariyil == storage_yariyil)
                    .GroupBy(x => x.dersID)
                    .Select(x => new {
                        Yıl = storage_yil,
                        Yarıyıl = storage_yariyil,
                        Ders = x.First().ders.dersAd,
                        Katılımcı_Sayısı = x.Count(),
                    })
                    .ToList();
            }
        }

        private void box_yariyil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yariyil = box_yariyil.Text.Trim();
            if (yariyil != null && yariyil.Length > 0)
            {
                storage_yariyil = yariyil;
            }

            if (storage_yil != null)
            {
                var data = new tOgrenciDersOperations().list();

                dataGridView2.DataSource = data.FindAll(x => x.yil == storage_yil && x.yariyil == storage_yariyil)
                    .GroupBy(x => x.dersID)
                    .Select(x => new {
                        Yıl = storage_yil,
                        Yarıyıl = storage_yariyil,
                        Ders = x.First().ders.dersAd,
                        Katılımcı_Sayısı = x.Count(),
                    })
                    .ToList();
            }
        }

        private void Listing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void box_ogrenci_TextChanged(object sender, EventArgs e)
        {
            string ogrenciMetinsel = box_ogrenci.Text.Trim();
            if (ogrenciMetinsel != null && ogrenciMetinsel.Length > 0)
            {
                List<string> parts = ogrenciMetinsel.Split(' ').Select(x => x.Trim()).ToList();
                string id = parts.First();

                tOgrenci ogrenci = new tOgrenciOperations().read(id);
                if (ogrenci == null) return;

                storage_ogrenci = ogrenci;

                var data = new tOgrenciDersOperations().list();

                dataGridView1.DataSource = data.FindAll(x => x.ogrenciID == storage_ogrenci.ogrenciID).Select(x => new
                {
                    ID = x.ders.dersID,
                    Ders = x.ders.dersAd,
                }).ToList();
            }
        }
    }
}
