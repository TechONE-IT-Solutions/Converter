using System.Text;

namespace Converter
{
    public class RomanNumeralsConverter : IConverter
    {
        static Dictionary<int, string> numeralToRomanMapping = new Dictionary<int, string>()
        {
            {1,"I" },
            {2,"II" },
            {3,"III" },
            {4,"IV" },
            {5,"V" },
            {6,"VI" },
            {7,"VII" },
            {8,"VIII" },
            {9,"IX" },
            {10,"X" },
            {15,"XV" },
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"} 
        };
        public string Result => throw new NotImplementedException();

        public string Convert(int numeral)
        {
            string numeralValue = "";
            int[] ConvertToArray = numeralToRomanMapping.Keys.ToArray();
            int InitialIndex = ConvertToArray.Length - 1;

            for (int i = InitialIndex; i >= 0; i--)
            {
                while (numeral >= ConvertToArray[i])
                {
                    numeralValue += numeralToRomanMapping[ConvertToArray[i]];
                    numeral -= ConvertToArray[i];
                }
            }
            return numeralValue;

        }
    }
}