using System;

namespace CSharpFundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We have a promotion going on!");
                    break;

                default:
                    Console.WriteLine("I don't understand what season it is.");
                    break;
            }
        }
    }
}