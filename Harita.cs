using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280014_YunusEmreKarakuzu
{
    public static class Harita
    {

        public static List<Asker> Maviler = new List<Asker>();
        public static List<Asker> Kirmizilar = new List<Asker>();
        public static Nokta [,] konumlar = new Nokta[16,16];
        public static void swap(int x1,int y1, int x2,int y2)
        {
            konumlar[x2, y2].Bulunan = konumlar[x1, y1].Bulunan;
            konumlar[x1, y1].Bulunan = null;
        }
        public static void Hareket_Et(Asker a,bool takim)
        {
            Random aa = new Random();
            int olasilik = aa.Next(101);
            Console.WriteLine(" " + olasilik);
            //treu ise kırmızı takım
            //false ise mavi takim
            if (takim)//kırmızı takım
            {
                if (a is Er)
                {
                    if(olasilik<=20)//ileri
                    {
                        if(Harita.konumlar[a.X,a.Y-1].Bulunan==null)
                        {
                            swap(a.X, a.Y, a.X, a.Y - 1);
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if(olasilik>20 || olasilik<=30 )//geri
                    {
                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y + 1);
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if(olasilik>30 || olasilik<=70 )//ateş et
                    {
                            olasilik= aa.Next(101);

                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan != null)//onunde dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y + 1].Bulunan;
                            if (dusman.takim==false)
                            {
                                if(olasilik<=50)
                                {
                                    a.Ates_et(dusman,5);
                                    if(dusman.hp<=0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if(olasilik>50 || olasilik<=80 )
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                
                            }
                        }
                        else if (Harita.konumlar[a.X, a.Y - 1].Bulunan != null)//arkasında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X-1, a.Y].Bulunan != null)//solunda dusman
                        {
                            Asker dusman = Harita.konumlar[a.X-1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X+1, a.Y].Bulunan != null)//sagında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X+1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                    }
                    else //bekle
                    {

                    }
                }
                if (a is Tegmen)
                {
                    if (olasilik <= 10)//ileri
                    {
                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y - 1);
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 10 || olasilik <= 20)//geri
                    {
                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y + 1);
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 20 || olasilik <= 30)//saga ilerleme
                    {
                        if (Harita.konumlar[a.X + 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y);
                            a.X = a.X + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 30 || olasilik <= 40)//sol ilerleme
                    {
                        if (Harita.konumlar[a.X - 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y);
                            a.X = a.X - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 40 || olasilik <= 70)//ateş et
                    {
                        olasilik = aa.Next(101);

                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan != null)//onunde dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X, a.Y - 1].Bulunan != null)//arkasında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y].Bulunan != null)//solunda dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y].Bulunan != null)//sagında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                    }
                    else //bekle
                    {

                    }
                }
                if (a is Yuzbasi)
                {
                    if (olasilik <= 10)//ileri
                    {
                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y - 1);
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 10 || olasilik <= 20)//geri
                    {
                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y + 1);
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 20 || olasilik <= 30)//saga ilerleme
                    {
                        if (Harita.konumlar[a.X + 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y);
                            a.X = a.X + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 30 || olasilik <= 40)//sol ilerleme
                    {
                        if (Harita.konumlar[a.X - 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y);
                            a.X = a.X - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 40 || olasilik <= 45)//sag capraz yukarı
                    {
                        if (Harita.konumlar[a.X + 1, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y - 1);
                            a.X = a.X + 1;
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 45 || olasilik <= 50)//sol capraz yukarı
                    {
                        if (Harita.konumlar[a.X - 1, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y - 1);
                            a.X = a.X - 1;
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 50 || olasilik <= 55)//sag capraz asagı
                    {
                        if (Harita.konumlar[a.X + 1, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y + 1);
                            a.X = a.X + 1;
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 55 || olasilik <= 60)//sol capraz asagı
                    {
                        if (Harita.konumlar[a.X - 1, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y + 1);
                            a.X = a.X - 1;
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 60 || olasilik <= 80)//ateş et
                    {
                        olasilik = aa.Next(101);

                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan != null)//onunde dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X, a.Y - 1].Bulunan != null)//arkasında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y].Bulunan != null)//solunda dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y].Bulunan != null)//sagında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y - 1].Bulunan != null)//sag yukarı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y - 1].Bulunan != null)//sol yukarı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y + 1].Bulunan != null)//sag asagı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y + 1].Bulunan != null)//sol asagı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Maviler.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                    }
                    else //bekle
                    {

                    }
                }
            }
            else if (takim==false)//mavi takım ise
            {
                if (a is Er)
                {
                    if (olasilik <= 20)//ileri
                    {
                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y + 1);
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 20 || olasilik <= 30)//geri
                    {
                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y - 1);
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 30 || olasilik <= 70)//ateş et
                    {
                        olasilik = aa.Next(101);

                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan != null)//onunde dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X, a.Y + 1].Bulunan != null)//arkasında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y].Bulunan != null)//solunda dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y].Bulunan != null)//sagında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 5);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                    }
                    else //bekle
                    {

                    }
                }
                if (a is Tegmen)
                {
                    if (olasilik <= 10)//ileri
                    {
                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y + 1);
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 10 || olasilik <= 20)//geri
                    {
                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y - 1);
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 20 || olasilik <= 30)//saga ilerleme
                    {
                        if (Harita.konumlar[a.X - 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y);
                            a.X = a.X - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 30 || olasilik <= 40)//sol ilerleme
                    {
                        if (Harita.konumlar[a.X + 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y);
                            a.X = a.X + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 40 || olasilik <= 70)//ateş et
                    {
                        olasilik = aa.Next(101);

                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan != null)//onunde dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X, a.Y + 1].Bulunan != null)//arkasında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y].Bulunan != null)//solunda dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y].Bulunan != null)//sagında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 10);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 20);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                    }
                    else //bekle
                    {

                    }
                }
                if (a is Yuzbasi)
                {
                    if (olasilik <= 10)//ileri
                    {
                        if (Harita.konumlar[a.X, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y + 1);
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 10 || olasilik <= 20)//geri
                    {
                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X, a.Y - 1);
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 20 || olasilik <= 30)//saga ilerleme
                    {
                        if (Harita.konumlar[a.X - 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y);
                            a.X = a.X - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 30 || olasilik <= 40)//sol ilerleme
                    {
                        if (Harita.konumlar[a.X + 1, a.Y].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y);
                            a.X = a.X + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 40 || olasilik <= 45)//sag capraz yukarı
                    {
                        if (Harita.konumlar[a.X - 1, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y + 1);
                            a.X = a.X - 1;
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 45 || olasilik <= 50)//sol capraz yukarı
                    {
                        if (Harita.konumlar[a.X + 1, a.Y + 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y + 1);
                            a.X = a.X + 1;
                            a.Y = a.Y + 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 50 || olasilik <= 55)//sag capraz asagı
                    {
                        if (Harita.konumlar[a.X - 1, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X - 1, a.Y - 1);
                            a.X = a.X - 1;
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 55 || olasilik <= 60)//sol capraz asagı
                    {
                        if (Harita.konumlar[a.X + 1, a.Y - 1].Bulunan == null)
                        {
                            swap(a.X, a.Y, a.X + 1, a.Y - 1);
                            a.X = a.X + 1;
                            a.Y = a.Y - 1;
                        }
                        else
                        {
                            a.Bekle();
                        }
                    }
                    else if (olasilik > 60 || olasilik <= 80)//ateş et
                    {
                        olasilik = aa.Next(101);

                        if (Harita.konumlar[a.X, a.Y - 1].Bulunan != null)//onunde dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X, a.Y + 1].Bulunan != null)//arkasında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y].Bulunan != null)//solunda dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y].Bulunan != null)//sagında dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y + 1].Bulunan != null)//sag yukarı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y + 1].Bulunan != null)//sol yukarı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y + 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X - 1, a.Y - 1].Bulunan != null)//sag asagı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X - 1, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                        else if (Harita.konumlar[a.X + 1, a.Y - 1].Bulunan != null)//sol asagı capraz dusman
                        {
                            Asker dusman = Harita.konumlar[a.X + 1, a.Y - 1].Bulunan;
                            if (dusman.takim == false)
                            {
                                if (olasilik <= 50)
                                {
                                    a.Ates_et(dusman, 15);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else if (olasilik > 50 || olasilik <= 80)
                                {
                                    a.Ates_et(dusman, 25);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }
                                else
                                {
                                    a.Ates_et(dusman, 40);
                                    if (dusman.hp <= 0)
                                    {
                                        Kirmizilar.Remove(dusman);
                                        Harita.konumlar[dusman.X, dusman.Y].Bulunan = null;
                                    }
                                }

                            }
                        }
                    }
                    else //bekle
                    {

                    }
                }
            }



        }
    }
}
