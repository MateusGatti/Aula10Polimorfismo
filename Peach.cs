namespace Aula10Polimorfismo
{
    public class Peach : Player
    {
        
        public override void Cair(){

            base.Cair();

            System.Console.WriteLine("Peach pode cair 20% mais devagar");

        }

    }
}