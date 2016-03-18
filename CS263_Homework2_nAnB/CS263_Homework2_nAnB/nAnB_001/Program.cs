// 專案 Using
using Lib.BizLib;
using Lib.DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nAnB_001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入遊戲長度 (大於0且小於10的數字)");

            // Check Input
            string input = Console.ReadLine();
            int inputInt = 0;

            if (int.TryParse(input, out inputInt))
            {
                if (inputInt <= 0 || inputInt > 10)
                {
                    Console.WriteLine("輸入遊戲長度過大/過小，將以預設遊戲長度{0}進行遊戲", inputInt);
                    inputInt = 4;
                }
            }
            else
            {
                inputInt = 4;
                Console.WriteLine("輸入遊戲長度的格式錯誤，將以預設遊戲長度{0}進行遊戲", inputInt);
            }

            Console.WriteLine("遊戲開始，難度/遊戲長度 {0}", inputInt);

            // 取得亂數的 List
            nAnBNumber nAnBClass = new nAnBNumber();
            RandomBiz randomBizClass = new RandomBiz();

            nAnBClass.nAnBQuestion = randomBizClass.GenerateRandomNumber(inputInt);

            // 手動猜題開始
            // Chcek Input (沿用之前 Input 的參數)
            Console.WriteLine("請輸入您的答案，數字位數{0}", inputInt);
            inputInt = 0;

            GameBiz game = new GameBiz();
            bool result = false;

            string strResult = string.Empty;

            do
            {
                input = Console.ReadLine();

                do
                {
                    if (int.TryParse(input, out inputInt) == false)
                        Console.WriteLine("僅可輸入數字");
                    else
                    {
                        result = game.GetResult(input, nAnBClass.nAnBQuestion, out strResult);
                        Console.WriteLine(strResult);
                    }
                } while (int.TryParse(input, out inputInt) == false);
            } while (result == false);
        }
    }
}