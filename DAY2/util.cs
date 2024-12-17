using System;

public class Util
{
    public static void ShowHierachy(Object obj, bool full = false)
    {
        Type object_type = typeof(object);

        Type t = obj.GetType();

        while (t.Equals(object_type) == false)
        {
            Console.Write("{0} => ", full ? t.FullName : t.Name);
            t = t.BaseType;
        }
        Console.WriteLine("{0}", t.Name);
    }
}
