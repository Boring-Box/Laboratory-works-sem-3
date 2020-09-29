using System;

public class A{
    public int a;
    public int b;
    
    public A(int a, int b){
        this.a = a;
        this.b = b;
    }

    public int c{
        get{return a - b;}
    }
}

public class B: A{
    public int d;
    private int answ = 0;
    public int[] array;

    public B(int a, int b, int d) : base(a, b){
        this.d = d;
        array = new int[a];
        c2 = c2;
        for(int i=0; i<a; i++){
            array[i] = i * answ;
        }
    }

    public int c2{
        set{
            for(int i=0; i<=10; i++){
                answ = a * b - d + i;
            }
        }
        get{return answ;}
    }
}


public class Program{
    static void Main(){
        B B_Obj = new B(3, 2, 5);
        System.Console.WriteLine($"answ = {B_Obj.c2}");
        foreach(int i in B_Obj.array){
            System.Console.Write($"{i} ");
        }
    }
}