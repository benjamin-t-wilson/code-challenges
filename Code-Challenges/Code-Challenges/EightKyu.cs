using System.Collections.Generic;
using System.Linq;

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
            var result = "";
            var list = stringNumbers.Split(' ');

            for (int i = 1; i < list.Length - 1; i++)
            {
                if (int.Parse(list[i - 1]) + int.Parse(list[i]) == int.Parse(list[i + 1]))
                {
                    result += "addition, ";
                }
                else if (int.Parse(list[i - 1]) - int.Parse(list[i]) == int.Parse(list[i + 1]))
                {
                    result += "subtraction, ";
                }
                else if (int.Parse(list[i - 1]) * int.Parse(list[i]) == int.Parse(list[i + 1]))
                {
                    result += "multiplication, ";
                }
                else
                {
                    result += "division, ";
                }
            }

            result = result.TrimEnd(',', ' ');

            return result;
        }

        public int LongestVowel(string str)
        {
            //https://www.codewars.com/kata/59c5f4e9d751df43cf000035/train/csharp
            //The vowel substrings in the word codewarriors are o,e,a,io.The longest of these has a length of 2.Given a lowercase string that has alphabetic characters only(both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

            //Documentation:
            //Kata.Solve Method(String)
            //Returns the length of the greatest continuous vowel substring in a string.

            //Syntax

            //public static int Solve(
            //string str
            //)
            //Parameters
            //str
            //Type: System.String
            //The string to be processed.

            //Return Value
            //Type: System.Int32
            //The length of the greatest continuous vowel substring in str, or 0 if str contains no vowels.

            //Exceptions
            //Exception   Condition
            //ArgumentNullException   str is null.

            //Good luck!
            var max = 0;
            var current = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    current += 1;
                    if (current > max)
                    {
                        max = current;
                    }
                }
                else
                {
                    current = 0;
                }
            }

            return max;

            //better solution
            //char[] chrs = new char[] { 'a', 'e', 'u', 'i', 'o' };
            //var split = str.Split(str.Where(c => !chrs.Contains(c)).ToArray());
            //return split.Max(s => s.Length);
        }

        public static int[][] MatrixAddition(int[][] a, int[][] b)
        {
            //https://www.codewars.com/kata/526233aefd4764272800036f/train/csharp
            //Write a function that accepts two square matrices(N x N two dimensional arrays), and return the sum of the two. Both matrices being passed into the function will be of size N x N(square), containing only integers.

            //How to sum two matrices:

            //Take each cell[n][m] from the first matrix, and add it with the same[n][m] cell from the second matrix.This will be cell[n][m] of the solution matrix.

            //Visualization:

            //| 1 2 3 |     | 2 2 1 |     | 1 + 2 2 + 2 3 + 1 |     | 3 4 4 |
            //| 3 2 1 |  +  | 3 2 3 |  =  | 3 + 3 2 + 2 1 + 3 |  =  | 6 4 4 |
            //| 1 1 1 |     | 1 1 3 |     | 1 + 1 1 + 1 1 + 3 |     | 2 2 4 |
            //TODO
            var size = a.Length;
            var c = new int[size][];
            c = b;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    c[x][y] = a[x][y] + b[x][y];
                }
            }

            return c;
        }

        public int DoubleInteger(int n)
        {
            //https://www.codewars.com/kata/53ee5429ba190077850011d4/train/csharp
            //    Code as fast as you can! You need to double the integer and return it.

            //Double the input!

            return n * 2;
        }
    }
}