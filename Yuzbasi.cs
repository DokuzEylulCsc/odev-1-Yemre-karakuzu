using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280014_YunusEmreKarakuzu
{
    class Yuzbasi : Asker
    {
        public Yuzbasi(int x,int y):base(x,y)
        {
            hp = 100;
            this.X = x;
            this.Y = y;
            Harita.konumlar[x, y].Bulunan = this;
        }

        public override int hp { get => base.hp; set => base.hp = value; }
        public override int X { get => base.X; set => base.X = value; }
        public override int Y { get => base.Y; set => base.Y = value; }

        public override void Ates_et(Asker a, short hasar)
        {
            base.Ates_et(a, hasar);
        }

       
    }
}

