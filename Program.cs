using System.Runtime;

namespace Making_a_Die_Class_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();
            
            Console.WriteLine("Press space to roll the dice.");

            while (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                die1.RollDie();
                die2.RollDie();
                die1.DrawRoll();
                Console.WriteLine(die1.Roll);
                die2.DrawRoll();
                Console.WriteLine(die2.Roll);

                //check if the dice roll double
                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("The dice are Doubles.");
                }
                //check for snake eyes if both are 1
                else if (die1.Roll == 1 && die2.Roll == 1)
                {
                    Console.WriteLine("The dice are snake eyes.");
                }
                //check for sum of 7
                else if (die1.Roll + die2.Roll == 7)
                {
                    Console.WriteLine("The dice add up to 7.");
                }
                //check if it's even sum
                else if ((die1.Roll + die2.Roll) % 2 == 0)
                {
                    Console.WriteLine("The dice are even.");
                }

                //check if it's sequencential
                else if (die1.Roll == die2.Roll + 1 || die2.Roll == die1.Roll + 1 || die1.Roll == die2.Roll - 1 || die2.Roll == die1.Roll - 1)
                {
                    Console.WriteLine("The dice are sequencetial.");
                }
                //else tell which one is bigger
                else if (die1.Roll > die2.Roll)
                {
                    Console.WriteLine("The first die is bigger.");
                }
                else if (die2.Roll > die1.Roll)
                {
                    Console.WriteLine("The second die is bigger.");
                }
                else if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("The dice are equal.");
                }
                

            }



            Console.ReadLine();


        }
    }
}
