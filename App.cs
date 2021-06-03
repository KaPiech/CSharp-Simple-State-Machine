using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class App
    {
        private Stany_Kropli obecny_stan;

        public App()
        {
            obecny_stan = new Chmura(this);
        }

        public void ZmienStan(Stany_Kropli newState)
        {
            obecny_stan = newState;
        }

        public void Oddychanie()
        {
            obecny_stan.Oddychanie();
        }
        public void Opady(int i)
        {
            obecny_stan.Opady(i);
        }
        public void Parowanie()
        {
            obecny_stan.Parowanie();
        }
        public void Wpływa()
        {
            obecny_stan.Wpływa();
        }
        public void Picie()
        {
            obecny_stan.Picie();
        }
        public void Oczyszczanie()
        {
            obecny_stan.Oczyszczanie();
        }
        public void Wydalanie()
        {
            obecny_stan.Wydalanie();
        }
        public string Info()
        {
           return obecny_stan.Info();
        }
    }
}
