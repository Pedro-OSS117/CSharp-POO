namespace Exo2
{
    public abstract class Document
    {
        private int _registerNumber;

        private string _title;

        public Document(int registerNumber, string title)
        {
            _registerNumber = registerNumber;
            _title = title;
        }
    }
}