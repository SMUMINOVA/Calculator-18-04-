using System;
using System.Collections.Generic;
namespace delagate
{
        delegate T Calculate<T>(T n, T m);
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello! Here you can calculate some simple math praxis");
            while(true){
                satrt1 :
                System.Console.WriteLine("Please enter two numbers");
                System.Console.Write("First number: ");
                double firstNumb = double.Parse(Console.ReadLine());
                System.Console.Write("Second number: ");
                double secondNumb = double.Parse(Console.ReadLine());
                start :
                System.Console.WriteLine("Please choose action:\n1.Add(+)\n2.Multiply(*)\n3.Subtract(-)\n4.Divide(/)");
                string c = Console.ReadLine();
                switch(c){
                    case "1":{
                        Calculate<double> act = Sum <double>;
                        System.Console.WriteLine($"Result: {act.Invoke(firstNumb, secondNumb)}");
                    } ;break;
                    case "2":{
                        Calculate<double> act = Multiplication<double>;
                        System.Console.WriteLine($"Result: {act.Invoke(firstNumb, secondNumb)}");
                    } ;break;
                    case "3":{
                        Calculate<double> act = Difference <double>;
                        System.Console.WriteLine($"Result: {act.Invoke(firstNumb, secondNumb)}");
                    } ;break;
                    case "4":{
                        if(secondNumb == 0){
                            System.Console.WriteLine("You can't divide number into 0! Try again");
                            goto satrt1;
                        }
                        else {
                            Calculate<double> act = Ratio<double>;
                            System.Console.WriteLine($"Result: {act.Invoke(firstNumb, secondNumb)}");
                        }
                    } ;break;
                    default: System.Console.WriteLine("Wrong choice! Try again"); goto start;
                }
                System.Console.WriteLine("Do you want to continue?y/n");
                if (Console.ReadLine() == "y")
                   continue;
                else break;
            }
            System.Console.WriteLine("Bye");
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
        
        static T Ratio <T>(T n, T m){
            return (dynamic)n / (dynamic)m;
        }
    }
}
