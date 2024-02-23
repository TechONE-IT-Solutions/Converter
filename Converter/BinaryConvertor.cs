namespace BinaryConvertor;
public class BinaryConvertor
{
    
    public string Convert_decimal_number_to_binary(int baseTenNumber){

        string finalBinaryValue = "";

        while(baseTenNumber != 0){
            finalBinaryValue = (baseTenNumber % 2).ToString() + finalBinaryValue;
            baseTenNumber = baseTenNumber / 2;
        }




        return finalBinaryValue;
    }
}