using System.Text

namespace Converter
{
    public class RomanNumeralsConverter
    {

         public string Convert(int numeral)
        {

         if (numeral < 1 || numeral > 200)
     throw new ArgumentOutOfRangeException(nameof(numeral), "The Testcase is out of range");
           
        Dictionary<int, string> numeralToRomanMapping = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
        return CreateRomanNumeralString(numeral, numeralToRomanMapping);
    /*    public RomanNumeralsConverter()
        {
        } */
            //return numeralToRomanMapping[numeral];

        }

        private string CreateRomanNumeralString(int numeral, Dictionary<int, string> numeralToRomanMapping)
        { 
            var result = new StringBuilder();
            foreach (var entry in numeralToRomanMapping)
            {
                while (numeral >= entry.Key)
                {
                    result.Append(entry.Value);
                    numeral -= entry.Key;
                }
            }
            return result.ToString();

    }
}