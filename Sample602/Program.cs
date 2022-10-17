// See https://aka.ms/new-console-template for more information
Sample602.Calc calc = new Sample602.Calc();
int a = 1, b = 2, c = 3;
int ans1 = calc.Add( a, b );
int ans2 = calc.Add( a, b, c );
Console.WriteLine( "{0} + {1} = {2}", a, b, ans1 );
Console.WriteLine( "{0} + {1} + {2} = {3}", a, b, c, ans1 );
