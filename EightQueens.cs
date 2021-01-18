using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight_Queens
{
    public enum PrintType
    {
        /// <summary>
        /// 輸出皇后位置
        /// </summary>
        Array,
        /// <summary>
        /// 輸出矩陣
        /// </summary>
        All
    }

    public class EightQueens
    {
        //有幾個皇后
        private int QueensAmount = 0;

        //保存皇后在每列的位置
        private int[] retArr = null;

        //輸出類別
        private PrintType printType;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="QueensAmount">棋盤nXn與皇后數量</param>
        /// <param name="printType">輸出模式1.Array=輸出皇后位置2.All=輸出矩陣</param>
        public EightQueens(int QueensAmount, PrintType printType)
        {
            this.QueensAmount = QueensAmount;
            this.retArr = new int[QueensAmount];
            this.printType = printType;
        }

        /// <summary>
        /// 開始執行並輸出結果
        /// </summary>
        public void Execute()
        {
            main(0);
        }

        /// <summary>
        /// 主要執行，放第N個皇后
        /// </summary>
        /// <param name="QueensCount"></param>
        private void main(int QueensCount)
        {
            //如果相等表示已把所有皇后排完
            if (QueensCount == QueensAmount)
            {
                if (PrintType.Array == printType)
                    PrintArrayOneRow();
                else
                    PrintArrayAll();

                return;
            }

            //依次放入皇后，並判斷是否有衝突
            for (int i = 0; i < QueensAmount; i++)
            {
                //先把當前這個皇后n,放到該行的第1列
                retArr[QueensCount] = i;

                //判斷當放置第n個皇后到i列時，是否衝突
                if (Check(QueensCount))
                {
                    //如果不衝突，接著放n+1個皇后，即開始遞歸
                    main(QueensCount + 1);
                }
            }
        }

        /// <summary>
        /// 檢查皇后是否衝突
        /// </summary>
        /// <param name="n">表示第n個皇后</param>
        /// <returns></returns>
        private bool Check(int n)
        {
            for (int i = 0; i < n; i++)
            {
                //1.retArr[i] == retArr[n] 表示判斷第n個皇后，是否和前面的n-1個皇后在同一列
                //2.Math.Abs​​(n - i) == Math.Abs​​(retArr[n] - retArr[i])表示判斷第n個皇后是否和第i個皇后在同一個斜線
                //3.判斷是否在同一行，沒有必要，n每次都在遞增
                if (retArr[i] == retArr[n] || Math.Abs(n - i) == Math.Abs(retArr[n] - retArr[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 皇后的擺放位置輸出
        /// </summary>
        private void PrintArrayOneRow()
        {
            for (int i = 0; i < retArr.Length; i++)
            {
                Console.Write(retArr[i] + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 皇后的擺放矩陣輸出
        /// </summary>
        private void PrintArrayAll()
        {
            for (int i = 0; i < retArr.Length; i++)
            {
                for (int k = 0; k < retArr.Length; k++)
                {
                    if (k == retArr[i])
                        Console.Write("Q");
                    else
                        Console.Write("。");
                }
                Console.Write("\n");
            }
            Console.Write("===============\n");
        }
    }
}
