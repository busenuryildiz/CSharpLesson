int kolonSayisi;
Console.Write("Kolon Sayisi Giriniz...");
kolonSayisi = int.Parse(Console.ReadLine()); // Kullanıcıdan bir kolon sayısı alıyoruz.

int[] column = new int[6]; // 
if (kolonSayisi > 0 && kolonSayisi <= 8) // Kullanıcıdan aldığımız veriyi kontrol ediyoruz.
{
    Random rnd = new Random(); // Random sınıfı oluşturuyoruz.
    for (int i = 0; i < kolonSayisi; i++) // Kolon sayısı kadar çeviriyoruz.
    {
        for (int j = 0; j < column.Length; j++)// Column uzunluğu kadar çeviriyoruz ve random sayı üretiyoruz.
        {
            int number = rnd.Next(1, 49); // 1-49 arası bir sayı üretiliyor.
            while (column.Contains(number)) // Üretilen sayı column'da kontrol ediliyor. Aynı sayı gelmesini önlüyor.
            {
                number = rnd.Next(1, 49); // Yeni bir sayı tekrardan üretiliyor.
            }
            column[j] = number;
        }
        Console.Write((i + 1) + ". column: ");
        Array.Sort(column);
        foreach (int k in column)
        {
            Console.Write(k + ",");

        }
        Console.WriteLine();
        Console.WriteLine("----------");
    }

}
else
{
    Console.WriteLine("Lütfen 1 ile 8 arasında bir değer giriniz..!");
}