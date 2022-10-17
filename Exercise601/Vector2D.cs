using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    internal class Vector2D
    {
        public double x, y;
        public Vector2D( double x, double y ){
            this.x = x; this.y = y;
        }
        public void Add( Vector2D v ){
            this.x += v.x; this.y += v.y;
        }
        public void Sub( Vector2D v ){
            this.x -= v.x; this.y -= v.y;
        }
        public void Mul( double d ){
            this.x *= d; this.y *= d;
        }
        public double DotProduct( Vector2D v ){
            return this.x * v.x + this.y * v.y;
        }
    }
}
