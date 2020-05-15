namespace Kyou_Hobby_shop
{
    partial class Jastip
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
            this.labelBaju = new System.Windows.Forms.Label();
            this.labelNoTrans = new System.Windows.Forms.Label();
            this.groupBoxDataBaju = new System.Windows.Forms.GroupBox();
            this.textTotalBayar = new System.Windows.Forms.TextBox();
            this.textJumlahBeli = new System.Windows.Forms.TextBox();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.radioUkuranL = new System.Windows.Forms.RadioButton();
            this.radioUkuranM = new System.Windows.Forms.RadioButton();
            this.radioUkuranS = new System.Windows.Forms.RadioButton();
            this.comboMerkBaju = new System.Windows.Forms.ComboBox();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.labelJumlahBeli = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelUkuranBaju = new System.Windows.Forms.Label();
            this.labelMerkBaju = new System.Windows.Forms.Label();
            this.labelUangBayar = new System.Windows.Forms.Label();
            this.labelUangKembali = new System.Windows.Forms.Label();
            this.textNoTrans = new System.Windows.Forms.TextBox();
            this.textUangBayar = new System.Windows.Forms.TextBox();
            this.textUangKembali = new System.Windows.Forms.TextBox();
            this.buttonBersih = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxDataBaju.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBaju
            // 
            this.labelBaju.AutoSize = true;
            this.labelBaju.BackColor = System.Drawing.Color.OrangeRed;
            this.labelBaju.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaju.ForeColor = System.Drawing.Color.White;
            this.labelBaju.Location = new System.Drawing.Point(82, 85);
            this.labelBaju.Name = "labelBaju";
            this.labelBaju.Size = new System.Drawing.Size(132, 17);
            this.labelBaju.TabIndex = 1;
            this.labelBaju.Text = "Isi Form Pembelian";
            this.labelBaju.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaju.Click += new System.EventHandler(this.labelBaju_Click);
            // 
            // labelNoTrans
            // 
            this.labelNoTrans.AutoSize = true;
            this.labelNoTrans.ForeColor = System.Drawing.Color.White;
            this.labelNoTrans.Location = new System.Drawing.Point(27, 47);
            this.labelNoTrans.Name = "labelNoTrans";
            this.labelNoTrans.Size = new System.Drawing.Size(35, 13);
            this.labelNoTrans.TabIndex = 2;
            this.labelNoTrans.Text = "Nama";
            this.labelNoTrans.Click += new System.EventHandler(this.labelNoTrans_Click);
            // 
            // groupBoxDataBaju
            // 
            this.groupBoxDataBaju.Controls.Add(this.textJumlahBeli);
            this.groupBoxDataBaju.Controls.Add(this.textHarga);
            this.groupBoxDataBaju.Controls.Add(this.radioUkuranL);
            this.groupBoxDataBaju.Controls.Add(this.radioUkuranM);
            this.groupBoxDataBaju.Controls.Add(this.radioUkuranS);
            this.groupBoxDataBaju.Controls.Add(this.comboMerkBaju);
            this.groupBoxDataBaju.Controls.Add(this.labelJumlahBeli);
            this.groupBoxDataBaju.Controls.Add(this.labelHarga);
            this.groupBoxDataBaju.Controls.Add(this.labelUkuranBaju);
            this.groupBoxDataBaju.Controls.Add(this.labelMerkBaju);
            this.groupBoxDataBaju.ForeColor = System.Drawing.Color.White;
            this.groupBoxDataBaju.Location = new System.Drawing.Point(24, 72);
            this.groupBoxDataBaju.Name = "groupBoxDataBaju";
            this.groupBoxDataBaju.Size = new System.Drawing.Size(260, 121);
            this.groupBoxDataBaju.TabIndex = 3;
            this.groupBoxDataBaju.TabStop = false;
            this.groupBoxDataBaju.Text = "Data Produk";
            this.groupBoxDataBaju.Enter += new System.EventHandler(this.groupBoxDataBaju_Enter);
            // 
            // textTotalBayar
            // 
            this.textTotalBayar.Location = new System.Drawing.Point(140, 202);
            this.textTotalBayar.Name = "textTotalBayar";
            this.textTotalBayar.Size = new System.Drawing.Size(130, 20);
            this.textTotalBayar.TabIndex = 11;
            this.textTotalBayar.TextChanged += new System.EventHandler(this.textTotalBayar_TextChanged);
            // 
            // textJumlahBeli
            // 
            this.textJumlahBeli.Location = new System.Drawing.Point(120, 92);
            this.textJumlahBeli.Name = "textJumlahBeli";
            this.textJumlahBeli.Size = new System.Drawing.Size(130, 20);
            this.textJumlahBeli.TabIndex = 10;
            this.textJumlahBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textJumlahBeli_KeyPress);
            // 
            // textHarga
            // 
            this.textHarga.Location = new System.Drawing.Point(120, 68);
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(130, 20);
            this.textHarga.TabIndex = 9;
            // 
            // radioUkuranL
            // 
            this.radioUkuranL.AutoSize = true;
            this.radioUkuranL.Location = new System.Drawing.Point(224, 44);
            this.radioUkuranL.Name = "radioUkuranL";
            this.radioUkuranL.Size = new System.Drawing.Size(31, 17);
            this.radioUkuranL.TabIndex = 8;
            this.radioUkuranL.TabStop = true;
            this.radioUkuranL.Text = "L";
            this.radioUkuranL.UseVisualStyleBackColor = true;
            this.radioUkuranL.Click += new System.EventHandler(this.comboMerkBaju_SelectedIndexChanged);
            // 
            // radioUkuranM
            // 
            this.radioUkuranM.AutoSize = true;
            this.radioUkuranM.Location = new System.Drawing.Point(175, 44);
            this.radioUkuranM.Name = "radioUkuranM";
            this.radioUkuranM.Size = new System.Drawing.Size(34, 17);
            this.radioUkuranM.TabIndex = 7;
            this.radioUkuranM.TabStop = true;
            this.radioUkuranM.Text = "M";
            this.radioUkuranM.UseVisualStyleBackColor = true;
            this.radioUkuranM.Click += new System.EventHandler(this.comboMerkBaju_SelectedIndexChanged);
            // 
            // radioUkuranS
            // 
            this.radioUkuranS.AutoSize = true;
            this.radioUkuranS.Location = new System.Drawing.Point(120, 44);
            this.radioUkuranS.Name = "radioUkuranS";
            this.radioUkuranS.Size = new System.Drawing.Size(32, 17);
            this.radioUkuranS.TabIndex = 6;
            this.radioUkuranS.TabStop = true;
            this.radioUkuranS.Text = "S";
            this.radioUkuranS.UseVisualStyleBackColor = true;
            this.radioUkuranS.CheckedChanged += new System.EventHandler(this.radioUkuranS_CheckedChanged);
            this.radioUkuranS.Click += new System.EventHandler(this.comboMerkBaju_SelectedIndexChanged);
            // 
            // comboMerkBaju
            // 
            this.comboMerkBaju.FormattingEnabled = true;
            this.comboMerkBaju.Items.AddRange(new object[] {
            "Kimono",
            "Yukata",
            "Hakama",
            "Jinbei",
            "Haori",
            "Uchikake",
            "Kurotomesode",
            "Irotomesode",
            "Komon"});
            this.comboMerkBaju.Location = new System.Drawing.Point(120, 20);
            this.comboMerkBaju.Name = "comboMerkBaju";
            this.comboMerkBaju.Size = new System.Drawing.Size(130, 21);
            this.comboMerkBaju.TabIndex = 5;
            this.comboMerkBaju.SelectedIndexChanged += new System.EventHandler(this.comboMerkBaju_SelectedIndexChanged);
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.ForeColor = System.Drawing.Color.White;
            this.labelTotalBayar.Location = new System.Drawing.Point(29, 205);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(61, 13);
            this.labelTotalBayar.TabIndex = 4;
            this.labelTotalBayar.Text = "Total Bayar";
            this.labelTotalBayar.Click += new System.EventHandler(this.labelTotalBayar_Click);
            // 
            // labelJumlahBeli
            // 
            this.labelJumlahBeli.AutoSize = true;
            this.labelJumlahBeli.ForeColor = System.Drawing.Color.White;
            this.labelJumlahBeli.Location = new System.Drawing.Point(7, 96);
            this.labelJumlahBeli.Name = "labelJumlahBeli";
            this.labelJumlahBeli.Size = new System.Drawing.Size(60, 13);
            this.labelJumlahBeli.TabIndex = 3;
            this.labelJumlahBeli.Text = "Jumlah Beli";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.ForeColor = System.Drawing.Color.White;
            this.labelHarga.Location = new System.Drawing.Point(7, 72);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(36, 13);
            this.labelHarga.TabIndex = 2;
            this.labelHarga.Text = "Harga";
            // 
            // labelUkuranBaju
            // 
            this.labelUkuranBaju.AutoSize = true;
            this.labelUkuranBaju.ForeColor = System.Drawing.Color.White;
            this.labelUkuranBaju.Location = new System.Drawing.Point(7, 48);
            this.labelUkuranBaju.Name = "labelUkuranBaju";
            this.labelUkuranBaju.Size = new System.Drawing.Size(84, 13);
            this.labelUkuranBaju.TabIndex = 1;
            this.labelUkuranBaju.Text = "Ukuran Pakaian";
            // 
            // labelMerkBaju
            // 
            this.labelMerkBaju.AutoSize = true;
            this.labelMerkBaju.ForeColor = System.Drawing.Color.White;
            this.labelMerkBaju.Location = new System.Drawing.Point(7, 24);
            this.labelMerkBaju.Name = "labelMerkBaju";
            this.labelMerkBaju.Size = new System.Drawing.Size(73, 13);
            this.labelMerkBaju.TabIndex = 0;
            this.labelMerkBaju.Text = "Jenis Pakaian";
            this.labelMerkBaju.Click += new System.EventHandler(this.labelMerkBaju_Click);
            // 
            // labelUangBayar
            // 
            this.labelUangBayar.AutoSize = true;
            this.labelUangBayar.ForeColor = System.Drawing.Color.White;
            this.labelUangBayar.Location = new System.Drawing.Point(29, 236);
            this.labelUangBayar.Name = "labelUangBayar";
            this.labelUangBayar.Size = new System.Drawing.Size(63, 13);
            this.labelUangBayar.TabIndex = 4;
            this.labelUangBayar.Text = "Uang Bayar";
            // 
            // labelUangKembali
            // 
            this.labelUangKembali.AutoSize = true;
            this.labelUangKembali.ForeColor = System.Drawing.Color.White;
            this.labelUangKembali.Location = new System.Drawing.Point(29, 268);
            this.labelUangKembali.Name = "labelUangKembali";
            this.labelUangKembali.Size = new System.Drawing.Size(73, 13);
            this.labelUangKembali.TabIndex = 5;
            this.labelUangKembali.Text = "Uang Kembali";
            // 
            // textNoTrans
            // 
            this.textNoTrans.Location = new System.Drawing.Point(140, 46);
            this.textNoTrans.Name = "textNoTrans";
            this.textNoTrans.Size = new System.Drawing.Size(130, 20);
            this.textNoTrans.TabIndex = 6;
            this.textNoTrans.TextChanged += new System.EventHandler(this.textNoTrans_TextChanged);
            // 
            // textUangBayar
            // 
            this.textUangBayar.Location = new System.Drawing.Point(140, 233);
            this.textUangBayar.Name = "textUangBayar";
            this.textUangBayar.Size = new System.Drawing.Size(130, 20);
            this.textUangBayar.TabIndex = 7;
            this.textUangBayar.TextChanged += new System.EventHandler(this.textUangBayar_TextChanged);
            this.textUangBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUangBayar_KeyPress);
            // 
            // textUangKembali
            // 
            this.textUangKembali.Location = new System.Drawing.Point(140, 265);
            this.textUangKembali.Name = "textUangKembali";
            this.textUangKembali.Size = new System.Drawing.Size(130, 20);
            this.textUangKembali.TabIndex = 8;
            this.textUangKembali.TextChanged += new System.EventHandler(this.textUangKembali_TextChanged);
            // 
            // buttonBersih
            // 
            this.buttonBersih.Location = new System.Drawing.Point(32, 316);
            this.buttonBersih.Name = "buttonBersih";
            this.buttonBersih.Size = new System.Drawing.Size(90, 25);
            this.buttonBersih.TabIndex = 9;
            this.buttonBersih.Text = "Clear";
            this.buttonBersih.UseVisualStyleBackColor = true;
            this.buttonBersih.Click += new System.EventHandler(this.buttonBersih_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(180, 316);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(90, 25);
            this.buttonTutup.TabIndex = 10;
            this.buttonTutup.Text = "Submit";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BAJU_MURAH_MERIAH.Properties.Resources.kyou;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(379, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 88);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BAJU_MURAH_MERIAH.Properties.Resources.mascot;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(309, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 160);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.labelBaju);
            this.panel1.Location = new System.Drawing.Point(0, -75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 114);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.textTotalBayar);
            this.panel2.Controls.Add(this.buttonTutup);
            this.panel2.Controls.Add(this.buttonBersih);
            this.panel2.Controls.Add(this.textUangKembali);
            this.panel2.Controls.Add(this.textUangBayar);
            this.panel2.Controls.Add(this.labelTotalBayar);
            this.panel2.Controls.Add(this.textNoTrans);
            this.panel2.Controls.Add(this.labelUangKembali);
            this.panel2.Controls.Add(this.labelUangBayar);
            this.panel2.Controls.Add(this.groupBoxDataBaju);
            this.panel2.Controls.Add(this.labelNoTrans);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 468);
            this.panel2.TabIndex = 14;
            // 
            // Jastip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Jastip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JASTIP HOBBY";
            this.Load += new System.EventHandler(this.Baju_Load);
            this.groupBoxDataBaju.ResumeLayout(false);
            this.groupBoxDataBaju.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBaju;
        private System.Windows.Forms.Label labelNoTrans;
        private System.Windows.Forms.GroupBox groupBoxDataBaju;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.Label labelJumlahBeli;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelUkuranBaju;
        private System.Windows.Forms.Label labelMerkBaju;
        private System.Windows.Forms.TextBox textTotalBayar;
        private System.Windows.Forms.TextBox textJumlahBeli;
        private System.Windows.Forms.TextBox textHarga;
        private System.Windows.Forms.RadioButton radioUkuranL;
        private System.Windows.Forms.RadioButton radioUkuranM;
        private System.Windows.Forms.RadioButton radioUkuranS;
        private System.Windows.Forms.ComboBox comboMerkBaju;
        private System.Windows.Forms.Label labelUangBayar;
        private System.Windows.Forms.Label labelUangKembali;
        private System.Windows.Forms.TextBox textNoTrans;
        private System.Windows.Forms.TextBox textUangBayar;
        private System.Windows.Forms.TextBox textUangKembali;
        private System.Windows.Forms.Button buttonBersih;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

