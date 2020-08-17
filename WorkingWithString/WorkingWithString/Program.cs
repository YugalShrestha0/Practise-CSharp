using System;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            // /n- Next Line
            /*
            Console.WriteLine("Yugal\"Shrestha"); // Shrestha in next line
            String phrase = "Yugal" + "Shrestha"; // +- Add Yugal and shrestha
            Console.WriteLine(phrase.Length); // .Lenght- count character in string
            */
            String phrase1 = "Yugal Shrestha";
            // Console.WriteLine( phrase.ToUpper() ); // ToUpper- Uppercase the string
            // Console.WriteLine( phrase1.ToLower() ); // ToLower- Lowercase the string
            // Console.WriteLine(phrase1.Contains("Hello")); // Contain- it tell thai if the string have the given value. it gives in the form of T or F
            // Console.WriteLine(phrase1[6]); // it will print the index of the string
            // Console.WriteLine(phrase1.IndexOf("Shrestha")); // it will print index position of string
            Console.WriteLine(phrase1.Substring(6 , 4) ); // it will print the index position of string and further

            Console.ReadLine();
        }
    }
}
