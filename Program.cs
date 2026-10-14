
void vykonajsum()
{
 Console.WriteLine("rozumiem");
 Console.Write("zadaj prve cislo: ");
 int vstup2 = int.Parse(Console.ReadLine());
  
 Console.Write("zadaj druhe cislo: ");
 int vstup3 = int.Parse(Console.ReadLine());

 int sum = vstup2 + vstup3;
 Console.WriteLine(sum);
}

void vykonajodmocnenie()
{
 Console.Write("zadaj cislo: ");
 int vstup2 = int.Parse(Console.ReadLine());
 double vysledok = Math.Sqrt(vstup2);
 Console.WriteLine(vysledok);
}

void najdivovete()
{

 Console.Write("zadaj vetu: ");
 string veta = Console.ReadLine();
 veta = veta.ToLower();
 Console.Write("zadaj co chces najst: ");
 string slovo = Console.ReadLine();
 slovo = slovo.ToLower();
 slovo.IndexOf(slovo);
 Console.WriteLine(veta.IndexOf(slovo));
 if (veta.Contains(slovo))
 {
  Console.WriteLine("veta obsahuje: " + slovo);
 }
 else
 {
  Console.WriteLine("veta neobsahuje");
 }
}



void pomozsi()
 {
  Console.WriteLine("povolene prikazy:\n" 
  +"sum - sčítanie dvoch (stačí celých) čísel\n" 
  +"odm - odmocnina zo zadaného čísla\n" 
  +"find - nájde podreťazec vo vete\n" 
  +"help - vypíše všetky podporované príkazy a čo robia\n");
 }

Console.WriteLine("ahoj ja som tvoj asistent, napisem ti s cim ti viem pomoct");
Console.WriteLine("povolene prikazy:\n" 
 +"sum \n" 
 +"odm \n" 
 +"find \n" 
 +"help \n");

Console.Write("zadaj prikaz ktory chces pouzit:"  );
string vstup1 = Console.ReadLine();
vstup1 = vstup1.ToLower();


while (vstup1 != "sum" && vstup1 != "odm" && vstup1 != "find" && vstup1 != "help")
{
 Console.WriteLine("to nie je prikaz, skus znovu");
 vstup1 = Console.ReadLine();
}
while (vstup1 != "exit")
{
 if (vstup1 == "sum")
 {
  vykonajsum();
 }
 else if (vstup1 == "odm")
 {
 vykonajodmocnenie();
 }
 
 else if (vstup1 == "find")
 {
  najdivovete();
 }
 else if (vstup1 == "help")
 {
  pomozsi();
  }
} 





