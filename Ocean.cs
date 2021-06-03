using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Ocean : Stany_Kropli
    {
        protected App parent;
        public Ocean(App app)
        {
            parent = app;
        }

        public override void Oddychanie() { }
        public override void Opady(int i) { }
        public override void Parowanie() { parent.ZmienStan(new Chmura(parent)); }
        public override void Wpływa() { }
        public override void Picie() { }
        public override void Oczyszczanie() { }
        public override void Wydalanie() { }
        public override string Info() { return "Ocean"; }
    }
}
