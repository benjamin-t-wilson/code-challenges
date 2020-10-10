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
    }
}