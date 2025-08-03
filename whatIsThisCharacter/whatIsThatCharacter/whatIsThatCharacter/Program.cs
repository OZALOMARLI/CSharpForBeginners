using System;

namespace whatIsThisCharacter;


class Program
{
    static void Main(string[] args)
    {
        var k = (char)Console.Read();
        if (char.IsDigit(k))
        {
            Console.WriteLine("It's a number! ");
        }
        else if (char.IsLower(k))
        {
            Console.WriteLine("It's Lowercase! ");
        }
        else if (char.IsUpper(k))
        {
            Console.WriteLine("It's Uppercase! ");
        }
        else
        {
            Console.WriteLine("It's Unknown Character! ");
        }
    }
}