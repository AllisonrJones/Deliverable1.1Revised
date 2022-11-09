using System;
using Internal;

public class Program
{
    public static void Main()
    {
        bool boolToReturn = true;


        Console.WriteLine
            ("How many peanut butter and jelly sandwiches are needed");

        string input = Console.ReadLine();
        int number;
        int.TryParse(input, out number);
        int slices = number * 2;
        int PB = number * 2;
        int Jelly = number * 4;
        Console.WriteLine("Slices of bread:");
        Console.WriteLine(slices);
        Console.WriteLine("TBSP of peanutbutter:");
        Console.WriteLine(PB);
        Console.WriteLine("tsp of jelly:");
        Console.WriteLine(Jelly);

        decimal loafs = (slices / 28);
        loafs = Math.Ceiling(loafs);
        decimal JOPB = PB / 32;
        JOPB = Math.Ceiling(JOPB);
        decimal JoJelly = Jelly / 48;
        JoJelly = Math.Ceiling(JoJelly);




        Console.WriteLine("You will need" + loafs + "loafs of bread");
        Console.WriteLine(JOPB + "Jars of peanutbutter");
        Console.WriteLine("and" + JoJelly + "jars of Jelly");

        Console.WriteLine("Would you like to calculate for a different number");
        while (true)
        {
            string ans = Console.ReadLine();
            if (ans != null && ans == "y")
            {
                boolToReturn = true;
                break;
            }
            else if (ans != null && ans == "n")
            {
                boolToReturn = false;
                break;
            }
            else
            {
                Console.Write("Only y or n Allowed");
                return boolToReturn;
            }
        }

    }


}
