using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BizLib
{
    public class GameBiz
    {
        /// <summary>
        /// Check 輸入數字是否全對且位置無誤，並 Console Write nAnB
        /// </summary>
        /// <param name="input">輸入數字</param>
        /// <returns>全對/有錯</returns>
        public bool GetResult(string input, List<int> question, out string strReult)
        {
            bool result = false;

            int[] intTmp = new int[question.Count()];
            int i = 0;

            foreach (char item in input)
            {
                intTmp[i] = Int32.Parse(item.ToString());
                i++;
            }

            i = 0;
            int nA = 0;
            int nB = 0;

            for (int j = 0; j < intTmp.Length; j++)
            {
                // 用 List Contain 來算 B
                if (question.Contains(intTmp[j]))
                    nB++;

                // 用是否等於來算 A
                if (intTmp[j] == question[j])
                    nA++;
            }

            if (nA == nB && nA == question.Count())
            {
                result = true;
                strReult = string.Format("{0}A{0}B，恭喜您答對了", nA);
            }
            else
            {
                result = false;
                strReult = string.Format("{0}A{1}B，好可惜喔，再試一次吧", nA, nB);
            }

            return result;
        }
    }
}