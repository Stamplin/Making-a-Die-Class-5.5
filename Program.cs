using System.Runtime;

namespace Making_a_Die_Class_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();

            
            die1.RollDie();
            die1.DrawRoll();
            Console.WriteLine(die1.Roll);

            //press space to roll again non stop over and over
            while (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                die1.RollDie();
                die1.DrawRoll();
                Console.WriteLine(die1.Roll);
            }
           
           
        }
    }
}
