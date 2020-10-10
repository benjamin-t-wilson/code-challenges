﻿using System.Linq;

namespace Code_Challenges
{
    public class EightKyu
    {
        public int[] InvertValues(int[] input)
        {
            //https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/train/csharp
            //Given a set of numbers, return the additive inverse of each.Each positive becomes negatives, and the negatives become positives.
            //invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
            //invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
            //invert([]) == []
            //Code it!

            return input.Select(n => -n).ToArray();
        }

        public static string sayMeOperations(string stringNumbers)
        {
            //https://www.codewars.com/kata/5b5e0c0d83d64866bc00001d/train/csharp
            //You have a string of numbers; starting with the third number each number is the result of an operation performed using the previous two numbers.

            //Complete the function which returns a string of the operations in order and separated by a comma and a space, e.g. "subtraction, subtraction, addition"

            //The available operations are(in this order of preference):

            //1) addition
            //2) subtraction
            //3) multiplication
            //4) division
            //Notes:

            //All input data is valid
            //The number of numbers in the input string >= 3
            //For a case like "2 2 4" - when multiple variants are possible -choose the first possible operation from the list (in this case "addition")
            //Integer division should be used
            //Example
            //"9 4 5 20 25"-- > "subtraction, multiplication, addition"
            //Because:

            //9 - 4 = 5-- > subtraction
            //4 * 5 = 20-- > multiplication
            //5 + 20 = 25-- > addition


            // :) ...
            return "";
        }
    }
}