using System;
using System.IO;
using static System.Console;

namespace ConsoleAppTemplate
{
    public static class Program
    {

        static int GetWeeks(int day)
        {
            return 2;

        }
        static int GetEnglishSefira(int day)
        {
            // < 1 week , > 1 week , on week boundary, corner case, עברית
            return 2;

        }

        public static void Main(string[] args)
        {
            string projectDir =
                Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
           File.WriteAllText(projectDir + "/text3.txt", "Hello");  
        }
    }
}

// static class => all methods are static (not instantiable) - no provate ctor required, no inheritance
// no static top level classes in Java
// static class is required for extension methods = method which appears to be a member of class, but it is not

public static class CoolExtensionMethods
{
    public static bool IsEven(this int n)
    {
        return n % 2 == 0;
    }
}

class Foo // new Foo()
{
    private int x;
    private int q;
    private UInt32 a1; // Unsigned Int 00 - 4Billion (int ranged from -2B +2B)
    private UInt64 a2;
    private UInt16 a3;
    private Single f1;
    private Double f2;
    private short s;

    public void Foot()
    {
        var x = 2_000_000_000_000;
    }
}

// type struct = VALUE TYPE (in Java primitive) [no inheritance]
// DateTime dt1, dt2; dt1 = dt2; // copies 40bytes...all interbnal dt data
// decimal, long, int, short, char, bool, float, double, DateTime, ,,,,
// object (may be) created on stack
// very small objects

// type class = REFERENCE TYPE 
// String a,b; a=b; // assigns ref  copies 4 byte
// String, StringBuilder, List (ArrayList), Dictionary (HashMap)...
// object created on heap - uses dynamic memory allocation and garbage collector cleanup
// use classes
