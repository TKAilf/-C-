using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx301
{
    internal class Point2D : Vector2D
    {
        public Point2D( double x, double y ) : base( x, y )
        {
        }
        public Point2D( Point2D p ) : base( p )
        {
        }
        public Point2D() : base( 0, 0 )
        {
        }
        public double Distance( Point2D p )
        {
            double dX = X - p.X;
            double dY = Y - p.Y;
            return Math.Sqrt( ( dX * dX ) + ( dY * dY ) );
        }

        public override bool Equals( object obj )
        {
            Point2D p = obj as Point2D;
            // double型を使うと,値に少しの誤差が生まれるため
            // Distance( p ) == 0
            // とはしないようにしている。
            if( Distance( p ) < 0.01 ){
                return true;
            }else{
                return false;
            }
        }
        public override string ToString()
        {
            string s = "(" + X + "," + Y + ")";
            return s;
        }
    }
}
