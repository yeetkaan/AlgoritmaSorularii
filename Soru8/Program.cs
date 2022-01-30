//0 - 100 arası bulunan asal olmayan sayıların toplamı
int toplam = 0;
bool asal = true;

for (int i = 2; i < 100; i++)
{
    for (int j = 2; j < i; j++)
    {
        if (i != j && i % j == 0)
        {
            asal = false;
            break;
        }
    }
    if (asal)
        toplam += i;
    asal = true;
}
Console.WriteLine(toplam);
Console.ReadKey();