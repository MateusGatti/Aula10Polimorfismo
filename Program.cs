using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Mario:");
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();
            mario.Cair();





            System.Console.WriteLine("Luigi:");
            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
            luigi.Cair();




            System.Console.WriteLine("Peach:");
            Peach peach = new Peach();
            peach.Correr();
            peach.Pular();
            peach.Cair();

        }
    }
}
