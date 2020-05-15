using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyou_Hobby_shop
{
    public partial class Jastip : Form
    {
        int harga;
        int ongkir;

        public Jastip()
        {
            InitializeComponent();
        }

        private void Baju_Load(object sender, EventArgs e)
        {
            textNoTrans.Select();
        }

        private void comboMerkBaju_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            textHarga.Focus();

            if (comboMerkBaju.Text == "Kimono")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 450000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 470000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 490000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                } 
            }

            else if (comboMerkBaju.Text == "Yukata")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 185000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 195000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 205000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                } 
            }

            else if (comboMerkBaju.Text == "Hakama")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 220000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 225000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 230000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                } 
            }
            else if (comboMerkBaju.Text == "Jinbei")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 125000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 135000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 145000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
            }
            else if (comboMerkBaju.Text == "Haori")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 215000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 225000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 235000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
            }
            else if (comboMerkBaju.Text == "Uchikake")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 1550000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 1750000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 1950000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
            }
            else if (comboMerkBaju.Text == "Kurotomesode")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 892000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 995000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 1189000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
            }
            else if (comboMerkBaju.Text == "Irotomesode")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 1177000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 1457000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 1697000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
            }
            else if (comboMerkBaju.Text == "Komon")
            {
                if (radioUkuranS.Checked)
                {
                    harga = 450000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranM.Checked)
                {
                    harga = 470000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
                else if (radioUkuranL.Checked)
                {
                    harga = 490000;
                    textHarga.Text = harga.ToString();
                    textJumlahBeli.Focus();
                }
            }
        }

        private void textJumlahBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keychar = e.KeyChar;
            if (keychar == 13)
            {
                textTotalBayar.Text = Convert.ToString(Convert.ToDouble(textHarga.Text) * Convert.ToDouble(textJumlahBeli.Text));
                textUangBayar.Focus();
            }
        }

        private void textUangBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            double kembali;
            string bayar, total;

            bayar = textUangBayar.Text;
            total = textTotalBayar.Text;

            char keychar = e.KeyChar;
            if (keychar == 13)
            {
                if (Convert.ToDouble(bayar) < Convert.ToDouble(total))
                {
                    MessageBox.Show("Uangnya Kurang !", "Kesalahan", MessageBoxButtons.OK);
                    textUangBayar.Clear();
                }
                else if (Convert.ToDouble(bayar) >= Convert.ToDouble(total))
                {
                    kembali = Convert.ToDouble(bayar) - Convert.ToDouble(total);
                    textUangKembali.Text = kembali.ToString();
                    buttonTutup.Focus();
                }
            }
        }

        private void buttonBersih_Click(object sender, EventArgs e)
        {
            textNoTrans.Clear();
            textHarga.Clear();
            textJumlahBeli.Clear();
            textTotalBayar.Clear();
            textUangBayar.Clear();
            textUangKembali.Clear();
            textNoTrans.Focus();
            comboMerkBaju.ResetText();
            radioUkuranS.Checked = false;
            radioUkuranM.Checked = false;
            radioUkuranL.Checked = false;
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Terima kasih telah berbelanja di Kyou Hobby shop, ingin berbelanja lagi?", "Tanya", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                this.Close();
            }
        }

        private void labelMerkBaju_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxDataBaju_Enter(object sender, EventArgs e)
        {

        }

        private void radioUkuranS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textNoTrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNoTrans_Click(object sender, EventArgs e)
        {

        }

        private void labelBaju_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textUangBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUangKembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTotalBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTotalBayar_Click(object sender, EventArgs e)
        {

        }
    }
}
