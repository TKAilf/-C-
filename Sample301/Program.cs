// See https://aka.ms/new-console-template for more information
Console.Write("整数値を入力:");
int a = int.Parse( Console.ReadLine() );
Console.WriteLine( "a=" + a );
if( a > 0 ){
    Console.WriteLine( "aは正の数です。" );
}else if( a == 0 ){
    Console.WriteLine( "aは0です。" );
}else{
    Console.WriteLine( "aは負の数です。" );
}
