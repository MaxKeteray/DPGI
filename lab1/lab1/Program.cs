using System;

class Hello
{
    public void SayHello()
    {
        Console.WriteLine("Hello, world!");
    }
}

class Program
{
    static void Main()
    {
        Hello hello = new Hello();
        hello.SayHello();
    }
}
