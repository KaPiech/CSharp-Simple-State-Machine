using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    abstract class Stany_Kropli
    {
        public abstract void Oddychanie();
        public abstract void Opady(int i);
        public abstract void Parowanie();
        public abstract void Wpływa();
        public abstract void Picie();
        public abstract void Oczyszczanie();
        public abstract void Wydalanie();

        public abstract string Info();
    }
}
