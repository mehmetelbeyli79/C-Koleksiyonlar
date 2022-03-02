using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Koleksiyonlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form =new Form1();
            form.Show();
            this.Hide();
        }

        ArrayList kolA = new ArrayList(); // ArrayList koleksiyonu
        List<int> kolL = new List<int>(); // List koleksiyonu
        Stopwatch km = new Stopwatch(); // Geçen süreyi hesaplama için nesne
        int elemanSayisi = 100000; // Test için eleman sayısı
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAEkle_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                kolA.Add(i);
            }
            km.Stop();
            lblAEkle.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLEkle_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                kolL.Add(i);
            }
            km.Stop();
            lblLEkle.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnATopla_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolA.Count; i++)
            {
                toplam += (int)kolA[i];
            }
            km.Stop();
            lblATopla.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLTopla_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolL.Count; i++)
            {
                toplam += kolL[i];
            }
            km.Stop();
            lblLTopla.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnAYaz_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                listeA.Items.Add(kolA[i]);
            }
            km.Stop();
            lblAYaz.Text = "= " +
             km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLYaz_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < kolL.Count; i++)
            {
                listeL.Items.Add(kolL[i]);
            }
            km.Stop();
            lblLYaz.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnABul_Click(object sender, EventArgs e)
        {
            km.Start();
            if (kolA.Contains(9999))
            {
                km.Stop();
            }
            lblABul.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLBul_Click(object sender, EventArgs e)
        {
            km.Start();
            if (kolL.Contains(9999))
            {
                km.Stop();
            }
            lblLBul.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 frm3=new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
