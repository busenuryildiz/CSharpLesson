internal class Program
{
    static void Main(string[] args)
    {

        //    Armstrong Sayı Nedir? N haneli bir sayının basamaklarının n'inci üstlerinin toplamı,
        //   sayının kendisine eşitse, böyle sayılara Armstrong sayı denir.Örneğin 407 sayısını ele alalım.
        //  (4 ^ 3) + (0 ^ 3) + (7 ^ 3) = 64 + 0 + 343 = 407 sonucunu verir. Bu da 407 sayısının armstrong bir sayı olduğunu gösterir.



        //          Console.Write("Sayı Giriniz: ");
        //        int sayi = Convert.ToInt32(Console.ReadLine()); //407
        //        int uzunluk = sayi.ToString().Length;  //3
        //        int baslangic = sayi; //407
        //        int toplam = 0;
        //        while (sayi != 0)
        //        {
        //            int basamak = sayi % 10; //7     //0
        //            toplam += Convert.ToInt32(Math.Pow(basamak, uzunluk)); //7^3     0^3
        //            sayi /= 10; //40  0
        //        }
        //        if (toplam == baslangic)
        //            Console.WriteLine("Sayı Armstrong Sayıdır");
        //        else
        //            Console.WriteLine("Sayı Armstrong Sayısı Değildir");
        //    }

        //}


        IsArmstrong(750);
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (IsArmstrong(sayi))
        {
            Console.WriteLine(sayi + " bir Armstrong sayısıdır.");
        }
        else
        {
            Console.WriteLine(sayi + " bir Armstrong sayısı değildir.");
        }
    }

    // Bir sayının Armstrong sayısı olup olmadığını kontrol eden fonksiyon
    static bool IsArmstrong(int num)
    {
        int originalNum = num;
        int basamakSayisi = 0;
        double toplam = 0;

        // Sayının basamak sayısını bulma
        while (originalNum != 0)
        {
            originalNum /= 10; //75  //7
            basamakSayisi++; //1 //2
        }

        originalNum = num; //7

        // Her basamağın n'inci üssünü alıp toplama ekleme
        while (originalNum != 0)
        {
            int basamak = originalNum % 10;
            toplam += Math.Pow(basamak, basamakSayisi);
            originalNum /= 10;
        }

        // Sayı, toplamın kendisine eşit olup olmadığını kontrol etme
        return num == (int)toplam;
    }
}
