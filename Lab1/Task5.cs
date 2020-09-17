using System;
using System.Linq;

public class Task5
{
    public static (int, int, int, char) Run(int[] array, string str)
    {
        return (array.Max(), array.Min(), array.Sum(), str[0]);
    }
}
