// See https://aka.ms/new-console-template for more information
Console.Write("さいころの目(1～6):");
int dice = int.Parse( Console.ReadLine() );
if( 1 <= dice && dice <= 6 ){
    if( dice / 2 == 0 ){
        Console.WriteLine( "丁です。" );
    }else{
        Console.WriteLine( "半です。" );
    }
}else{
    Console.WriteLine( "さいころの目の範囲外の数です。" );
}
