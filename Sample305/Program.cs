﻿// See https://aka.ms/new-console-template for more information
Console.Write( "1から3の整数を入力:" );
int num = int.Parse( Console.ReadLine() );
switch ( num ){
    case 1:
        Console.WriteLine( "one" );
        break;
    case 2:
        Console.WriteLine( "two" );
        break;
    case 3:
        Console.WriteLine( "three" );
        break;
    default:
        Console.WriteLine( "不適切な値です。" );
        break;
}
