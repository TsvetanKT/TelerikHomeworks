using System;
using System.Threading;

class Timer
{
    //07.Using delegates write a class Timer that has can execute certain method at each t seconds.

    static void Main()
    {
        int counter = 1;
        SetTimer(new Action(() => Console.WriteLine("{0} seconds passed",counter++)), 1);
    }

    static void SetTimer(Action doSomething, dynamic time)
    {
        while (true)
        {
            Thread.Sleep((int)(time * 1000));
            doSomething();
        }
    }
}