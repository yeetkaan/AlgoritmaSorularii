//Sıcaklık birimi hesaplama =>
//QUESTION
//Sıcaklık Birimi seçiniz: Kelvin,Celcius,Fahrenheit => K
//Sıcaklığı giriniz => 273
//ANSWER => 0 C , 31.73 F

string opt;
decimal derece, a, b;
Console.WriteLine("\n\tMenu");
Console.WriteLine("\nSicaklik birimi secin");
Console.WriteLine("Celsius icin c tusuna basiniz");
Console.WriteLine("Kelvin icin k tusuna basiniz");
Console.WriteLine("Fahrenheit icin f tusuna basiniz");
Console.Write("\nIslem yapmak icin operator secin\t");
opt = Convert.ToString(Console.ReadLine());
Console.Write("\n\n Sicaklik giriniz : ");
derece = Convert.ToInt32(Console.ReadLine());


if(opt == "c")
{
    a = derece + 273;
    b = derece * 9 / 5 + 32;
   
    Console.WriteLine(a+"K");
    Console.WriteLine(b+"F");
}
else if (opt == "k")
{
    a = derece - 273;
    b = (derece-273) * 9 / 5 + 32 ;
    Console.WriteLine(a+"C");
    Console.WriteLine(b+"F");
}
else
{
    a = (derece - 32) * 5 / 9;
    Console.WriteLine(a + "C");
    Console.WriteLine(a + 273 + "K");
}