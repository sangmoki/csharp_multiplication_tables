using System;

namespace MultipulicationTables
{
    class Program
    {
        // Factorial 이란 n값을 -1 해가며 곱 계산
        static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static void Main(string[] args)
        {
            // 구구단 계산
            /*            for (int i = 2; i <= 9; i++)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                Console.WriteLine($"{i} * {j} = {i * j}");
                            }
                        }*/

            // 별찍기 1-5까지
            /*            for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.WriteLine("*");
                            }
                            Console.WriteLine();
                        }*/

            // 팩토리얼 계산 5에서 1까지 -1씩 뺀 숫자 곱하기
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}