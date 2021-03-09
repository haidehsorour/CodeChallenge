using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            var arrayOfValue = s.ToCharArray();
            var lengthOfValue = arrayOfValue.Length - 1;
            var start = 0;
            while (start <= lengthOfValue)
            {
                var tmp = arrayOfValue[start];
                arrayOfValue[start] = arrayOfValue[lengthOfValue];
                arrayOfValue[lengthOfValue] = tmp;
                lengthOfValue--;
                start++;
            }

            return string.Join(null, arrayOfValue);
        }
    }
}
