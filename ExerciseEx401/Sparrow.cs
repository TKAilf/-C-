using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx401
{
    internal class Sparrow : Bird
    {
        public Sparrow() : base( "すずめ" )
        {
        }
        public override void Sing()
        {
            Console.WriteLine( "ちゅんちゅん" );
        }
    }
}
