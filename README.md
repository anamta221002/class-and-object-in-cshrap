# class-and-object-in-cshrap

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace HelloWorld;

using System;
class Employee  
{
    public int empid;
    public string empname;
    public double salary;

}
class store
{
    static void Main(string[] args)
    {
        Employee obj = new Employee();
        obj.empname = "rahul";
        obj.salary = 1000;
        obj.empid= 1;
        Console.WriteLine(obj.empname);
        Console.WriteLine(obj.salary);
        Console.WriteLine(obj.empid);
        Console.WriteLine();
        Employee obj2= new Employee();
        obj2.empname = "ram";
        obj2.salary = 8000;
        obj2.empid = 2;
        Console.WriteLine(obj2.empname);
        Console.WriteLine(obj2.salary);
        Console.WriteLine(obj2.empname);
        Console.WriteLine();
        Employee obj3= new Employee();
        obj3.empname= "km";
        obj3.salary = 9800;
        obj3.empid = 3;
        Console.WriteLine();
        Console.WriteLine(obj3.empname);
        Console.WriteLine(obj3.salary);
        Console.WriteLine(obj3.empid);

    }
}
# print class and object with function

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace HelloWorld;

using System;
class Student
{
    public string name;
    public int marks;
    public void display()
    {
        Console.WriteLine(name);
        Console.WriteLine(marks);
    }
}
class start
{
     static void Main(string[] args)
    {
       Student obj1 = new Student();
        obj1.name ="anamta";
        obj1.marks = 98;
        obj1.display();
       
    }
}

# greatest in 3 number 
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
# update and print bank details

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace HelloWorld;

using System;
class Bankaccount
{
    public int balance;
    public void deposit( int amount)
    {
        balance = balance + amount;
    }
    public void withdraw ( int amount )
    {
        balance = balance - amount;
    }
}
 class Start
{
        static void Main ( String[] args)
    {
        Bankaccount account = new Bankaccount();
        account.balance = 400;
        account.deposit( 100 );
        account.withdraw( 50 );
        Console.WriteLine(account.balance);
       




    }
   


}

















































































































































































































