using System;
using System.Collections.Generic;

namespace Exercises
{
    public class RecursionLib {

        public int FactorialRec(int num, int ans = 1) {

            if (num == 0) {
                return ans;
            }

            return FactorialRec(num-1, ans*num);
            // return num*FactorialRec(num-1)
        }

        /// <summary>
        /// Creates a list of numbers from 1 to num.  Initialise numsList with empty List.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="numsList"></param>
        /// <returns></returns>
        public List<int> CountRec(int num, List<int> numsList) {
            //return new List<int>();
            List<int>list1= new List<int>();
            for(int i=1;i<=num;i++)
            {
                list1.Add(i);
            }
            return list1;
        }

        /// <summary>
        /// Returns the result of num to the power of pow.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="pow"></param>
        /// <param name="ans"></param>
        /// <returns></returns>
        public long ExponentialRec(int num, int pow, long ans = 1) {
            //return 1;
            Int64 startnum = num;
            Int64 num64 = num;
            for (int i = 1; i < pow; i++)
            {
                num64 = num64 * startnum;
            }
            return num64;
        }

        /// <summary>
        /// Returns word (string) in reverse order.  Treats all characters the same.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="revWord"></param>
        /// <returns></returns>    
        public string WordReverseRec(string word, string revWord = "") {
            //return "";
            string result = "";
            word.ToCharArray();
            for (int i=word.Length;i>0;i--)
            {
                result = result + word[i-1];
            }
            return result;
        }



    }
}
