using System;

namespace ValidationApp
{
    class Program
    {
        static string inp;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Zipcode:");
                inp = Console.ReadLine();


                var zz = new ZipCodeService();
                bool isValid = zz.Validate(inp);
                if (isValid)
                {
                    Console.WriteLine("Zip code is valid. Well done!");
                }
                else
                {
                    Console.WriteLine("Zip code is invalid. You Suck!");
                }
            }
        }

    }
}
