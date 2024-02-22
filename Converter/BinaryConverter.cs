using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class BinaryConverter : IConverter
    {
        public string Result => throw new NotImplementedException();

        public string Convert(int number)
        {
            string binaryNumber = "";
            while (number > 0)
                {
                    int remainder = number % 2;
                    binaryNumber = remainder + binaryNumber;
                    number /= 2;
                }
            return binaryNumber;
        }

        protected int dotnotCover()
        {
            return 0;
        }
    }
}
