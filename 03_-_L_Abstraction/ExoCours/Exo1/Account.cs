namespace Exo1
{
    public abstract class Account
    {
        protected int _number;

        protected string _nameOwner;

        protected float _solde;

        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _number = value;
            }
        }

        public string NameOwner
        {
            get { return _nameOwner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _nameOwner = "No Name";
                }
                else
                {
                    _nameOwner = value;
                }
            }
        }

        public float Solde
        {
            get { return _solde; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _solde = value;
            }
        }

        public Account()
        {
            Number = 0;
            NameOwner = "";
            Solde = 0;
        }

        public Account(int number, string nameOwner, float solde)
        {
            Number = number;
            NameOwner = nameOwner;
            Solde = solde;
        }
    }
}