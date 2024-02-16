// See https://aka.ms/new-console-template for more information
using Converter;

Console.WriteLine("Convert a number choose the following: \n" +
    "1 Roman Numeral \n" +
    "2 Binary");
string data = Console.ReadLine();
int choice = Convert.ToInt16(data);

Console.WriteLine("Enter number:");
string number = Console.ReadLine();
IConverter con = null;
if (choice == 1)
{
    con = new RomanNumeralsConverter();
}
else if (choice == 2)
{
    con = new BinaryConverter();

}
string result = con.Convert(Convert.ToInt16(number));



Console.WriteLine($"The roman numeral number is {result}");



