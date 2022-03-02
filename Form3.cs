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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Queue kuyruk=new Queue();
        int sira = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);/* Kuyruğa Ekleme İşlemi Yapıyor Sonuna Ekliyor. */
            listele();
        }

        private void listele()
        {
            listBox1.Items.Clear();
            foreach(int sira in kuyruk)
            {
                listBox1.Items.Add(sira);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();//Kuyruğa ilk eklenen Elemanı siler
            listele();
        }

        Stack yigin=new Stack();
        private void button3_Click(object sender, EventArgs e)
        {
            yigin.Push(textBox1.Text);
            listele1();
        }
        private void listele1()
        {
            listBox2.Items.Clear();
            foreach(string isim in yigin)
            {
                listBox2.Items.Add(isim);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            listele1();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm=new Form1();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form4=new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
