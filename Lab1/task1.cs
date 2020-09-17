using System;

public class Task1 
{ 
    public static void Run()
    {
        #region 1a
        bool mybool = false;
        byte mybyte = 10;
        sbyte mysbyte = 100;
        char mychar = 'a';
        decimal mydec = 10000;
        double mydouble = 1.5f;
        float myfloat = 3f;
        int myint = 5;
        uint myuint = 2;
        long mylong = 5;
        ulong myulong = 15;
        short myshort = 20;
        ushort myushort = 15;

        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write(x);
        #endregion

        #region 1b
        byte b = 10;
        short v = b;
        int c = v;
        long l = v;
        decimal d = l;

        c = Convert.ToInt32("10");
        string s = Convert.ToString(c);
        bool i = Convert.ToBoolean(myfloat);
        #endregion

        #region 1c
        int q1 = 10;
        Object o = q1;
        int q2 = (int)o;
        #endregion

        #region 1d
        dynamic dyn = 10;
        dyn = "some string";
        dyn = 1.5f;
        dyn = false;
        #endregion

        #region 1e
        string? nullString = null;

        if (nullString == null)
        {
            nullString = "not null string";
        }
        #endregion

        #region 1f
        var someVar = 10;

        //ошибка: тип var опеделяется один раз только в момент инициализации (в данном случае System.Int32)
        //someVar = "string";
        #endregion
    }
}
