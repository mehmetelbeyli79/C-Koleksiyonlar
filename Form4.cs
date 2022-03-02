using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Koleksiyonlar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        /* Bu Koleksiyonun en güzel yanı key-value prensibine göre çalışmasıdır.Burada key benzersizdir ve 1 tane olmalıdır.
         * Yoksa program hata verecektir.
         * 
         
         
         */

        Dictionary<int, string> ogrenciler=new Dictionary<int, string>();
        int anahtar;
        string deger;
        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (textBox1.Text !="")
            {
                anahtar = int.Parse(textBox1.Text);
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                deger = textBox1.Text;
                durum = ogrenciler.ContainsValue(deger);
            }
            if (durum == true)
            {
                MessageBox.Show("Öğrenci Kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Öğrenci Kayıtlı Değildir.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anahtar=Convert.ToInt32(textBox1.Text);
            deger = textBox2.Text;
            ogrenciler.Add(anahtar, deger);
            listele();
        }

        private void listele()
        {
            listBox1.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                listBox1.Items.Add("Öğrenci No:"+ogrenci.Key+"-- Ad:"+ogrenci.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ogr_key=Convert.ToInt32(textBox1.Text);
            string deger_guncelle = textBox2.Text;
            ogrenciler[ogr_key] = deger_guncelle;
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ogr_key = Convert.ToInt32(textBox1.Text);
            ogrenciler.Remove(ogr_key);
            listele();
        }
    }
}
