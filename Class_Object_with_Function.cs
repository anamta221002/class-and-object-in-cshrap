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