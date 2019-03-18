using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280014_YunusEmreKarakuzu
{
    public class Asker
    {
        public Asker(int x,int y)
        {
            hp = 100;
            this.X = x;
            this.Y = y;
            Harita.konumlar[x, y].Bulunan=this;
        }
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public virtual bool takim { get; set; }
        public virtual int hp { get; set; }
        virtual public void Ates_et(Asker a,short hasar)
        {
            a.hp -= hasar;
            if(a.hp<0)
            {
                a.hp = 0;
            }
        }
        
        virtual public void Bekle()
        {

        }
    }
}
