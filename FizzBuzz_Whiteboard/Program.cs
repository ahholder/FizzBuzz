//Write a public method accepting a number
//1. Access modifier
//2. Return type
//3. Method Name
//4. Parameters
//5. Scope
//When the number is divisible by 3, return "fizz"
//When the number is divisible by 5, return "buzz"
//When the number is divisible by both, return "fizzbuzz"
/*using System;

namespace FizzBuzz_Whiteboard 
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine(FizzBuzz(21));
            Console.WriteLine(FizzBuzz(15));
            Console.WriteLine(FizzBuzz(35));
            Console.WriteLine(FizzBuzz(17));
            Console.WriteLine(FizzBuzz(6));
            Console.ReadLine();
        }
        static string FizzBuzz(int num)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                return "fizzbuzz";
            } else if (num % 5 == 0)
            {
                return "buzz";
            } else if (num % 3 == 0)
            {
                return "fizz";
            }
            return "";
        }
    }
}*/

public string FizzBuzz(int num)
{
    if (num % 5 == 0 && num % 3 == 0)
    {
        return "fizzbuzz";
    } else if (num % 5 == 0)
    {
        return "buzz";
    } else if (num % 3 == 0)
    {
        return "fizz";
    }
    return "";
}