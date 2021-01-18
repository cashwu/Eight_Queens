using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight_Queens
{
    class Program
    {
        static void Main(string[] args)
        {
            //測驗1輸出皇后位置
            EightQueens eq1 = new EightQueens(8, PrintType.Array);
            eq1.Execute();

            //測驗2輸出矩陣
            EightQueens eq2 = new EightQueens(8, PrintType.All);
            eq2.Execute();

            Console.Read();
        }
    }
}