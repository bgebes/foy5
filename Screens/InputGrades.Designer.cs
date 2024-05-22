namespace Foy5.Screens
{
    partial class InputGrades
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
            this.NotlarGridView = new System.Windows.Forms.DataGridView();
            this.box_ders_ad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vize = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotlarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NotlarGridView
            // 
            this.NotlarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotlarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotlarGridView.Location = new System.Drawing.Point(354, 12);
            this.NotlarGridView.Name = "NotlarGridView";
            this.NotlarGridView.Size = new System.Drawing.Size(739, 222);
            this.NotlarGridView.TabIndex = 0;
            this.NotlarGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.NotlarGridView_RowStateChanged);
            // 
            // box_ders_ad
            // 
            this.box_ders_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box_ders_ad.FormattingEnabled = true;
            this.box_ders_ad.Location = new System.Drawing.Point(108, 19);
            this.box_ders_ad.Name = "box_ders_ad";
            this.box_ders_ad.Size = new System.Drawing.Size(230, 28);
            this.box_ders_ad.TabIndex = 1;
            this.box_ders_ad.TextChanged += new System.EventHandler(this.box_ders_ad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vize Notu: ";
            // 
            // txt_vize
            // 
            this.txt_vize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vize.Location = new System.Drawing.Point(108, 135);
            this.txt_vize.Name = "txt_vize";
            this.txt_vize.Size = new System.Drawing.Size(230, 26);
            this.txt_vize.TabIndex = 4;
            // 
            // txt_final
            // 
            this.txt_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_final.Location = new System.Drawing.Point(108, 167);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(230, 26);
            this.txt_final.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Final Notu: ";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Enabled = false;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(108, 199);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(230, 35);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Notları Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(108, 103);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(230, 26);
            this.txt_id.TabIndex = 9;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID: ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 56);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 37);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // InputGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 246);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_vize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_ders_ad);
            this.Controls.Add(this.NotlarGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InputGrades";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vize/Final Notlarının Girilmesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputGrades_FormClosing);
            this.Load += new System.EventHandler(this.InputGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotlarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NotlarGridView;
        private System.Windows.Forms.ComboBox box_ders_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vize;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
    }
}