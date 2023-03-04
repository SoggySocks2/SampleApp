namespace SampleApp.Library
{
    [Serializable]
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException() : base("String was in an invalid format")
        {

        }
    }
}