using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.DataLib
{
    public class nAnBNumber
    {
        /// <summary>
        /// 電腦出的隨機答案
        /// </summary>
        public List<int> nAnBQuestion;

        /// <summary>
        /// 正確答案的List
        /// </summary>
        public List<int> nAnBAnswer;

        /// <summary>
        /// 猜題過程的暫存 int List
        /// </summary>
        public List<int> nAnBGuessTmp;
    }
}