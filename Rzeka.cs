using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Rzeka : Stany_Kropli
    {
        protected App parent;
        public Rzeka(App app)
        {
            parent = app;
        }
        public override void Oddychanie() { }
        public override void Opady(int i) { }
        public override void Parowanie() { }
        public override void Wpływa() { parent.ZmienStan(new Ocean(parent)); }
        public override void Picie() { parent.ZmienStan(new Zwierze(parent)); }
        public override void Oczyszczanie() { }
        public override void Wydalanie() { }
        public override string Info() { return "Rzeka"; }
    }
}
