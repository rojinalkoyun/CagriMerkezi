using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_1
{
    public class Cagrilar
    {
       public string Notlar { get; set; }

        public int count = 0;

        
        public DateTime AramaZamani { get; set; }

        public DateTime AramaZamani2 { get; set; }
        public string MusteriTip { get; set; }

        public int MusteriID { get; set; }
        private Cagrı[] cagrilar;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        
        public Cagrilar(int size)
        {
            cagrilar = new Cagrı[size];

            for (int i = 0; i < cagrilar.Length; i++)
            {
                cagrilar[i] = new Cagrı();
            }
            this.size = size;

        }
        public void Insert()
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Arama dolu.");
            if (front == -1)
                front = 0;
            //kuyruktan fazla uzunlukta olursa başa ekleme
            if (rear == size - 1)
            {
                rear = 0;
                cagrilar[rear].CagriId = count + 1;
                cagrilar[rear].MT.CagriBaslamaZamani = AramaZamani;
                cagrilar[rear].MusteriID = MusteriID;
                cagrilar[rear].musteriTip = MusteriTip;



            }
            else
            {
                rear = rear + 1;
                cagrilar[rear].CagriId = count + 1;
                cagrilar[rear].MT.CagriBaslamaZamani = AramaZamani;
                cagrilar[rear].MusteriID = MusteriID;
                cagrilar[rear].musteriTip = MusteriTip;

            }

            count++;

        }
        public void Remove()
        {
            if (IsEmpty())
                throw new Exception("Arama yok.");
            bool kontrol=false;
            //sonradan eklenen özellikleri kuyruk yapısına uygun eklemek için
            for(int i=front; i<=rear; i++)
            {
                if (cagrilar[i].MT.CagriBitmeZamani == DateTime.MinValue)
                {
                    cagrilar[i].MT.CagriBitmeZamani = this.AramaZamani2;
                    cagrilar[i].MT.Notlar = this.Notlar;
                    kontrol = true;
                    break;
                }
            }
            if(!kontrol)
                throw new Exception("Cagri yok.");

            
            
        }
        public string Peek()
        {
            cagrilar[rear].CagriZamaniHesapla();
            return "Musteri İd: " + cagrilar[rear].MusteriID + "\nCagri Zaman: " + cagrilar[rear].CagriZamani.ToString();
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }
        public string EkranaYaz()
        {
            string temp = "";
            for (int i = 0; i < count; i++)
            {
                temp = i+1 + ")" + Peek().ToString();
            }

            return temp;
        }
        //ListBox için
        public string Listele()
        {
            string temp = "";
            temp =this.count+")"+"tip:"+ cagrilar[rear].musteriTip+" "+ cagrilar[rear].MusteriID+" Id li müşteri " ;   
            return temp;

        }
        
        public bool BireyselTicariKontrol()
        {
            return(cagrilar[front].musteriTip == "BireyselMT") ?  true : false;
        }
        public string MetinAra(string seciliKelime)
        {
            string temp="";
            int sayac = 0;
            for(int i = 0; i < count; i++)
            {
                char[] ayırıcıKarakterler = { ' ', ',', '.', ':', ';' };
                string[] kelimeler = cagrilar[i].MT.Notlar.Split(ayırıcıKarakterler);
                for (int j=0;j<kelimeler.Length;j++) 
                { 
                    if (seciliKelime == kelimeler[j])
                    {
                        sayac++;
                        temp += sayac+")"+cagrilar[i].MusteriID + " id li müşteri "+(i+1)+ " numarali cagrida bulunur.\n";
                        break;
                    }
                }
            }
            return temp;

        }
        public string CagriSureSırala()
        {
            string temp = "Artan Çağrı Zamanına Göre Dizilim\n";
            for (int i = 0; i < count; i++)
            {
                cagrilar[i].CagriZamani= cagrilar[i].CagriZamaniHesapla();
            }
            TimeSpan moved; int j; Cagrı movedd;
            int[] aynıGünler;int kontrol = 0;
            /* Aynı Güde olanları bulan
             * for (int i = 0; i < count; i++)
            {

                for(int j = i;  j < count; j++)
                if(cagrilar[i].CagriZamani.Days== cagrilar[j].CagriZamani.Days)
                        aynıGünler[kontrol]=

            }*/

            for (int i = 1; i < count; i++)
            {
               
                moved = cagrilar[i].CagriZamani;
                movedd = cagrilar[i];
                j = i;
                while (j > 0 && cagrilar[j - 1].CagriZamani> moved)
                {
                    cagrilar[j] = cagrilar[j - 1];
                    j--;
                }
                cagrilar[j] = movedd;
                
            }
            for(int i = 0; i<count; i++)
            {
                temp += "-Çağrı Zamanı: " + cagrilar[i].CagriZamani + "Çağrı Id: " + cagrilar[i].CagriId + "Müsteri Id: " + cagrilar[i].MusteriID + "\n";
                
                
            }
            return temp;
        }


    }
}
