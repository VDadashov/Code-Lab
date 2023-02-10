using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //CountWord("  salam necesen ");

            //string input = Console.ReadLine();
            //Console.WriteLine(IsDigit(input));

            //string input1 = Console.ReadLine();
            //Console.WriteLine(Letter(input1));

            //string word = Console.ReadLine();

            //string input = Console.ReadLine();
            //char cr = Convert.ToChar(input);


            //Console.WriteLine(CountChar(input, 'a'));

            //Console.WriteLine(Factorial(4));

            string word = Console.ReadLine();
            Reverse( ref word);
            Console.WriteLine(word);
        }

        static void CountWord(string input)
        {
            int count = 0;
            string newStr = input.Trim();

            string[] arr = newStr.Split();

            Console.WriteLine(arr.Length);
        }

        static bool IsDigit(string text)
        {
            for (int i = 0; i < text.Length;i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool Letter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static int CountChar(string text,char cr)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == cr)
                {
                    count++;
                }
            }
            return count;
        }

        static int Factorial(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            else
            {
                return N * Factorial(N-1);
            }

        }
        static void Reverse(ref string word)
        {
            string newStr = "";

            for (int i = word.Length-1;i>=0; i--)
            {
                newStr += word[i];
            }

            word = newStr;

        }
    }
}
