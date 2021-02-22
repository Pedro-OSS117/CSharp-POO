using System;

namespace Exo1
{
    public abstract class Shape
    {
        protected char mainChar = '*';

        public abstract float Area();

        public abstract float Perimeter();

        // Fonction generique de creation de ligne avec le même caractère.
        protected string ToStringLineChar(int numberLineChar, char symbol)
        {
            string line = "";
            for (int i = 0; i < numberLineChar; i++)
            {
                line += symbol;
            }
            return line;
        }
        

        protected string DisplayLineVraiCarre(int sizeLine)
        {
            string toDisplay = mainChar.ToString();
            for (int j = 1; j <= sizeLine + 1; j++)
            {
                toDisplay += " " + mainChar;
            }
            return toDisplay;
        }

        public virtual string DisplayShape()
        {
            return "";
        }
    }
}