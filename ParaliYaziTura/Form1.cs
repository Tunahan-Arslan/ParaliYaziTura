using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaliYaziTura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bakiye = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtbakiye.Text = bakiye.ToString();
            MessageBox.Show("Hesabınıza 120 bakiye aktarıldı. Hedefiniz bakiyenizi 500 bakiyeye çıkartmak!");
            bakiye = 120;
            txtbakiye.Text = bakiye.ToString();

        }

        private void txtbakiye_TextChanged(object sender, EventArgs e)
        {
            txtbakiye.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Rastgele Sayı' butonuna tıklandığında 0-3(0 ve 3 dahil) arasında çıkan rakam, yatırılan bakiye ile çarpılır ve mevcut bakiyenize eklenir. Bakiyeniz 500 olduğunda oyunu kazanırsınız.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpara.Text == "" || txtpara.Text == "0")
            {
                MessageBox.Show("Bakiye yatırma alanı boş veya 0 olamaz!");

            }
            else
            {
                Random random = new Random();
                int rastgeleSayi = random.Next(0, 4);
                label3.Text = "Rastgele Gelen Sayı = '" + rastgeleSayi.ToString() + "'";
                int yatirilanPara = 0;
                                yatirilanPara = Convert.ToInt32(txtpara.Text);
                if (yatirilanPara > bakiye)
                {
                    MessageBox.Show("Girilen miktar hesabınızdaki paradan yüksek olduğu için yatırılamıyor!");
                }
                else
                {
                    if (rastgeleSayi == 0)
                    {
                        txtbakiye.Text = Convert.ToString(bakiye - yatirilanPara);
                        bakiye -= yatirilanPara;
                        txtpara.Text = "";
                    }
                    else if (rastgeleSayi == 1)
                    {
                        txtbakiye.Text = Convert.ToString(bakiye + yatirilanPara);
                        bakiye += yatirilanPara;
                        txtpara.Text = "";
                    }
                    else if (rastgeleSayi == 2)
                    {
                        txtbakiye.Text = Convert.ToString(bakiye + yatirilanPara * 2);
                        bakiye += yatirilanPara * 2;
                        txtpara.Text = "";
                    }
                    else if (rastgeleSayi == 3)
                    {
                        txtbakiye.Text = Convert.ToString(bakiye + yatirilanPara * 3);
                        bakiye += yatirilanPara * 3;
                        txtpara.Text = "";
                    }
                    if (bakiye >= 500)
                    {
                        MessageBox.Show("Tebrikler paranız şuanda =" + bakiye);
                        DialogResult result = MessageBox.Show("Tekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            bakiye = 120;
                            txtpara.Text = "";
                            txtbakiye.Text = "120";
                            label3.Text = "Rastele Gelen Sayı = ' '";
                        }
                        else if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else if (bakiye == 0)
                    {
                        MessageBox.Show("Maalesef paranız bitti. Oyun kapatılıyor!");
                        this.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Rastgele Gelen Sayı = ' '";
        }
    }
}