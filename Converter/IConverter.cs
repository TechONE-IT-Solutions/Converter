namespace Converter
{
    public interface IConverter
    {
        public string Result { get; }

        public string Convert(int number);
    }
}