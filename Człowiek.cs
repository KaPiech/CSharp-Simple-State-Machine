using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Człowiek : Stany_Kropli
    {
        protected App parent;
        public Człowiek(App app)
        {
            parent = app;
        }

        public override void Oddychanie() { parent.ZmienStan(new Chmura(parent)); }
        public override void Opady(int i) { }
        public override void Parowanie() { }
        public override void Wpływa() { }
        public override void Picie() { }
        public override void Oczyszczanie() { }
        public override void Wydalanie() { parent.ZmienStan(new Oczyszczalnia(parent)); }
        public override string Info() { return "Człowiek"; }
    }
}
