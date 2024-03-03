
using NUnit.Framework;
using Converter;

namespace ConverterTest
{
    public class BinaryConvertorTest
    {
        private BinaryConvertor _binaryConvertor;
        [SetUp]
        public void Setup()
        {
            _binaryConvertor = new BinaryConvertor();
        }
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "3")]
        [TestCase(4, "4")]
        [TestCase(5, "5")]
        [TestCase(6, "6")]

        public void WhenConverting_Numeral_To_Binary(int numeral, string binary)
        {
            var result = _binaryConvertor.Convert_decimal_number_to_binary(numeral);
            Assert.AreEqual(binary, result);
        }
    }
}
