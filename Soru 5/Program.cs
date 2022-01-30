//Cümle içerisinde geçen kelimelerin 1’den fazla olanların sayısını çıkarma

//                INPUT => Asla hiç bir zaman asla deme ki ; hiç bir zaman nolacağı belli olmaz (Farazi bir cümle 😊 )

//                OUTPUT => hiç = 2

//                          Bir = 2
string cumle;
Console.Write("Cumleyi Girin : ");
cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(' ');


for (int i = 0; i < kelimeler.Length; i++)
{
    string kelime1 = kelimeler[i];
    int toplam = 1;


    for (int j = i + 1 ; j < kelimeler.Length; j++)
    {
        string kelime2 = kelimeler[j];
         
        if (kelime1 == kelime2)
        {
            toplam++;

        }
    }

    if (toplam > 1)
    {
        Console.WriteLine(kelimeler[i]+ " = " + toplam);
        
    }
    
}
