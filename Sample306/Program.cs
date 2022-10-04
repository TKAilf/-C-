// See https://aka.ms/new-console-template for more information
Console.Write("さいころの目(1～6):");
int dice = int.Parse( Console.ReadLine() );
switch( dice ){
    case 1:
    case 3:
    case 5:
        Console.WriteLine( "半です。" );
        break;
    case 2:
    case 4:
    case 6:
        Console.WriteLine( "丁です。" );
        break;
    default:
        Console.WriteLine( "範囲外の数です。" );
        break;
}
