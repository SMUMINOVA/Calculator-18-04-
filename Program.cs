using System;

namespace delagate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static T Sum <T>(T n, T m){
            return (dynamic)n + (dynamic)m;
        }
        
        static T Multiplication <T>(T n, T m){
            return (dynamic)n * (dynamic)m;
        }
        
        static T Difference <T>(T n, T m){
            return (dynamic)n - (dynamic)m;
        }
    }
}
