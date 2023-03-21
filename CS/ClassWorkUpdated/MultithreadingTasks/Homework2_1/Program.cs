using ExternFunctions;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Homework2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExternAreaFunctions.AreaSquare(5));
            Console.WriteLine(ExternAreaFunctions.AreaRectangular(5,6));
            Console.WriteLine(ExternAreaFunctions.AreaTriangle(5,6));
            Console.WriteLine(ExternAreaFunctions.AreaTriangle(3,4,5));

            Console.WriteLine(ExternTextFunctions.IsTextPalindrome("mama"));
            Console.WriteLine(ExternTextFunctions.CountSentences("Forefathers, one and all! Bear witness!"));
            Console.WriteLine(ExternTextFunctions.ReverseText("amam"));

            Console.WriteLine(ExternContactFunctions.NameContainsOnlyLetters("Godrick","the","Grafted"));
            Console.WriteLine(ExternContactFunctions.AgeContainsOnlyDigits("1852"));
            Console.WriteLine(ExternContactFunctions.NumberInCorrectFormat("+380674563421"));
            Console.WriteLine(ExternContactFunctions.EmailInCorrectFormat("office_nik@itstep.org"));


            Console.ReadLine();
        }
    }
}