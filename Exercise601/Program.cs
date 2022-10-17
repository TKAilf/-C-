// See https://aka.ms/new-console-template for more information
Exercise601.Vector2D v1 = new Exercise601.Vector2D( 1, 1 );
Console.WriteLine( "v1=({0},{1})", v1.x, v1.y );
Exercise601.Vector2D v2 = new Exercise601.Vector2D( 1, -1 );
Console.WriteLine( "v1=({0},{1})", v1.x, v1.y );
v1.Add( v2 );
Console.WriteLine( "v1=({0},{1})", v1.x, v1.y );
v1.Sub( v2 );
Console.WriteLine( "v1=({0},{1})", v1.x, v1.y );
v1.Mul( 2.0 );
Console.WriteLine( "v1=({0},{1})", v1.x, v1.y );
Console.WriteLine( "v1,v2の内積 : {0}", v1.DotProduct( v2 ) );
