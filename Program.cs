using System;

namespace MultipulicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 구구단 계산
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            // 별찍기 1-5까지
            /*            for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.WriteLine("*");
                            }
                            Console.WriteLine();
                        }*/
        }
    }
}