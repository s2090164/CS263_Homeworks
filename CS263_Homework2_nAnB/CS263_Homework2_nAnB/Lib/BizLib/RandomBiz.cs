using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BizLib
{
    public class RandomBiz
    {
        /// <summary>
        /// 產生0到9的不重複亂數，將其置入到 List<int> 後 Return
        /// </summary>
        /// <param name="listCount">List長度，不可大於10</param>
        /// <returns>0到9的不重複亂數的 int List</returns>
        public List<int> GenerateRandomNumber(int listCount)
        {
            List<int> result = new List<int>();

            Random rnd = new Random();

            do
            {
                int tmp = rnd.Next(0, 10);

                if (result.Count > 1)
                {
                    if (result.Contains(tmp) == false)
                    {
                        result.Add(tmp);
                    }
                }
                else
                    result.Add(tmp);
            } while (result.Count < listCount);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            return result;
        }
    }
}