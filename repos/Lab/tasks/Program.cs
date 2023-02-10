using System;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3;

            Console.Write("Sayi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i < n; i++)
            {
                num3 = num1 + num2;


                
                num1 = num2;
                num2 = num3;

                int result = num3;


                

            }

            
        }
    }
}
