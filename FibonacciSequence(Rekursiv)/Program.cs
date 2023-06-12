namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i <= 20; i++)                 // 3.Die angabe wie oft diese Folge wiederholte werden soll sobald es <=1 ist 
            {
                Console.WriteLine(Fib(i));              //schreibt die Zwischenschritte von Fibonacci auf 
            }

            Console.ReadKey();                          // behällt die Zwischenschritte bei sich um damit nach der Fibonacci-Methode weiter zu rechnen
        }
        static int Fib(int n)
        {
            if (n <= 1)                              // 2.Wenn die zahl <=1 ist wird sie so oft gesteigert wie wir es angeben         
                return n;                               
            else
                return Fib(n - 1) + Fib(n - 2);      // 1.Wenn die gegebene Zahl grösser als 1 ist wird sie immer weiter geschrumpft bis sie <=1 ist
        }
    }
}