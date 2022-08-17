// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string userInput = "";
IsPalindrome pd = new IsPalindrome();
Console.WriteLine("Enter a palindrome, or not..");

Regex reg = new Regex(@"\s+");
string RemoveWhitespace(string input, string replacement)
{
    return reg.Replace(input, replacement);
}

userInput = RemoveWhitespace(Console.ReadLine(), "");

if (Int32.TryParse(userInput, out int number))
{
    Console.WriteLine("Result is " + pd.Check(number));
}
else
{
    Console.WriteLine("Result is " + pd.Check(userInput));
}


class IsPalindrome
{
    public bool Check(string myString)
    {
        if (myString.SequenceEqual((myString.Reverse())))
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }
    public bool Check(int myInt)
    {
        if (myInt.ToString().SequenceEqual(myInt.ToString().Reverse()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}