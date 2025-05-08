using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>(); //We use parentheses whenever we make a new object with list being the class
        float floatNum;
        float sum = 0;
        float average;
        float maxNum;

        do 
        {
            Console.Write("Enter a number: ");
            string strNumber = Console.ReadLine();
            floatNum = float.Parse(strNumber);
            if (floatNum != 0)
                numbers.Add(floatNum);
                sum += floatNum;
        } 
        while (floatNum != 0);

        //Compute sum
        Console.WriteLine($"Sum: {sum}"); 
        //Compute the average
        Console.WriteLine($"Average: {average = sum/numbers.Count}");
        //Find largest number
        Console.WriteLine(maxNum = numbers.Max());




    }
}