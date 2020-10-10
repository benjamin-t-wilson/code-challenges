using System;

namespace Code_Challenges
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var EightKyu = new EightKyu();
            Console.WriteLine(EightKyu.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Console.ReadLine();
        }
    }
}