// See https://aka.ms/new-console-template for more information
Random num1 = new Random();
Random num2 = new Random();
int a = num1.Next( 1, 10 );
int b = num2.Next( 1, 10 );
Console.WriteLine( "a={0} b={1}", a, b );
while( true ){
    Console.Write( "a+b=" );
    int nInput = int.Parse( Console.ReadLine() );
    if( nInput == ( a + b ) ){
        Console.WriteLine( "正解" );
        break;
    }else{
        Console.WriteLine( "間違い" );
    }
}
