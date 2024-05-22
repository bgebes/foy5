namespace Foy5.Screens
{
    partial class BindDers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_yil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_yariyil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OgrenciGridView = new System.Windows.Forms.DataGridView();
            this.DersGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DersKayıtlarıGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.txt_ders_ad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DersKayıtlarıGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // box_yil
            // 
            this.box_yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box_yil.FormattingEnabled = true;
            this.box_yil.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.box_yil.Location = new System.Drawing.Point(74, 9);
            this.box_yil.Name = "box_yil";
            this.box_yil.Size = new System.Drawing.Size(167, 33);
            this.box_yil.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yıl: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(277, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yarıyıl: ";
            // 
            // box_yariyil
            // 
            this.box_yariyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box_yariyil.FormattingEnabled = true;
            this.box_yariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.box_yariyil.Location = new System.Drawing.Point(368, 9);
            this.box_yariyil.Name = "box_yariyil";
            this.box_yariyil.Size = new System.Drawing.Size(212, 33);
            this.box_yariyil.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenciler";
            // 
            // OgrenciGridView
            // 
            this.OgrenciGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OgrenciGridView.Location = new System.Drawing.Point(620, 25);
            this.OgrenciGridView.Name = "OgrenciGridView";
            this.OgrenciGridView.Size = new System.Drawing.Size(474, 188);
            this.OgrenciGridView.TabIndex = 5;
            this.OgrenciGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.OgrenciGridView_RowStateChanged);
            // 
            // DersGridView
            // 
            this.DersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DersGridView.Location = new System.Drawing.Point(620, 232);
            this.DersGridView.Name = "DersGridView";
            this.DersGridView.Size = new System.Drawing.Size(474, 206);
            this.DersGridView.TabIndex = 7;
            this.DersGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DersGridView_RowStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dersler";
            // 
            // DersKayıtlarıGridView
            // 
            this.DersKayıtlarıGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DersKayıtlarıGridView.Location = new System.Drawing.Point(12, 250);
            this.DersKayıtlarıGridView.Name = "DersKayıtlarıGridView";
            this.DersKayıtlarıGridView.Size = new System.Drawing.Size(602, 188);
            this.DersKayıtlarıGridView.TabIndex = 9;
            this.DersKayıtlarıGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DersKayıtlarıGridView_RowStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ders Kayıtları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci: ";
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(134, 103);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.ReadOnly = true;
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(469, 29);
            this.txt_ogrenci_ad.TabIndex = 11;
            // 
            // txt_ders_ad
            // 
            this.txt_ders_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ders_ad.Location = new System.Drawing.Point(134, 141);
            this.txt_ders_ad.Name = "txt_ders_ad";
            this.txt_ders_ad.ReadOnly = true;
            this.txt_ders_ad.Size = new System.Drawing.Size(469, 29);
            this.txt_ders_ad.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ders: ";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(249, 190);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(114, 39);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(134, 65);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(469, 29);
            this.txt_id.TabIndex = 16;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kayıt ID: ";
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(369, 190);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(114, 39);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_degistir
            // 
            this.btn_degistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_degistir.Location = new System.Drawing.Point(489, 190);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(114, 39);
            this.btn_degistir.TabIndex = 18;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(127, 190);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(114, 39);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // BindDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_ders_ad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ogrenci_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DersKayıtlarıGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DersGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OgrenciGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_yariyil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_yil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BindDers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenciye Ders Atama/Silme/Değiştirme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BindDers_FormClosing);
            this.Load += new System.EventHandler(this.BindDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DersKayıtlarıGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box_yil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_yariyil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OgrenciGridView;
        private System.Windows.Forms.DataGridView DersGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DersKayıtlarıGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ogrenci_ad;
        private System.Windows.Forms.TextBox txt_ders_ad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.Button btn_back;
    }
}