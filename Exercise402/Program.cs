// See https://aka.ms/new-console-template for more information
Console.Write("整数を入力:");
int num = int.Parse( Console.ReadLine() );
for( int i = 1; i < num + 1; i++ ){
    if( num % i == 0 ){
        Console.Write( i + " " );
    }
}
Console.WriteLine();
