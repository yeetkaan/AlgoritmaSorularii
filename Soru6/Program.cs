//0 - 100000 arasındaki tam kare sayıları ekrana yazdırınız.

//                OUTPUT => 2,3,4,5 …. (x’2<10000) olana kadar devam eder
for (int i = 0; i < 10000; i++)
{
    for (int j = 0;j< 10000 ; j++)
    {
        if(j == i * i)
        {
            Console.WriteLine(j);
        }
    }
   
}