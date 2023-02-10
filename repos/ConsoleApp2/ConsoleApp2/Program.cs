using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("deyeri daxil edin:");
            var num = Console.ReadLine();
            int day_num = Convert.ToInt32(num);

            string[] hefteGunleri = { "bazar ertesi", "cume", "cume axsami", "cersenbe", "cersenbe axsami", "senbe", "bazar" };
            Console.WriteLine(hefteGunleri[day_num - 1]);
            
        }
    }
}
