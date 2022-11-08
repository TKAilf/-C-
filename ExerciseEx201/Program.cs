
namespace ExerciseEx201
{
    class Program
    {
        static public void Show( string sname, Vector2D v )
        {
            Console.WriteLine( "{0}=({1},{2})", sname, v.X, v.Y );
        }
        static void Main( string[] args )
        {
            Vector2D v1 = new Vector2D( 1, 1 );
            Show( "v1", v1 );
            // Console.WriteLine( "v1=({0},{1})", v1.X, v1.Y );
            Vector2D w  = new Vector2D( 1, -1 );
            Vector2D v2 = new Vector2D( w );
            Show( "v2", v2 );
            // Console.WriteLine( "v1=({0},{1})", v1.X, v1.Y );
            v1.Add( v2 );
            Show( "v1", v1 );
            // Console.WriteLine( "v1=({0},{1})", v1.X, v1.Y );
            v1.Sub( v2 );
            Show( "v1", v1 );
            // Console.WriteLine( "v1=({0},{1})", v1.X, v1.Y );
            v1.Mul( 2.0 );
            Show( "v1", v1 );
            // Console.WriteLine( "v1=({0},{1})", v1.X, v1.Y );
            Console.WriteLine( "v1,v2の内積 : {0}", v1.DotProduct( v2 ) );
        }
    }
}
