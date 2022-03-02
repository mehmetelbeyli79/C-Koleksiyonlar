using System.Collections;//Koleksiyonlar� Kullanmak ��in Gereken K�t�phane

namespace Koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Dizilerin Koleksiyonlara g�re baz� s�n�rlamalar� vard�r.
         Bu s�n�rlamalar �unlard�r:
            1. Dizilere aktar�lacak de�erler dizi ile ayn� tipte olmal�d�r.
            2. Dizilerin eleman say�lar� �nceden belirlenmelidir.
         */

        /*
         Haz�r koleksiyonlardan baz�lar� �unlard�r:
            � ArrayList
            � List
            � Queue-Stack
            � Dictionary
            � HashTable
            � SortedList
         */
        /*
         Boxing (Kutulama)-Unboxing (Kutu A�ma)
            Nesne Tabanl� Programlama dilinde Value Type (de�er tipi) ve Reference Type (referans tipi)
            olmak �zere iki veri tipi vard�r. De�er tipleri; int, char, byte, double vb. belle�inin Stack ad� verilen k�sm�nda
            tutulur. Referans tipleri ise object, string, class vb. belle�in Heap ad� verilen k�sm�nda tutulur.
            Boxing, herhangi value (de�er) tipideki de�i�kenin object (nesne) tipindeki de�i�kene d�n��t�r�lmesidir.
         
         */

        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            string sehir = textBox1.Text;
            sehirler.Add(sehir);
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i=0;i<sehirler.Count;i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             Insert metodu, koleksiyonlara de�er eklemenin bir di�er yoludur. Bu metodun add metodundan
             fark�, eklenecek de�erin hangi s�raya atanaca��n�n belirtilmesidir.
             */
            sehirler.Insert(1, "�stanbul");
            /*
             Her t�rl� bellekte saklanan indisi 1 olan yani Array Listte �kinci eleman olan yeri de�i�tirir.Araya bu veri eklenir
             
             */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             �ehirler Array Listinde Bulunan ilk Kilis Olan veriyi siler.
             
             */
            sehirler.Remove("Kilis");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             �ehirler Arrayindeki ���nc� eleman� Siler
             */
            sehirler.RemoveAt(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             Bir ArrayList i�inde bir verinin aranmas� i�in birka� y�ntem bulunmaktad�r. Bunlardan bir tanesi
                Contains metodudur. Contains metodu; aranan veri koleksiyonda varsa true, yoksa false de�erini geriye
                d�nd�r�r.
             */
            if(sehirler.Contains("Kilis"))
            {
                MessageBox.Show("Arad���n�z �ehir VeriTaban�nda Mevcut");
            }
            else
            {
                MessageBox.Show("�ehir Bulunamad�");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
             ArrayList i�inde bir di�er arama y�ntemi IndexOf metodudur. Bu metot, Contains metodundan
            farkl� olarak koleksiyon i�inde aranan veri bulunursa index numaras�n�, bulunamazsa -1 de�erini geriye
            d�nd�r�r.
             */
            int durum = sehirler.IndexOf("Kilis");
            if(durum!=-1)
            {
                MessageBox.Show("Arad���n�z �ehrin index numaras�: " + durum);
            }
            else
            {
                MessageBox.Show("B�yle Bir �ehir Bulunamam��t�r.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             ArrayList i�indeki veriler, eklenme s�ras�na g�re 0 index numaras�ndan ba�layarak devam eder.
            Reverse metodu bu s�ralamay� tamamen tersine �evirmektedir.
             
             */
            sehirler.Reverse();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
             Bir di�er s�ralama ise Sort metodudur. Sort metodu, ArrayList i�indeki de�erleri artan bir s�ra h�linde
            yeniden d�zenlemektedir. Sort metodu; koleksiyondaki elemanlar yaz� tipinde ise a�dan z�ye, say�sal tipte
            ise k���kten b�y��e do�ru s�ralar.
             */
            sehirler.Sort();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}