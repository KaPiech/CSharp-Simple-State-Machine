using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Oczyszczalnia : Stany_Kropli
    {
        protected App parent;
        public Oczyszczalnia(App app)
        {
            parent = app;
        }

        public override void Oddychanie() { }
        public override void Opady(int i) { }
        public override void Parowanie() { }
        public override void Wpływa() { }
        public override void Picie() { }
        public override void Oczyszczanie() { parent.ZmienStan(new Rzeka(parent)); }
        public override void Wydalanie() { }
        public override string Info() { return "Oczyszczalnia"; }
    }
}
