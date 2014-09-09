namespace Delegates
{
    using System;
    // 7.Using delegates write a class Timer that has can execute certain method at each t seconds.

    public delegate void Ticker(int start);
     
    public class Timer
    {
        private int numbers;

        public int Numbers
        {
            get {return this.numbers;}
            set { this.numbers = value; }
        }

        public void TickerProcess(int start)
        {
            Console.WriteLine(this.numbers);
            this.numbers++;
        
        }
    }
}
    