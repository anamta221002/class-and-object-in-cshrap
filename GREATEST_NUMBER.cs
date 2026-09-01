using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace HelloWorld;

using System;
class Comparison()
{
    
    public int a;
    public int b;
    public int c;
    public void greatest()
    {
       
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        if (a > b && a > c)
        {
            Console.WriteLine("a is greatest");
        }
        else if(b>c && b>a)
        {
            Console.WriteLine("b is greatest");
        }
        else
        {
            Console.WriteLine("c is greatest");
        }
    }
    


}
class program
{
    static void Main(string[] args)
    {
       Comparison obj1 = new Comparison();
        obj1.a = 1;
        obj1.b = 20;
        obj1.c = 38;
        obj1.greatest();
    }
}