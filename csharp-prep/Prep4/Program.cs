using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        // initial prompt
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // needed variables
        int userNumber = -1;
        int sum = 0;
        float average;
        int max = 0;

        // create a number list
        List<int> numberList = new List<int>();

        while (userNumber != 0){
            // user input
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            // insert user input into the number list
            if (userNumber != 0){
                numberList.Add(userNumber);
            }
        }

        // add number list
        foreach (int number in numberList){
            sum += number;
        }
        // display sum
        Console.WriteLine($"The sum is: {sum}");

        // get the average of the number list
        average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is: {average}");

        // get the max of the list
        foreach (int number in numberList){
            if (number > max){
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}