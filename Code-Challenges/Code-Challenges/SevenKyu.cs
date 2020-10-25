using System;

namespace Code_Challenges
{
    internal class SevenKyu
    {
        public static bool Consecutive(int[] arr, int a, int b)
        {
            //https://www.codewars.com/kata/5f6d533e1475f30001e47514/train/csharp

            //You are given a list of unique integers arr, and two integers a and b. Your task is to find out whether or not a and b appear consecutively in arr, and return a boolean value(True if a and b are consecutive, False otherwise). It is guaranteed that a and b are both present in arr.
            return Array.IndexOf(arr, a) - Array.IndexOf(arr, b) == 1 || Array.IndexOf(arr, b) - Array.IndexOf(arr, a) == 1;
        }
    }
}