namespace Converter
{
    public class RomanNumeralsConverter
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
            {20,"XX" }
        };

        public RomanNumeralsConverter()
        {
        }

        public string Convert(int numeral)
        {
            return numeralToRomanMapping[numeral];

        }















        static object[][] HakimJaggedArray = new object[][]
            {
                new object[] {1000, "M"},
                new object[] {900, "CM"},
                new object[] {500, "D"},
                new object[] {400, "CD"},
                new object[] {100, "C"},
                new object[] {90, "XC"},
                new object[] {50, "L"},
                new object[] {40, "XL"},
                new object[] {10, "X"},
                new object[] {9, "IX"},
                new object[] {5, "V"},
                new object[] {4, "IV"},
                new object[] {3, "III"},
                new object[] {2, "II"},
                new object[] {1, "I"}
            };

        public string Hakim_Convert(int number){
            // A vairiable to hold the final roman numeral
            string RomanValue = "";

            // A varaible to iterate through the numeric values
            int i = 0;

            while (number > 0){
            if(number - (int)HakimJaggedArray[i][0] >= 0){
                    number -= (int)HakimJaggedArray[i][0];
                    RomanValue += (string)HakimJaggedArray[i][1];
            }
            else{
                i++;
            }
        }
        return RomanValue;
        }
    }
}