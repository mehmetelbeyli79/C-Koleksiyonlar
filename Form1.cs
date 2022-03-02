using System.Collections;//Koleksiyonlarý Kullanmak Ýçin Gereken Kütüphane

namespace Koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Dizilerin Koleksiyonlara göre bazý sýnýrlamalarý vardýr.
         Bu sýnýrlamalar þunlardýr:
            1. Dizilere aktarýlacak deðerler dizi ile ayný tipte olmalýdýr.
            2. Dizilerin eleman sayýlarý önceden belirlenmelidir.
         */

        /*
         Hazýr koleksiyonlardan bazýlarý þunlardýr:
            • ArrayList
            • List
            • Queue-Stack
            • Dictionary
            • HashTable
            • SortedList
         */
        /*
         Boxing (Kutulama)-Unboxing (Kutu Açma)
            Nesne Tabanlý Programlama dilinde Value Type (deðer tipi) ve Reference Type (referans tipi)
            olmak üzere iki veri tipi vardýr. Deðer tipleri; int, char, byte, double vb. belleðinin Stack adý verilen kýsmýnda
            tutulur. Referans tipleri ise object, string, class vb. belleðin Heap adý verilen kýsmýnda tutulur.
            Boxing, herhangi value (deðer) tipideki deðiþkenin object (nesne) tipindeki deðiþkene dönüþtürülmesidir.
         
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
             Insert metodu, koleksiyonlara deðer eklemenin bir diðer yoludur. Bu metodun add metodundan
             farký, eklenecek deðerin hangi sýraya atanacaðýnýn belirtilmesidir.
             */
            sehirler.Insert(1, "Ýstanbul");
            /*
             Her türlü bellekte saklanan indisi 1 olan yani Array Listte Ýkinci eleman olan yeri deðiþtirir.Araya bu veri eklenir
             
             */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             Þehirler Array Listinde Bulunan ilk Kilis Olan veriyi siler.
             
             */
            sehirler.Remove("Kilis");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             Þehirler Arrayindeki Üçüncü elemaný Siler
             */
            sehirler.RemoveAt(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             Bir ArrayList içinde bir verinin aranmasý için birkaç yöntem bulunmaktadýr. Bunlardan bir tanesi
                Contains metodudur. Contains metodu; aranan veri koleksiyonda varsa true, yoksa false deðerini geriye
                döndürür.
             */
            if(sehirler.Contains("Kilis"))
            {
                MessageBox.Show("Aradýðýnýz Þehir VeriTabanýnda Mevcut");
            }
            else
            {
                MessageBox.Show("Þehir Bulunamadý");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
             ArrayList içinde bir diðer arama yöntemi IndexOf metodudur. Bu metot, Contains metodundan
            farklý olarak koleksiyon içinde aranan veri bulunursa index numarasýný, bulunamazsa -1 deðerini geriye
            döndürür.
             */
            int durum = sehirler.IndexOf("Kilis");
            if(durum!=-1)
            {
                MessageBox.Show("Aradýðýnýz Þehrin index numarasý: " + durum);
            }
            else
            {
                MessageBox.Show("Böyle Bir Þehir Bulunamamýþtýr.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             ArrayList içindeki veriler, eklenme sýrasýna göre 0 index numarasýndan baþlayarak devam eder.
            Reverse metodu bu sýralamayý tamamen tersine çevirmektedir.
             
             */
            sehirler.Reverse();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
             Bir diðer sýralama ise Sort metodudur. Sort metodu, ArrayList içindeki deðerleri artan bir sýra hâlinde
            yeniden düzenlemektedir. Sort metodu; koleksiyondaki elemanlar yazý tipinde ise a’dan z’ye, sayýsal tipte
            ise küçükten büyüðe doðru sýralar.
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