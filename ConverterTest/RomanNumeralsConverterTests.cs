using NUnit.Framework;
using Converter;


namespace ConverterTest
{
    public class RomanNumeralsConverterTests
    {
        private RomanNumeralsConverter _romanNumeralsConverter;

        [SetUp]
        public void Setup()
        {
            /*
             *1 --> I
             *2 --> II
             *3 --> III
             *4 --> IV
             5 --> V
             6 --> VI
             7 --> VII
             8 --> VIII
             9 --> IX
            10 --> X

            15 --> XV

            50 --> L
            47 --> XXXXVII
            99
            100
            200
            Red Green Refactor
             */
            _romanNumeralsConverter = new RomanNumeralsConverter();
        }

        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(15, "XV")]
        public void WhenConverting_Numeral_ThenEquals_Roman(int numeral, string roman)
        {
            var result = _romanNumeralsConverter.Convert(numeral);
            Assert.AreEqual(roman, result);
        }
    }
}