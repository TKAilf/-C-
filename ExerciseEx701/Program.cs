namespace ExerciseEx701
{
    delegate void Operation( int a, int b );
    class Calc
    {
        public void Mul( int a, int b )
        {
            Console.WriteLine( "{0} * {1} = {2}", a, b, a * b );
        }
        public void Div( int a, int b )
        {
            Console.WriteLine( "{0} / {1} = {2}", a, b, a / b );
        }
        public void Plus( int a, int b )
        {
            Console.WriteLine( "{0} + {1} = {2}", a, b, a + b );
        }
        public void Minus( int a, int b )
        {
            Console.WriteLine( "{0} - {1} = {2}", a, b, a - b );
        }
    }
    class Program
    {
        static void Main( string[] args )
        {
            Calc calc = new Calc();
            Operation operation = new Operation( calc.Plus );
            operation += new Operation( calc.Minus );
            operation += new Operation( calc.Mul );
            operation += new Operation( calc.Div );
            int a = int.Parse( Console.ReadLine() );
            int b = int.Parse( Console.ReadLine() );
            operation( a, b );
        }
    }
}
