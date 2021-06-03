using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Chmura : Stany_Kropli
    {
        protected App parent;
        public Chmura(App app)
        {
            parent = app;
        }
   
        public override void Oddychanie() { }
        public override void Opady(int i)  //3 modes for Opady()
        {
            switch (i)
            {
                case 1:
                    parent.ZmienStan(new Roślina(parent));
                    break;
                case 2:
                    parent.ZmienStan(new Studnia(parent));
                    break;
                case 3:
                    parent.ZmienStan(new Rzeka(parent));
                    break;
            }
        }
 
        public override void Parowanie() { }
        public override void Wpływa() { }
        public override void Picie() { }
        public override void Oczyszczanie() { }
        public override void Wydalanie() { }
        public override string Info() { return "Chmura"; }
    }
}
