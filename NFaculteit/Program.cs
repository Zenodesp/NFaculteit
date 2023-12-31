﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("***********************************************************************");
Console.WriteLine("Faculteit brekenaar");
Console.WriteLine("***********************************************************************");
Console.WriteLine("Van welk getal moet de faculteit berekend worden?");
int getal = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Met welke loop wilt u werken?");
Console.WriteLine("1. For-loop");
Console.WriteLine("2. While-loop");
Console.WriteLine("3. Do-While loop");
Console.WriteLine("4. Recursie");
Console.Write("Geef uw keuze in:");
char keuze = Convert.ToChar(Console.ReadLine());

long nFaculteit = 1;

int i = 1;

switch (keuze)
{
    case '1':
    // For-loop
    for (int index = getal; index > 1; index--)
    {
        nFaculteit *= index;

    }
    break;




    case '2':
    // While-loop
    
    nFaculteit = 1;
    while (i <= getal)
    {
        nFaculteit *= i;
        i++;
    }
        break;

    case '3':
        do
        {
            nFaculteit *= i;
            i++;
        } while (i <= getal);
        break;

    case '4':
        nFaculteit = berekenFaculteit(getal);
     break;


    default:
    Console.WriteLine("Dit is geen geldige keuze!");
    break;
}




Console.WriteLine(getal + "! = " + nFaculteit);

int berekenFaculteit(int getal)
{
    if (getal == 1)
    {
        return 1;
    }
    return getal * berekenFaculteit(getal - 1);
}
