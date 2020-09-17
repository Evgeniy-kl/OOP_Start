using System;

public class Task6
{
    public static void Run()
    {
        Function1();
        Function2();
    }

    static void Function1()
    {
        checked
        {
            int ten = 10;
            int i = 2147483647 + ten;
            Console.WriteLine(i);
        }
    }

    static void Function2()
    {
        unchecked
        {
            int ten = 10;
            int i = 2147483647 + ten;
            Console.WriteLine(i);
        }
    }
}
