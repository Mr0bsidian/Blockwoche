using System;
using System.Text;
using System.Threading.Tasks;

char weiter = 'w';

do
{
    double zahl1 = 0;
    double zahl2 = 0;
    double? lösung = null;
    do
    {

        if (lösung == null)
        {
            lösung = 0;
            Console.WriteLine("Erste Zahl");
            zahl1 = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Bitte Operator eingeben (/, +, -, *)");
        ConsoleKey Operator = Console.ReadKey().Key;
        Console.WriteLine();

        Console.WriteLine("Zweite Zahl");
        zahl2 = Convert.ToDouble(Console.ReadLine());

        switch (Operator)
        {

            case ConsoleKey.Divide:
                zahl1 = Dividieren(zahl1, zahl2);
                Console.WriteLine("Die Lösung ist: {0}", zahl1);
                break;

            case ConsoleKey.Add:
                zahl1= Addieren(zahl1, zahl2);
                Console.WriteLine("Die Lösung ist: {0}", zahl1);
                break;

            case ConsoleKey.Subtract:
                zahl1 = Subtraktion(zahl1, zahl2);
                Console.WriteLine("Die Lösung ist: {0}", zahl1);
                break;

            case ConsoleKey.Multiply:
                zahl1 = Multiplikation(zahl1, zahl2); ;
                Console.WriteLine("Die Lösung ist: {0}", zahl1);
                break;

            default:
                Console.WriteLine("Falsche Eingabe!");
                break;

        }
        Console.WriteLine("[W]eiter mit dem Ergebnis?, [N]eustarten? oder [B]eenden?");
        weiter = Console.ReadKey().KeyChar;
        Console.WriteLine();


    }
    while (weiter == 'w' || weiter == 'W');
}
while (weiter == 'n' || weiter == 'N');

static double Dividieren(double num1, double num2)
{
    return num1 / num2;
}
static double Addieren(double num1, double num2)
{
    return num1 + num2;
}
static double Subtraktion(double num1, double num2)
{
    return num1 - num2;
}
static double Multiplikation(double num1, double num2)
{
    return num1 * num2;
}
