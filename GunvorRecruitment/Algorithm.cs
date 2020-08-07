using System;
using System.Collections.Generic;

namespace GunvorRecruitment
{
    public class Algorithm
    {
        public string ReverseEveryOtherWord(string inputString)
        {
            string[] a = inputString.Split(' ');

   
            string result = string.Empty;

            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (i % 2 != 0)
                {
                    char[] arr = a[i].ToCharArray();
                    Array.Reverse(arr);
                    result += new string(arr);

                }
                else
                {
                    result += a[i];
                }

               if (i != a.Length - 1) result += " ";
            }
            
            return result;
        }
    }
}