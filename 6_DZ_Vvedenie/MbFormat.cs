using System;
using System.Collections.Generic;
using System.Text;

namespace _6_DZ_Vvedenie
{
    class MbFormat
    {

        public static string FormatToMb(long mb)
        {
            string strMb = (mb / 1024).ToString();
            string result = "";
            for (int i = 0; i < strMb.Length; i++)
            {
                if ((strMb.Length - i) % 3 == 0 && i != 0)
                {
                    result += " " + strMb[i];
                   
                }
                else result += strMb[i];
            }
            return result;
        }
    }
}
