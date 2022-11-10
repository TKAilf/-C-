using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx401
{
    internal class Sparrow
    {
        private String name = "すずめ";
        public void Sing()
        {
            Console.WriteLine( "チュンチュン" );
        }
        public String Name{
            get { return name; }
        }
    }
}
