Console.WriteLine("Lütfen karakterlerin benzersiz olup olmadığını belirlemek için bir metin girin...");
string str = Console.ReadLine();
bool benzersiz = true;

for (int i = 0; i < str.Length; i++)
{
    for (int j = i + 1; j < str.Length; j++)
    {
        if (str[i] == str[j])
        {
            benzersiz = false;
            break;
        }
    }

    if (!benzersiz)
    {
        break;
    }
}

Console.WriteLine(benzersiz ? "Tüm karakterler benzersiz." : "Tüm karakterler benzersiz değil.");