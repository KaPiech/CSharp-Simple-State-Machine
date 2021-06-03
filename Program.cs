using System;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////// SIMULATION //////////////// 
            App simulation = new App();
            Console.WriteLine("Stan poczatkowy: " + simulation.Info());
            simulation.Opady(2);    //check modes in "Chmura.cs"
            Console.WriteLine("Stan po opadach: " + simulation.Info());
            simulation.Picie();
            Console.WriteLine("Stan po piciu: " + simulation.Info());
            simulation.Wydalanie();
            Console.WriteLine("Stan po wydalanu: " + simulation.Info());
            simulation.Oczyszczanie();
            Console.WriteLine("Stan po oczyszczaniu: " + simulation.Info());
            simulation.Picie();
            Console.WriteLine("Stan po piciu: " + simulation.Info());
            simulation.Wydalanie();
            Console.WriteLine("Stan po wydalanu: " + simulation.Info());
            simulation.Wpływa();
            Console.WriteLine("Stan po wplywaniu: " + simulation.Info());
            simulation.Parowanie();
            Console.WriteLine("Stan po parowaniu: " + simulation.Info());
        }
    }
}
