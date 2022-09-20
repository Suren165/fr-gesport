Console.WriteLine("Hej Välkommen till frågesport som handlar om Fotboll");
Console.WriteLine("Regler, Du får 3 val och du ska skriva antigen 1,2 eller 3 en av dom kommer vara rätt får du fel får du 0 poäng får du rätt får du poäng");


Console.WriteLine("");
int poäng = 0;

Console.WriteLine(" Vem är den mest berömda fotbolls spelare genom tiderna");
Console.WriteLine(" 1) Cristiano Ronaldo Fotbollsspelare 2) Lionel Messi 3) Pele ");

string svar1 = "";

while (svar1 != "1" && svar1 != "2" && svar1 != "3")
{
    svar1 = Console.ReadLine();
    if( svar1 != "1"|| svar1 != "2" || svar1 != "3")
    {
       Console.WriteLine(" Försök igen du måste välja mellan svar 1,2 eller 3!");
    }
}

if (svar1 == "1")
{
    poäng++;
    Console.WriteLine("Du fick rätt svar");
}

else

{
    Console.WriteLine("Du fick fel svar");
}



Console.Clear();
Console.WriteLine(" Vilken klubb har flest Champions League geonom historien");
Console.WriteLine(" 1) Real Madrid 2) Fc barcelona 3) Manchester United FC");
string svar2 = "";
while (svar2 != "1" && svar2 != "2" && svar2 != "3")
{
    svar2 = Console.ReadLine();
    if( svar2 != "1"|| svar2 != "2" || svar2 != "3")
    {
       Console.WriteLine(" Försök igen du måste välja mellan svar 1,2 eller 3!");
    }
}


if (svar2 == "1")
{
    poäng++;
    Console.WriteLine("Grattis du fick poäng");
}

else
{
    Console.WriteLine(" Tyvär du fick fel svar bättre lycka nästa gång");
}


Console.Clear();
Console.WriteLine(" Vad är det längsta Svergie har kommit i Världsmästerskapet i fotboll");
Console.WriteLine(" 1) Semi-final 2) Final 3) Kvarts-final");

string svar3 = Console.ReadLine();
while (svar3 != "1" && svar3 != "2" && svar3 != "3")
{
    svar3 = Console.ReadLine();
    if( svar3 != "1"|| svar3 != "2" || svar3 != "3")
    {
       Console.WriteLine(" Försök igen du måste välja mellan svar 1,2 eller 3!");
    }
}


if (svar3 == "2")
{
    poäng++;
    Console.WriteLine("Du fick rätt grattis");
}

else
{
    Console.WriteLine(" Fel svar, Klart som fan att Sverige har kommit till finalen");
}


Console.Clear();
Console.WriteLine("År 1958 kom Sverige till finalen i Världsmästerskapet på fotboll. Vem vann år 1958");
Console.WriteLine(" 1) Brasilien 2) Sverige 3) Frankrike");
string svar4 = Console.ReadLine();
while (svar4 != "1" && svar4 != "2" && svar4 != "3")
{
    svar4 = Console.ReadLine();
    if( svar4 != "1"|| svar4 != "2" || svar4 != "3")
    {
       Console.WriteLine(" Försök igen du måste välja mellan svar 1,2 eller 3!");
    }
}



if (svar4 == "1")
{
    poäng++;
    Console.WriteLine("Du fick rätt");
}

else
{
    Console.WriteLine(" Tyvärr fel svar ");
}


Console.Clear();


Console.WriteLine($"Du fick sammanlagt så här mycket {poäng}.");

if (poäng == 4)
{
    Console.WriteLine("Du fick alla rätt ");
}

Console.WriteLine(" Tryck på enter för att avsluta spelet  ");
Console.ReadLine();
