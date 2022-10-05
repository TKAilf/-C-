// See https://aka.ms/new-console-template for more information
Random random = new Random();
Console.WriteLine( "6が出たら終了" );
while( true ){
    int dice = random.Next( 1, 7 );
    Console.WriteLine( dice );
    if( dice == 6 ){
        break;
    }
}
Console.WriteLine( "終了" );
