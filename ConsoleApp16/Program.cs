//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Tələbələrin sayını daxil edin: ");
//        int telebeSayi = int.Parse(Console.ReadLine());
//        double toplamOrta = 0;

//        for (int i = 1; i <= telebeSayi; i++)
//        {
//            Console.Write($"Tələbə {i} adını daxil edin: ");
//            string ad = Console.ReadLine();

//            double toplamBal = 0;
//            for (int j = 1; j <= 3; j++)
//            {
//                Console.Write($"{ad} üçün imtahan {j} balını daxil edin: ");
//                double bal = double.Parse(Console.ReadLine());
//                toplamBal += bal;
//            }

//            double ortaBal = toplamBal / 3;
//            toplamOrta += ortaBal;
//        }

//        double umumOrta = toplamOrta / telebeSayi;
//        Console.WriteLine($"\nÜmumi orta bal: {umumOrta:F2}");

//        if (umumOrta > 90)
//        {
//            Console.WriteLine("Əla");
//        }
//        else if (umumOrta > 70)
//        {
//            Console.WriteLine("Yaxşı");
//        }
//        else if (umumOrta > 50)
//        {
//            Console.WriteLine("Kafi");
//        }
//        else
//        {
//            Console.WriteLine("Zəif");
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        string duzgunPIN = "1234";
//        int cehd = 0;
//        double balans = 0;

//        while (cehd < 3)
//        {
//            Console.Write("PIN daxil edin: ");
//            if (Console.ReadLine() == duzgunPIN)
//            {
//                while (true)
//                {
//                    Console.WriteLine("\n1. Balans göstər\n2. Pul əlavə et\n3. Çıxış");
//                    Console.Write("Seçim: ");
//                    string secim = Console.ReadLine();

//                    if (secim == "1") Console.WriteLine($"Balans: {balans} AZN");
//                    else if (secim == "2")
//                    {
//                        Console.Write("Məbləği daxil edin: ");
//                        if (double.TryParse(Console.ReadLine(), out double mebleg)) balans += mebleg;
//                    }
//                    else if (secim == "3") break;
//                    else Console.WriteLine("Düzgün seçim edin!");
//                }
//                break;
//            }
//            else
//            {
//                cehd++;
//                Console.WriteLine(cehd == 3 ? "Sistem bloklandı!" : $"Səhv PIN! Qalan cəhd: {3 - cehd}");
//            }
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = new int[10];

//        // Array-i doldurmaq
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write($"Ədəd {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int cutSayi = 0, tekSayi = 0, menfiSayi = 0;
//        int enBoyuk = arr[0];

//        foreach (int eded in arr)
//        {
//            if (eded % 2 == 0) cutSayi++;
//            else tekSayi++;

//            if (eded < 0) menfiSayi++;

//            if (eded > enBoyuk) enBoyuk = eded;
//        }

//        Console.WriteLine($"\nCüt ədədlərin sayı: {cutSayi}");
//        Console.WriteLine($"Tək ədədlərin sayı: {tekSayi}");
//        Console.WriteLine($"Mənfi ədədlərin sayı: {menfiSayi}");
//        Console.WriteLine($"Ən böyük ədəd: {enBoyuk}");
//    }
//}
