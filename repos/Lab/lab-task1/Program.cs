using System;

namespace lab_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medicine medicine = new Medicine
            //{
            //    Price = 100,
            //};

           Pharmacy pharmacy = new Pharmacy();

            //pharmacy.AddMedicine(medicine);

            string option;


            do
            {
                Console.WriteLine("\n1.Derman yarat");
                Console.WriteLine("2.Dermanlar'a bax");
                Console.WriteLine("3.Endirimli dermanlari goster");
                Console.WriteLine("4.Verilmis endirim araliginda olan dermanlari goster");
                Console.WriteLine("5.Verilmis kateqoriya ucun dermanlari goster");
                Console.WriteLine("6.Verilmis kateqoriya stokda nece dene derman qalib");
                Console.WriteLine("0.Proses bitdi\n");

                Console.WriteLine("Secim'i daxil edin:");
                tryoption: option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("\nCategory: ");
                        string category = Console.ReadLine();

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("DiscountPrice: ");
                        double discountPrice = Convert.ToDouble(Console.ReadLine());

                        Medicine md = new Medicine { Category = category, Name = name, Price = price, DiscountPrice = discountPrice };
                        pharmacy.AddMedicine(md);
                        break;

                    case "2":
                        for (int i = 0; i < pharmacy.medicines.Length; i++)
                        {
                            Console.WriteLine($"\n{i+1}.Derman\n");
                            Console.WriteLine($"Category: {pharmacy.medicines[i].Category}");
                            Console.WriteLine($"Name: {pharmacy.medicines[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.medicines[i].Price}");
                            Console.WriteLine($"DiscountPrice {pharmacy.medicines[i].DiscountPrice}\n");
                            Console.WriteLine("-----------------");
                        }
                        break;

                    case "3":
                        Medicine[] md1 = pharmacy.medicines;
                        Medicine[] newMd = new Medicine[0];

                        for (int i = 0; i < md1.Length; i++)
                        {
                            if (md1[i].DiscountPrice > 0 )
                            {
                                Array.Resize(ref newMd , newMd.Length + 1);
                                newMd[newMd.Length-1] = md1[i];
                            }
                        }

                        for (int i = 0; i < newMd.Length; i++)
                        {
                            Console.WriteLine($"\n{i + 1}.Derman\n");
                            Console.WriteLine($"Category: {pharmacy.medicines[i].Category}");
                            Console.WriteLine($"Name: {pharmacy.medicines[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.medicines[i].Price}");
                            Console.WriteLine($"DiscountPrice {pharmacy.medicines[i].DiscountPrice}\n");
                            Console.WriteLine("-----------------");
                        }
                        break;

                    case "4":
                        Console.Write("min: ");
                        int min = Convert.ToInt32(Console.ReadLine());

                        Console.Write("max: ");
                        int max = Convert.ToInt32(Console.ReadLine());

                        Medicine[] arr = pharmacy.ShowRange(min, max);

                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine($"\n{i + 1}.Derman\n");
                            Console.WriteLine($"Category: {pharmacy.medicines[i].Category}");
                            Console.WriteLine($"Name: {pharmacy.medicines[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.medicines[i].Price}");
                            Console.WriteLine($"DiscountPrice {pharmacy.medicines[i].DiscountPrice}\n");
                            Console.WriteLine("-----------------");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Axtardiginiz Category na daxil edin:");
                        string newStr = Console.ReadLine();

                        for (int i = 0; i < pharmacy.medicines.Length; i++)
                        {
                            if (pharmacy.medicines[i].Category == newStr)
                            {
                                Console.WriteLine($"\n{i + 1}.Derman\n");
                                Console.WriteLine($"Category: {pharmacy.medicines[i].Category}");
                                Console.WriteLine($"Name: {pharmacy.medicines[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.medicines[i].Price}");
                                Console.WriteLine($"DiscountPrice {pharmacy.medicines[i].DiscountPrice}\n");
                                Console.WriteLine("-----------------");
                            }
                        }
                        break;

                    case "6":
                        Console.WriteLine("Axtardiginiz Category na daxil edin:");
                        string newStr1 = Console.ReadLine();

                        int count = 0;

                        for (int i = 0; i < pharmacy.medicines.Length; i++)
                        {
                            if (pharmacy.medicines[i].Category == newStr1)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Verilmis Category'in sayi: {count}");
                        break;

                    case "0":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine();
                        goto tryoption;
                }

            } while (option != "0");

           

        }
    }
}
