using System;

namespace PruebaUnitaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string something()
        {
            return "algo";
        }
        public static bool LogIn(string User, string Password) => User == "Marco" && Password == "123456" ? true : false;
    }
}
