using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Shexs yarat");
            Console.WriteLine("2.Shexslere bax");
            Console.WriteLine("3.Shexsler uzre axtaris et");
            Console.WriteLine("4.Nomrelere gore axtaris et");
            Console.WriteLine("5.Bakcell nomrelere gore axtaris et");
            Console.WriteLine("0. Menu\n");

            string secim;

            string[] arr = { "Shems-0554568342", "Vusal-0557002423","Hesen-0554629909" };

            do
            {
                Console.WriteLine("Seciminizi daxil edin:");
                secim = Console.ReadLine();

                switch (secim)
                {

                    case "1":
                        Console.WriteLine("Shexs'i daxil edin:");
                        string shexs = Console.ReadLine();
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = shexs;
                        break;

                    case "2":
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nYoxlamaq istediyiniz name'i daxil edin");
                        string searchName = Console.ReadLine();
                        bool isName = false;

                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].Contains(searchName))
                            {
                                Console.WriteLine(arr[i]);
                                isName = true;
                            }          
                        }
                        if (isName == false)
                        {
                            Console.WriteLine("Bele bir istifadeci yoxdur\n");
                        }

                        break;

                    case "4":
                        Console.WriteLine("\nYoxlamaq istediyiniz nomre'ni daxil edin:");
                        string searchNomre = Console.ReadLine();
                        bool isNumber = false;

                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].Contains(searchNomre))
                            {
                                Console.WriteLine(arr[i]);
                                isNumber = true;
                            }
                        }
                        if (isNumber == false)
                        {
                            Console.WriteLine("Bele bir Bakcell nomresi yoxdur\n");
                        }

                        break;

                    case "5":
                        Console.WriteLine("");
                        break;

                    case "0":
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("");
                        break;


                }
            } while (secim != "0");
        }
    }
}
