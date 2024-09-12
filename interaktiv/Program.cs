using System.Xml.Serialization;

Console.WriteLine("vart vill du hälst vara i skogen eller i stor stan.");
string name = Console.ReadLine();
string Stan = Console.ReadLine();

 if (name.ToLower() == "skogen")
{
  Console.Clear();
  Console.WriteLine ("Mysss")  ; 
  Console.ReadLine();


   if (name.ToLower() == "skogen")

Console.WriteLine("Du har hamnat i en mysig skog, MEN du har hittat en person som har fått en hjärtattack, han ser ut som en rik person. Du får välja om du vill rädda den rika människan eller att råna honom.");
String hjälpa = Console.ReadLine();


if (hjälpa.ToLower() == "råna")
Console.Clear();
Console.WriteLine("Han kommer för hämnd");
Console.ReadLine();

}

Console.Clear();
Console.WriteLine("Du står vid ett övergångställe ska du gå eller stanna?");
string gå = Console.ReadLine();


if (gå.ToLower() == "gå")

{
Console.Clear();
Console.WriteLine("Du blir påkörd");
Console.ReadLine();


Console.Clear();
Console.WriteLine("försök igen");
Console.ReadLine();

}


else

{
Console.Clear();
Console.WriteLine("du träffar batman");
Console.ReadLine();
}


