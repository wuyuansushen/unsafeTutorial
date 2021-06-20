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

            Console.WriteLine($"Value: {i,23}\nPointer1: {*p1,20}\nPointer2: {*p2,20}");
            Console.WriteLine($"ValueAddress: {(int)&i,16:X}\nPointer1Value: {(int)p1,15:X}\nPointer1Address: {(int)&p1,13:X}\n" +
                $"Pointer2Value: {(int)p2,15:X}\nPointer2Address: {(int)&p2,13:X}");
        }
    }
}
