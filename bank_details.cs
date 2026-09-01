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































































