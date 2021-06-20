using System;

namespace unsafeTutorial
{
    unsafe class Program
    {
        // Add
        // <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
        // to enable compiler support
        // in .csproj file.
        unsafe static void doubleInt(int* IntIn) => *IntIn *= 2;
        unsafe static void Main(string[] args)
        {
            int i = 100;
            int* p1 = &i;
            int* p2 = &i;
            doubleInt(p1);

            Console.WriteLine($"{i}\n{*p1}\n{*p2}");
        }
    }
}
