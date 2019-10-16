using System;

namespace BranchesAndLoops
{
    class Program
    {
        
        static void ExploreIf()
        {
             int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }

        static void WhileCounter()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"The counter is at {counter}.");
                counter++;
            }

        }

        static void ForCounter()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"The for counter index is at {index}");
            }
        }

        static void SumsChallenge()
        {
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
        //    ExploreIf();
            // WhileCounter();
            // ForCounter();
            SumsChallenge();
        }   
    }
}
