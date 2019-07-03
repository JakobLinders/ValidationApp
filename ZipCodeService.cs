using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationApp
{
    public class ZipCodeService
    {
        public bool Validate(string i)
        {

            if (i == null)
                return false;

            if (i.Length == 6)
            {
                if (i.StartsWith('0'))
                    return false;
                else
                {
                    for (int a = 0; a < i.Length; a++)
                    {
                        if (a == 3)
                        {
                            if (i[a] != ' ')
                                return false;
                        }
                        else
                        {
                            if (!char.IsDigit(i[a]))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            else
                return false;
            return true;
        }
        public bool Validate_Regex(string i)
        {

            return Regex.IsMatch(i, @"[1-9]{1}[0-9]{2} [0-9]{2}$");
        }

        public int[] SlashZipCode (string zip)
        {
            if (Validate(zip))
            {
                string[] stringArray = zip.Split(' ');

                int[] array = new int[] { int.Parse(stringArray[0]), int.Parse(stringArray[1]) };
                return array;
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
}
