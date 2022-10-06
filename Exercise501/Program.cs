// See https://aka.ms/new-console-template for more information
int[] a = new int[10];
for( int i = 0; i < 10; i++ ){
    a[i] = i + 1;
}
foreach( int i in a ){
    Console.WriteLine( "a[" + (i - 1) + "] = " + a[i - 1] );
}
