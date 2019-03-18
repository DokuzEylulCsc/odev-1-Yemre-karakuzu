using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280014_YunusEmreKarakuzu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Harita.konumlar[i, j] = new Nokta();
                }
            }
            Random rndom = new Random();

            //Mavi Takim
            Asker m1 = new Er(0,0);
            Harita.konumlar[0, 0].Bulunan = m1;
            /*m1.takim = false;
            Asker m2 = new Er(1, 1);
            Harita.konumlar[1, 1].Bulunan = m2;
            m2.takim = false;
            Asker m3 = new Er(2, 2);
            Harita.konumlar[2, 2].Bulunan = m3;
            m3.takim = false;
            Asker m4 = new Er(3, 3);
            Harita.konumlar[3, 3].Bulunan = m4;
            m4.takim = false;
            Asker m5 = new Tegmen(2, 4);
            Harita.konumlar[0, 0].Bulunan = m5;
            m5.takim = false;
            Asker m6 = new Tegmen(3, 2);
            Harita.konumlar[3, 2].Bulunan = m6;
            m6.takim = false;
            Asker m7 = new Yuzbasi(1, 3);
            Harita.konumlar[1,3].Bulunan = m7;
            m7.takim = false;
            */
            Harita.konumlar[0, 0].Bulunan.takim = false;
             Harita.konumlar[1, 1].Bulunan = new Er(1, 1);
             Harita.konumlar[1, 1].Bulunan.takim = false;
             Harita.konumlar[2, 2].Bulunan = new Er(2, 2);
             Harita.konumlar[2, 2].Bulunan.takim = false;
             Harita.konumlar[3, 3].Bulunan = new Er(3, 3);
             Harita.konumlar[3, 3].Bulunan.takim = false;
             Harita.konumlar[2, 4].Bulunan = new Tegmen(2, 4);
             Harita.konumlar[2, 4].Bulunan.takim = false;
             Harita.konumlar[3, 2].Bulunan = new Tegmen(3, 2);
             Harita.konumlar[3, 2].Bulunan.takim = false;
             Harita.konumlar[1, 3].Bulunan = new Yuzbasi(1, 3);
             Harita.konumlar[1, 3].Bulunan.takim = false;

            Harita.Maviler.Add(Harita.konumlar[0, 0].Bulunan);
            Harita.Maviler.Add(Harita.konumlar[1, 1].Bulunan);
            Harita.Maviler.Add(Harita.konumlar[2, 2].Bulunan);
            Harita.Maviler.Add(Harita.konumlar[3, 3].Bulunan);
            Harita.Maviler.Add(Harita.konumlar[2, 4].Bulunan);
            Harita.Maviler.Add(Harita.konumlar[3, 2].Bulunan);
            Harita.Maviler.Add(Harita.konumlar[1, 3].Bulunan);
            /*
            //Kırmızı Takim
            Asker r1 = new Er(15, 15);
            Harita.konumlar[15, 15].Bulunan = r1;
            r1.takim = true;
            Asker r2 = new Er(14, 14);
            Harita.konumlar[14, 14].Bulunan = r2;
            r2.takim = true;
            Asker r3 = new Er(12, 12);
            Harita.konumlar[12, 12].Bulunan = r3;
            r3.takim = true;
            Asker r4 = new Er(13, 13);
            Harita.konumlar[13, 13].Bulunan = r4;
            r4.takim = true;
            Asker r5 = new Tegmen(12, 14);
            Harita.konumlar[12, 14].Bulunan = r5;
            r5.takim = true;
            Asker r6 = new Tegmen(13, 12);
            Harita.konumlar[3, 2].Bulunan = r6;
            r6.takim = true;
            Asker r7 = new Yuzbasi(11, 13);
            Harita.konumlar[11, 13].Bulunan = r7;
            r7.takim = true;
            */
            Harita.konumlar[15, 15].Bulunan = new Er(15, 15);
            Harita.konumlar[15, 15].Bulunan.takim = true;
            Harita.konumlar[14, 14].Bulunan = new Er(14, 14);
            Harita.konumlar[14, 14].Bulunan.takim = true;
            Harita.konumlar[12, 12].Bulunan = new Er(12, 12);
            Harita.konumlar[12, 12].Bulunan.takim = true;
            Harita.konumlar[13, 13].Bulunan = new Er(13, 13);
            Harita.konumlar[13, 13].Bulunan.takim = true;
            Harita.konumlar[12, 14].Bulunan = new Tegmen(12, 14);
            Harita.konumlar[12, 14].Bulunan.takim = true;
            Harita.konumlar[13, 12].Bulunan = new Tegmen(13, 12);
            Harita.konumlar[13, 12].Bulunan.takim = true;
            Harita.konumlar[11, 13].Bulunan = new Yuzbasi(11, 13);
            Harita.konumlar[11, 13].Bulunan.takim = true;
            
            Harita.Kirmizilar.Add(Harita.konumlar[15, 15].Bulunan);
            Harita.Kirmizilar.Add(Harita.konumlar[14, 14].Bulunan);
            Harita.Kirmizilar.Add(Harita.konumlar[12, 12].Bulunan);
            Harita.Kirmizilar.Add(Harita.konumlar[13, 13].Bulunan);
            Harita.Kirmizilar.Add(Harita.konumlar[12, 14].Bulunan);
            Harita.Kirmizilar.Add(Harita.konumlar[13, 12].Bulunan);
            Harita.Kirmizilar.Add(Harita.konumlar[11, 13].Bulunan);

            while(true)
            {
                bool sira = false;
                Asker secilen=null;
                if (sira == false)
                {
                    int rnd = rndom.Next(Harita.Maviler.Count);
                    secilen = Harita.Maviler[rnd];
                    sira = true;
                }
                else
                {
                    int rnd = rndom.Next(Harita.Kirmizilar.Count);
                    secilen = Harita.Kirmizilar[rnd];
                    sira = false;
                }
                Harita.Hareket_Et(secilen,sira);
                if(Harita.Maviler.Count==0)
                {
                    Console.WriteLine("Red Wins");
                    break;
                }
                else if(Harita.Kirmizilar.Count==0)
                {
                    Console.WriteLine("Blue Wins");
                    break;
                }
            }
        }
    }
}
