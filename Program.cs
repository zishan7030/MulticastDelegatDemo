using System;

namespace MulticastDelegatDemo
{
    //Declaration of Delegates
    public delegate void ArithDelegate(int a, int b);
    class Program
    {
        //Creating Methods Reference to Delegats
        public void Addition(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of {0} and {1} is {2} ", a, b, c);
        }
        public void Substraction(int a, int b)
        {
            int c= a - b;
            Console.WriteLine("Subtraction of {0} from {1} is {2} ", b, a, c);
        }
        public void Multiplication(int a,int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication of {0} and {1} is {2} ", a, b, c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Arithmatic Operations***");
            
            //Creating Object of Class
            Program p = new Program();
            
            //Initializing Delegats and using
            ArithDelegate ad = new ArithDelegate(p.Addition);
            ad += new ArithDelegate(p.Substraction);        //Using Same Delegat Object and Passing Referance of Another Method 
            ad += new ArithDelegate(p.Multiplication);
            ad(10, 5);                                      //Passing Values
        }
    }
}
