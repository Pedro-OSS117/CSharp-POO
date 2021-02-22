using System;

namespace Exo1
{
    public class Shape
    {
        protected char mainChar = '*';

        public virtual float Area()
        {
            return 0;
        }

        public virtual float Perimeter()
        {
            return 0;
        }

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