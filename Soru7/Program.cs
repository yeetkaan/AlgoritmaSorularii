//Fibonacci serisinin ilk 10 sayısının ekrana basımını yazınız

//                OUTPUT => , 1, 1, 2, 3, 5, 8, 13, 21, 34S
int sayi1 = 1, sayi2 = 1, sayi3;

Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

for (int i = 3; i <= 10; i++)
{

    sayi3 = sayi1 + sayi2;
    Console.WriteLine(sayi3);
    sayi1 = sayi2;
    sayi2 = sayi3;

}

Console.ReadKey();