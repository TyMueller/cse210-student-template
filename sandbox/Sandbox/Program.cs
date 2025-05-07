using System;
using System.Globalization;
public class Book
{
    string title;
}
class Program
{
    static void Main(string[] args)
    {
        /*Have a user enter their name:

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is " + name);
        */
        /*
        //Freezing temperature checker
        int freezing = 32;

        Console.Write("What is the temperature? ");
        string current_temp_string = Console.ReadLine(); //Can only get strings returned
        int current_temp_int = int.Parse(current_temp_string);  //Convert string to integer and rename data type

        Console.WriteLine("It is " + current_temp_int + " degrees");
        Console.WriteLine($"{current_temp_int + 10} add 10 test");
        

        if (current_temp_int < freezing - 32)
        {
            Console.WriteLine("It is very VERY cold!");
        }
        else if (current_temp_int <= freezing)
        {
            Console.WriteLine("You are probably pretty cold");
        }
        */
        /*
        //Change a string to an integer using its values
        string numberString = "12";
        int numberInteger = int.Parse(numberString); //Using .toString() and .Parse() we can change variables
        Console.Write(numberInteger);
        */
        for (int x = 0; x <= 12 ; x+=2 )
        {
            Console.WriteLine(x);
        }

    }
}