// Bu metod sayı asal mı değil mi onu verir.
static bool isPrime(int input)
{

    for (int i = 2; i < input; i++)
    {
        if (input % i == 0)
        {

            return false;

        }

    }

    return true;

}


// Burada 100'e kadar olan bütün sayıları tek tek kontrol ediyoruz eğer asal ise yazdırıyoruz.
for (int i = 2; i <= 100; i++)
{
    if (isPrime(i))
    { Console.WriteLine(i); }
}