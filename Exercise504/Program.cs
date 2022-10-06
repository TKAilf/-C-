// See https://aka.ms/new-console-template for more information
int[,] m = new int[9,9];
for( int i = 1; i < 10; i++ ){
    for( int j = 1; j < 10; j++ ){
        m[i - 1, j - 1] = i * j;
        Console.Write( "{0}*{1}={2} ", i, j, m[i - 1, j - 1] );
    }
    Console.WriteLine();
}
