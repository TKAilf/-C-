﻿// See https://aka.ms/new-console-template for more information
double temp = double.Parse( Console.ReadLine() );
Console.WriteLine( temp );
if( temp == 0.0 ){
    Console.WriteLine( "ゼロ" );
}else if( temp < 0.0 ){
    Console.WriteLine( "マイナス" );
}else{
    Console.WriteLine( "プラス" );
}
