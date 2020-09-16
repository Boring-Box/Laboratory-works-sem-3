using System;

public class A{
    private int a = 7;
    private int b = 4;

    public int c
    {
        get{return a * b;}
    }

    public int d
    {
        get{return a - b;}
    }
}

public class Programm
{
    static void Main(){
        A Obj = new A();
        System.Console.WriteLine(Obj.c);
        System.Console.WriteLine(Obj.d);
    }
}
