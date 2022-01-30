
//64 sayısına kadar istenilen sayıyı maksimum 6 veya daha kısa seferde seferde bulma

int tahmin,alt = 1, ust = 63, deneme_sayisi = 0;
Console.WriteLine("sayi gir : ");
int tutulan = Convert.ToInt32(Console.ReadLine());

yeniden:

tahmin = (alt + ust) / 2;
deneme_sayisi++;

if (tahmin == tutulan)
{
    Console.WriteLine("Tutulan = " + tutulan + " sayac = " + deneme_sayisi);
}
else
{ 
    if (tahmin > tutulan)
    {
    ust = tahmin;
    }
    else
    { 
    alt = tahmin;
    }
    goto yeniden;
}

Console.ReadKey();