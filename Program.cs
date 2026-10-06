

Console.WriteLine("ahoj ja som tvoj asistent, napisem ti s cim ti viem pomoct");
Console.WriteLine("povolene prikazy:\n" 
 +"sum - sčítanie dvoch (stačí celých) čísel\n" 
 +"odm - odmocnina zo zadaného čísla\n" 
 +"find - nájde podreťazec vo vete\n" 
 +"help - vypíše všetky podporované príkazy a čo robia\n");

Console.Write("zadaj prikaz ktory chces pouzit:"  );
string vstup1 = Console.ReadLine();
while (vstup1 != "exit")
{
 if (vstup1 == "sum")
 {
  Console.WriteLine("rozumiem");
  Console.Write("zadaj prve cislo: ");
  int vstup2 = int.Parse(Console.ReadLine());
  
  Console.Write("zadaj druhe cislo: ");
  int vstup3 = int.Parse(Console.ReadLine());

  int sum = vstup2 + vstup3;
  Console.WriteLine(sum);
 }
 else if (vstup1 == "odm")
 {
  Console.Write("zadaj cislo: ");
  int vstup2 = int.Parse(Console.ReadLine());
   vstup2 = Math.Sqrt()
 }
 
 else if (vstup1 == "find")
 {
  Console.Write("zadaj vetu: ");
  string vstup2 = Console.ReadLine();

  Console.Write("zadaj co chces najst: ");
  string vstup3 = Console.ReadLine();
 }
 else if (vstup1 == "help")
  Console.WriteLine(("povolene prikazy:\n" 
                     +"sum - sčítanie dvoch (stačí celých) čísel\n" 
                     +"odm - odmocnina zo zadaného čísla\n" 
                     +"find - nájde podreťazec vo vete\n" 
                     +"help - vypíše všetky podporované príkazy a čo robia\n"););
 {
 }
}
 





