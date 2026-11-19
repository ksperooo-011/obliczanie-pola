static double Kolo(int r) => 3.14 * r * r;
static double Trojkat(int a, int h) => (a * h) / 2.0;
static int Kwadrat(int a) => a * a;
static int Prostokat(int a, int b) => a * b;
static int Silnia(int a)
{
    int wynik = 1;
    for (int i = 1; i <= a; i++)
    {
        wynik *= i;
    }
    return wynik;
}
Console.WriteLine("wybierz");
Console.WriteLine("1 - kolo");
Console.WriteLine("2 - trojkat");
Console.WriteLine("3 - kwadrat");
Console.WriteLine("4 - prostokat");
Console.WriteLine("5 - silnia");
string wybor = Console.ReadLine();
int a, b;
if (wybor == "1")
{
    if (int.TryParse(Console.ReadLine(), out a))
        Console.WriteLine("pole kola" + Kolo(a));
}
else if (wybor == "2")
{
    if (int.TryParse(Console.ReadLine(), out a))
    {
        if (int.TryParse(Console.ReadLine(), out b))
            Console.WriteLine("pole trojkata" + Trojkat(a, b));
    }
}
else if (wybor == "3")
{
    if (int.TryParse(Console.ReadLine(), out a))
        Console.WriteLine("pole kwadratu" + Kwadrat(a));
}
else if (wybor == "4")
{
    if (int.TryParse(Console.ReadLine(), out a))
    {
        if (int.TryParse(Console.ReadLine(), out b))
            Console.WriteLine("pole prostkata" + Prostokat(a, b));
    }
}
else if (wybor == "5")
{
    if (int.TryParse(Console.ReadLine(), out a))
        Console.WriteLine("silnia" + Silnia(a));
}
else
{
    Console.WriteLine("blad");
}
//Kacper//Michalski//
////////1ap//////////