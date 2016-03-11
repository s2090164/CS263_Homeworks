namespace Problem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// "+" 號為 int.operator，因此為 int 的 method，因此 Byte 相加就算沒有超過 255，一樣會出現轉型錯誤 (因為 int > Byte，因此將int Method得到的物件轉回為 Byte 就會出現轉型錯誤，但大於int就不會有問題)
            //// byte 為 0-255 不帶正負號的整數，為2的8次方從0開始計，因此為 0-255 (來源：MSDN Byte 結構，網址：https://msdn.microsoft.com/zh-tw/library/system.byte(v=vs.110).aspx)
            //byte number0 = 254;
            //byte number1 = number0 + 1;

            //// Byte 相加小於 255 依舊有轉型錯誤
            //byte number2 = 12;
            //byte number3 = number2 + 1;

            // 將相加後的Byte定為int即可避免錯誤
            byte number4 = 15;
            int number5 = number4 + 12;

            // 第二種解法，運算後轉型，但大於255會轉為0
            byte number6 = 15;
            byte number7 = (byte)(number6 + 240);
            System.Console.WriteLine(number7);  // 寫出255

            byte number8 = 15;
            byte number9 = (byte)(number8 + 241); // 相加大於 255
            System.Console.WriteLine(number9);  // 寫出0

            // 大於 int 就不會有問題 (浮點數要加入f 在結尾ex. 23f)
            float f1 = 23f;
            float f2 = f1 + 23f;
        }
    }
}