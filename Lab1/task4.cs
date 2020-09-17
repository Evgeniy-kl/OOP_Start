using System;

public class Task4
{
    public static void Run()
    {
        #region 4a
        (int, string, char, string, ulong) t = (-5, "string1", 'a', "string2", 20);
        #endregion

        #region 4b
        Console.WriteLine(t.Item1);
        Console.WriteLine(t.Item2);
        Console.WriteLine(t.Item3);
        Console.WriteLine(t.Item4);
        Console.WriteLine(t.Item5);
        #endregion

        #region 4c
        int myInt;
        string myString1;
        string myString2;
        char myChar;
        ulong myUlong;

        (myInt, myString1, myChar, myString2, myUlong) = t;
        #endregion

        #region 4d
        (int, float) tupple1 = (10, 5f);
        (int, float) tupple2 = (3, .8f);

        Console.WriteLine(tupple1 == tupple2);
        #endregion
    }
}