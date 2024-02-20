using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class BinaryConverter : IConverter
    {
        //public string Result => throw new NotImplementedException();

        public string Result { get; set; }
        public string Convert(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Number must be positive");
            }

            // 0 cases 
            if(number == 0)
            {
                return "0";
                //return Result;
            }
            //throw new NotImplementedException();

            string binary = "";
            while ( number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
                
            }

            Result = binary;
            return Result;
        }

        protected int dotnotCover()
        {
            return 0;
        }
    }
}
