using System;

namespace Arrays___mission_2___increasing_level_difficulty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int length = 100;
            int[] monsterNumber = new int[length];

            for (int i = 0; i < length; i++)
            {
               monsterNumber[i] = new Random().Next(1, 50);
            }
            Array.Sort(monsterNumber);

            Console.WriteLine("Number of monsters in level is: ");
            foreach (int i in monsterNumber)
            {
                Console.Write($"{i}, ");

            }
        }
       /* private static int LevelDifficulty()
        {


            int[] monsterNumber = {1 ,2 , 3};
            
            foreach (int i in monsterNumber)
            {
                Console.WriteLine(i);
                
            }
            

        }*/
    }
}
