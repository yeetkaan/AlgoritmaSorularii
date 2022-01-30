//X elemanlı bir dizinin en küçük elemanının kaçıncı sırada olduğunu gösteren uygulama.

//                INPUT => 13,2,10,4,0,3,12,44,112

//                OUTPUT => Dizinin en küçük elemanı 0 dır. Bulunduğu yer 5. Sıradır.

Console.WriteLine("X kumesi icin kac tane deger gireceginizi yaziniz");
int a = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[a];
for (int i = 0; i < a; i++)
{
    Console.WriteLine("X kumesi icin deger giriniz");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

int kucuk = sayilar[0];


for (int i = 0; i < sayilar.Length; i++)
{
    if (kucuk > sayilar[i])
    { kucuk = sayilar[i]; }

}
for (int i = 0; i < sayilar.Length; i++)
{
    if (kucuk == sayilar[i])
    {
        Console.WriteLine("En kucuk deger : " + kucuk);
        Console.WriteLine("Kumedeki sirasi : " + (i + 1));
    }
}