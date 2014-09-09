namespace Delegates
{
    using System;
    using System.Threading;

    class TestTimer
    {            
        static void Main()
        {
            Timer timerObj = new Timer();
            Ticker timer = timerObj.TickerProcess;

            while (true)
            {
                Thread.Sleep(100);
                timer(0);
                if (timerObj.Numbers == 101)
                {
                    break;
                }
            }
        }
    }
}