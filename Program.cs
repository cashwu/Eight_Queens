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
            EightQueens eq1 = new EightQueens(8, PrintType.Array);
            eq1.Execute();

            EightQueens eq2 = new EightQueens(8, PrintType.All);
            eq2.Execute();

            Console.Read();
        }
    }
}