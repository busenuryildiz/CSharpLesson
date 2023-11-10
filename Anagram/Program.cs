class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen ilk kelimeyi giriniz...");
        string kelime1 = Console.ReadLine();
        Console.WriteLine("Lütfen ikinci kelimeyi giriniz...");
        string kelime2 = Console.ReadLine(); 

        if (AreAnagrams(kelime1, kelime2))
        {
            Console.WriteLine($"{kelime1} ve {kelime2} birbirinin anagramıdır.");
        }
        else
        {
            Console.WriteLine($"{kelime1} ve {kelime2} birbirinin anagramı değildir.");
        }
    }

    static bool AreAnagrams(string kelime1, string kelime2)
    {
        // Her iki kelimeyi de alfabetik sıraya diz ve karşılaştır
        char[] siraliKelime1 = kelime1.OrderBy(c => c).ToArray();
        char[] siraliKelime2 = kelime2.OrderBy(c => c).ToArray();

        // Alfabetik sıralanmış kelimelerin karakter dizilerini karşılaştır
        return new string(siraliKelime1) == new string(siraliKelime2);
    }
}
