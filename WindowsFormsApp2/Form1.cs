using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
        int dogru = 0, yanlis = 0, soru = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (soru == 0)
                MessageBox.Show("CEVAPLARINIZI BÜYÜK HARFLE YAZINIZ");
            if (soru == 8)
                MessageBox.Show("DOĞRU:" + dogru + "    YANLIŞ:" + yanlis);
            label4.Text = yanlis.ToString();
            label2.Text = dogru.ToString();
            linkLabel1.Text = "SONRAKİ";
            soru++;
            this.Text = soru.ToString();
            if (soru == 1)
            {
                richTextBox1.Text = "DİNAMİTİ İCAT EDEN VE HER YIL ADINA ÇEŞİTLİ DALLARDA ÖDÜL VERİLEN ÜNLÜ BİLİM İNSANI KİMDİR?";
                btna.BackColor = Color.AliceBlue;
            }
            if (soru == 2)
            {
                richTextBox1.Text = "HİMALAYALARDA BULUNAN VE DÜNYANIN EN YÜKSEK NOKTASINI OLUŞTURAN DORUĞUN ADI NEDİR?";
                btne.BackColor = Color.AliceBlue;
            }
            if (soru == 3)
            {
                richTextBox1.Text = " Türkiye’de yaşanan her ekonomik krizin ardından olduğu gibi 21 Şubat 2001 ekonomik krizinde de belli koşullarla Türkiye’ye orta ve uzun vadede kredi sağlayan uluslar arası kuruluşun adı nedir?";
                btnı.BackColor = Color.AliceBlue;
            }
            if (soru == 4)
            {
                richTextBox1.Text = "Nobel ödülleri hangi ülkede verilmektedir?";
                btni.BackColor = Color.AliceBlue;
            }
            if (soru == 5)
            {
                richTextBox1.Text = " Nobel edebiyat ödülünü kazanan ilk Türk yazarımız kimdir?";
               btno.BackColor = Color.AliceBlue;
            }
            if (soru == 6)
            {
                richTextBox1.Text = "Kısa hikâyeciliğin kurucu ismi ve Ashâb-ı Kehfimiz, Efruz Bey, Yalnız Efe romanlarının yazarı olan yazar kimdir";
                btnö.BackColor = Color.AliceBlue;
            }
            if (soru == 7)
            {
                richTextBox1.Text = "Dünya kupasını ilk kez kim kazanmıştır?";
                btnu.BackColor = Color.AliceBlue;
            }
            if (soru == 8)
            {
                richTextBox1.Text = "Yaklaşık olarak veya az bir farkla anlamına gelen deyim nedir?";
                btnü.BackColor = Color.AliceBlue;
            }
           
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                switch (soru)
                {
                    case 1:
                        if(textBox1.Text=="ALBERT NOBEL")
                        {
                            btna.BackColor = Color.Green;
                            dogru++;
                          
                        }
                        else
                        {

                            btna.BackColor = Color.Red;
                            yanlis++;
                          
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "EVEREST")
                        {
                            btne.BackColor = Color.Green;
                            dogru++;
                          
                        }
                        else
                        {
                            btne.BackColor = Color.Red;
                            yanlis++;
                          
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "IMF")
                        {
                            btnı.BackColor = Color.Green;
                            dogru++;
                           
                        }
                        else
                        {
                            btnı.BackColor = Color.Red;
                            yanlis++;
                           
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "İSVEÇ")
                        {
                            btni.BackColor = Color.Green;
                            dogru++;
                       
                        }
                        else
                        {
                            btni.BackColor = Color.Red;
                            yanlis++;
                           
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "ORHAN PAMUK")
                        {
                            btno.BackColor = Color.Green;
                            dogru++;
                            textBox1.Text = " ";
                        }
                        else
                        {
                            btno.BackColor = Color.Red;
                            yanlis++;
                          
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ÖMER SEYFETTİN")
                        {
                            btnö.BackColor = Color.Green;
                            dogru++;
                           
                        }
                        else
                        {
                            btnö.BackColor = Color.Red;
                            yanlis++;

                        }
                        break;
                    case 7:
                        if (textBox1.Text == "URUGUAY")
                        {
                            btnu.BackColor = Color.Green;
                            dogru++;
                          ;
                        }
                        else
                        {
                            btnu.BackColor = Color.Red;
                            yanlis++;
                          
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "ÜÇ AŞAĞİ BEŞ YUKARI")
                        {
                            btnü.BackColor = Color.Green;
                            dogru++;
                          
                        }
                        else
                        {
                            btnü.BackColor = Color.Red;
                            yanlis++;
                        
                        }
                        break;
                      
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
