using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTesting
{
    internal class RandomNumber
    {
        private int LoopCount = 1;
        private int CurrentRandom = 1000;
        public void RuningRandom()
        {

            do
            {
                if (CurrentRandom == 0)
                {
                    break;
                }

                Console.Write("Enter Your Random");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (!key.Equals(ConsoleKey.Enter))
                {
                    break;
                }
                LoopCount++;

                if (LoopCount > 1)
                {
                    Random rd = new Random();
                    CurrentRandom = rd.Next(0, CurrentRandom);
                    Console.WriteLine("No {0} Display: {1}", LoopCount, CurrentRandom);
                }


            } while (true);

        }
    }
}

