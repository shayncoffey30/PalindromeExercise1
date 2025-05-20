using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string palin)
        {
            if (palin == null || palin.Length == 0)
            {
                return false;

            }

            //string wordLowered = word.ToLower();
            //string backwards = "";

            //for (int i = wordLowered.Length - 1; i >= 0; i--)
            //{
            //    backwards += wordLowered[i];
            //}

            //return wordLowered == backwards;

            //if (wordLowered == backwards)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return palin.ToLower().SequenceEqual(palin.ToLower().Reverse());


        }
    }
}
