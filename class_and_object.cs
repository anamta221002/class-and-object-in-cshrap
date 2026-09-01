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