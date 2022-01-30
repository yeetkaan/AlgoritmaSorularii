//Bir dizinin 2. büyük elemanını bulmak

//                INPUT => 1,4,2,-1,18,221,44,123,1,33,-10

//                OUTPUT => 123
int[] dizi = new int[] { 1, 4, 2, -1, 18, 221, 44, 123, 1, 33, -10 };
int[] dizi2 = new int[10];
int buyuk = dizi[0];

for (int i = 0; i < dizi.Length; i++)
{
    if (buyuk < dizi[i])
    { buyuk = dizi[i]; }
}


dizi2 = dizi.Where(x => x != buyuk).ToArray();
int buyuk2 = dizi2[0];

for (int i = 0; i < dizi2.Length; i++)
{
    if (buyuk2 < dizi2[i])
    { buyuk2 = dizi2[i]; }
}
Console.WriteLine(buyuk2);