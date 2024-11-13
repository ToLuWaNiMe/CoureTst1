using System;

namespace ScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 15, 25, 35 };
            int[] array3 = { 8, 8 };

            Console.WriteLine("Score for array1: " + CalculateScore(array1)); // Output: 11
            Console.WriteLine("Score for array2: " + CalculateScore(array2)); // Output: 9
            Console.WriteLine("Score for array3: " + CalculateScore(array3)); // Output: 12
        }

        static int CalculateScore(int[] numbers)
        {
            int score = 0;
            foreach (int number in numbers)
            {
                score += number == 8 ? 5 : number % 2 == 0 ? 1 : 3;
            }
            return score;
        }
    }
}
