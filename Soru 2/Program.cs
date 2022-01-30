//Kelime duplicate karakterlerin sayısını bulma

//INPUT => Bir saat sonra bütün görevlerimi JIRA üzerinden “successfully” olarak çevireceğim

//OUTPUT => “aa”,”cc”,”ss”,”ll”
string kelime;
Console.Write("Kelime Girin : ");
kelime = Console.ReadLine();
char[] kelimeler = kelime.ToArray();


for (int i = 0; i < kelimeler.Length; i++)
{
 
    if(i == kelimeler.Length-1)
    {
        break;
    }
    if(kelimeler[i] == kelimeler[i + 1])
    {
        Console.Write(kelimeler[i]);
        Console.Write(kelimeler[i]);
        Console.WriteLine("\n");
    }
  
}


