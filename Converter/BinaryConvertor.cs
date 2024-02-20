namespace BinaryConvertor;
public class BinaryConvertor
{
    
    public string Convert_decimal_number_to_binary(int decimal){

        string finalBinaryValue = "";
        int quotient;
        int remainder;

        while(remainder / 2 != 0){
            quotient = decimal / 2;
            decimal = quotient;
            finalBinaryValue += (decimal % 2).toString(); 
        }




        return "string";
    }
}