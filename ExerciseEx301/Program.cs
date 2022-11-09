Console.Write( "p1.X = " );
double x1 = int.Parse( Console.ReadLine() );
Console.Write( "p1.Y = " );
double y1 = int.Parse( Console.ReadLine() );
Console.Write( "p2.X = " );
double x2 = int.Parse( Console.ReadLine() );
Console.Write( "p2.Y = " );
double y2 = int.Parse( Console.ReadLine() );
ExerciseEx301.Point2D p1 = new ExerciseEx301.Point2D( x1, y1 );
ExerciseEx301.Point2D p2 = new ExerciseEx301.Point2D( x2, y2 );
// ------------------------------------------------------------------
// p1, p2とConsole.WriteLineで出力している。
// これはToString()を実装しているため、可能となる書き方である。
// 自動的にToString()が呼び出され、文字列で返してくれるようになる。
// ------------------------------------------------------------------
Console.WriteLine( "p1 = {0} p2 = {1}", p1, p2 );
Console.WriteLine( "p1, p2の距離 : {0}", p1.Distance( p2 ) );
if( p1.Equals( p2 ) ){
    Console.WriteLine( "p1, p2は同一の点です。" );
}
