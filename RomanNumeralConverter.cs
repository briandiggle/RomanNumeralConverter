using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class RomanNumeralConverter
    {
        Dictionary<int, String> formatList;
        Dictionary<int, char[]> characterList;

        public RomanNumeralConverter()
        {
            formatList = new Dictionary<int, String>    //Gives standard formats which are basically used across all powers of 10
                {   { 0, "" },
                    { 1, "{0}" },
                    { 2, "{0}{0}" },
                    { 3, "{0}{0}{0}" },
                    { 4, "{0}{1}" },
                    { 5, "{1}" },
                    { 6, "{1}{0}" },
                    { 7, "{1}{0}{0}" },
                    { 8, "{1}{0}{0}{0}" },
                    { 9, "{0}{2}" }
                };

            characterList = new Dictionary<int, char[]> // Gives the characters representing (the unit), (5x the unit) at a given power of 10
            {   { 0, new char[] { 'I', 'V' } },
                { 1, new char[] { 'X', 'L' } },
                { 2, new char[] { 'C', 'D' } },
                { 3, new char[] { 'M', '!' } },     // Only the first element of the char array will ever be used
                { 4, new char[] { '!', '!' } }      // Characters here will never be used - just needed so thousands part can look for the next element up in a consistent way
            };
        }

        private String GetNumeralPart(int input, int powerOf10)
        {
            String format = formatList[(input/(int)Math.Pow(10, powerOf10)) % 10];
            return String.Format(format, (characterList[powerOf10])[0], (characterList[powerOf10])[1], (characterList[(powerOf10+1)])[0]);
        }

        public string GetNumerals(int input)
        {
            if (input < 1)  {   throw new ArgumentException("The Romans didn't have zero or negative numbers!");    }
            if (input > 3888)   {   throw new ArgumentException("Number is too large to be represented in Roman numerals!");    }
            
            return Enumerable.Range(0, 4).Aggregate("", (currentString, nextPower) => GetNumeralPart(input, nextPower) + currentString);
        }

    }
}
