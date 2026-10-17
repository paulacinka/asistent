
void vykonajsum()
{
 Console.WriteLine("rozumiem");
 Console.Write("zadaj prve cislo: ");
 string vstup = Console.ReadLine();

 if (vstup == "exit")
 {
  return;
 }

 int vstup2 = int.Parse(vstup);
  
 Console.Write("zadaj druhe cislo: ");
 int vstup3 = int.Parse(Console.ReadLine());

 int sum = vstup2 + vstup3;
 Console.WriteLine(sum);
}

void vykonajodmocnenie()
{
 Console.Write("zadaj cislo: ");
 int vstup2 = int.Parse(Console.ReadLine());
 if (vstup2 < 0)
 {
  Console.WriteLine("neda sa odmocnit zaporne cislo");
 }
 else
 {
  double vysledok = Math.Sqrt(vstup2);
  Console.WriteLine(vysledok);
 }
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

double vypocitajobsah(double a, double b)
{
 double obsah = a * b;
 return obsah;
}

double vypocitajobvod(double a, double b)
{
 double obvod = 2 * (a + b);
 return obvod;

}

double vypocitajuhlopriecku(double a, double b)
{
 double uhlopriecka = Math.Sqrt(a * a + b * b);
 return uhlopriecka;
}



string vykonajrect()

{
 Console.WriteLine("zadaj prvu stranu: ");
 double a = double.Parse(Console.ReadLine());
 
 Console.WriteLine("zadaj druhu stranu: ");
 double b = double.Parse(Console.ReadLine());
 while (a <= 0 || b <= 0)
 {
  Console.WriteLine("strany musia byt vacsie ako 0");

  Console.WriteLine("zadaj prvu stranu: ");
  a = double.Parse(Console.ReadLine());

  Console.WriteLine("zadaj druhu stranu: ");
  b = double.Parse(Console.ReadLine());
 }
 
 Console.WriteLine("co chces vypocitat? ");
 string vstup = Console.ReadLine();
 vstup = vstup.ToLower();

 while (vstup != "exit")
 {
  if (vstup == "area")
  {
   Console.WriteLine(vypocitajobsah(a,b));
  } else if (vstup == "perimeter")
  {
   Console.WriteLine(vypocitajobvod(a, b));
  } else if (vstup == "diagonal")
  {
   Console.WriteLine(vypocitajuhlopriecku(a, b));
  }
  else
  {
   Console.WriteLine("to nie je prikaz, skus znovu");
  }
  Console.WriteLine("co chces pocitat dalej? ");
  vstup = Console.ReadLine();
  vstup = vstup.ToLower();
 }

 return vstup;

}


string vykonajarray()
{ Console.WriteLine("zadaj cisla oddelene medzerami:");
 string vstup = Console.ReadLine();

 string[] casti = vstup.Split(' ');

 int[] cisla = new int[casti.Length];

 for (int i = 0; i < casti.Length; i++)
 {
  cisla[i] = int.Parse(casti[i]);
 }
 Console.WriteLine("co chces urobit s polom?");
 string vstup2 = Console.ReadLine();
 vstup2 = vstup2.ToLower();
 while (vstup2 != "exit")
 {
  if (vstup2 == "min")
  {
   int najmensie = cisla[0];
   for (int i = 0; i < casti.Length; i++)
   {
    if (cisla[i] < najmensie)
    {
     najmensie = cisla[i];
    }
   }

   Console.WriteLine("najmensie cislo je: " + najmensie);
  }
else if (vstup2 == "find")
{
 Console.WriteLine("ake cislo chces najst?");
 int hladane = int.Parse(Console.ReadLine());
 int pozicia = -1;
 for (int i = 0; i < cisla.Length; i++)
 {
  if (cisla[i] == hladane && pozicia == -1)
  {
   pozicia = i + 1;
  }
 }

 if (pozicia == -1)
 {
  Console.WriteLine("cislo sa nenaslo");
 }
 else
 {
  Console.WriteLine("cislo je na pozicii: " + pozicia);
 }
}
else if (vstup2 == "sort")
{
 Array.Sort(cisla);

 Console.WriteLine("zoradene cisla:");
 for (int i = 0; i < cisla.Length; i++)
 {
  Console.Write(cisla[i] + " ");
 }

 Console.WriteLine();
}
else
 {
  Console.WriteLine("to nie je prikaz, skus znovu");
 }
  
  Console.WriteLine("co chces urobit dalej?");
  vstup2 = Console.ReadLine();
  vstup2 = vstup2.ToLower();
 }
 return vstup2;
 
}


void pomozsi()
 {
  Console.WriteLine("povolene prikazy:\n" 
  +"sum - sčítanie dvoch (stačí celých) čísel\n" 
  +"odm - odmocnina zo zadaného čísla\n" 
  +"find - nájde podreťazec vo vete\n" 
  +"help - vypíše všetky podporované príkazy a čo robia\n"
  +"rect - zapne mod merania obdlznika (area, perimeter, diagonal)\n" 
  +"array - zapne mod prace s cislami (find, min, sort))\n"
  + "exit - ukonci program\n");
 }

Console.WriteLine("ahoj ja som tvoj asistent, napisem ti s cim ti viem pomoct");
Console.WriteLine("povolene prikazy:\n" 
 +"sum \n" 
 +"odm \n" 
 +"find \n" 
 +"help \n"
 +"rect\n"
 +"array\n"
 +"exit\n");

Console.Write("zadaj prikaz ktory chces pouzit:"  );
string vstup1 = Console.ReadLine();
vstup1 = vstup1.ToLower();


while (vstup1 != "exit")
{
 while (vstup1 != "sum" && vstup1 != "odm" && vstup1 != "find" && vstup1 != "help" 
        && vstup1 != "rect" && vstup1 != "array" && vstup1 != "exit")
 {
  Console.WriteLine("to nie je prikaz, skus znovu");
  vstup1 = Console.ReadLine();
  vstup1 = vstup1.ToLower();
 } 
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
else if (vstup1 == "rect")
{
 vstup1 = vykonajrect();
}
else if (vstup1 == "array")
{
 vstup1 = vykonajarray();
}

 if (vstup1 != "exit")
 {
  Console.WriteLine("zadaj dalsi prikaz: ");
  vstup1 = Console.ReadLine();
  vstup1 = vstup1.ToLower();
 }
} 





