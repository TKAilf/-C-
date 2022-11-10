using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx401
{
    internal class Chicken : Bird
    {
        private string name;
        public Chicken() : base( "にわとり" )
        {
        }
        public override void Sing()
        {
            Console.WriteLine( "コケコッコー" );
        }
    }
}
