using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
  public class DemoMain
    {
        public static void Main(string[] args)
        {
            Calculator main = new Calculator();
            var sum = main.add(2, 4);
            var s = main.mul(3, 3);
            var di = main.div(4, 2);

            Console.WriteLine("Sum : {0} , Mul :{1} , Div :{2} ", sum, s, di);
            Console.ReadKey();
        }
    }
}
