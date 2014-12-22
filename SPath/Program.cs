using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPath
{
    class Program
    {
        static void Main(string[] args)
        {
            String tgf =
@"1
2
3
4
5
6
#
1 2 7
1 3 9
1 6 14
2 3 10
2 4 15
4 3 11
4 5 6
6 3 2
6 5 9";
            Graph g = new Graph(tgf, false);
            g.draw();
            Console.ReadKey();
        }
    }
}
