using Lib.BizLib;

// 解新產生的 Using
using Lib.DataLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nAnB_002
{
    public partial class Form1 : Form
    {
        // 電腦出題
        private static List<int> listAnswer;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// WebForm Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblWarrning.Text = string.Empty;
            RandomBiz ranBiz = new RandomBiz();
            listAnswer = ranBiz.GenerateRandomNumber(4);
        }

        /// <summary>
        /// 按下重新出題的按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReNew_Click(object sender, EventArgs e)
        {
            lblWarrning.Text = string.Empty;
            RandomBiz ranBiz = new RandomBiz();
            listAnswer = ranBiz.GenerateRandomNumber(4);
        }

        /// <summary>
        /// 提交答案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            // 資料整理、轉型與檢核
            string strAnswer = txtAnswer.Text;
            int intTmp = 0;
            if ((strAnswer.Length > 4 || strAnswer.Length <= 0) || Int32.TryParse(strAnswer, out intTmp) == false)
            {
                lblWarrning.Text = "答案限 1-4 位數的數字";
                return;
            }

            lblWarrning.Text = string.Empty;

            // 取得遊戲結果
            GameBiz bizGame = new GameBiz();
            string strResult = string.Empty;
            bool result = bizGame.GetResult(strAnswer, listAnswer, out strResult);

            lblWarrning.Text = strResult;
        }
    }
}