using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Studnia : Stany_Kropli
    {
        protected App parent;
        public Studnia(App app)
        {
            parent = app;
        }

        public override void Oddychanie() { }
        public override void Opady(int i) { }
        public override void Parowanie() { }
        public override void Wpływa() { }
        public override void Picie() { parent.ZmienStan(new Człowiek(parent)); }
        public override void Oczyszczanie() { }
        public override void Wydalanie() { }
        public override string Info() { return "Studnia"; }
    }
}
