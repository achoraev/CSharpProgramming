namespace DefineClassGSM
{
    using System;
    using System.Text;

    public class Call // 8. Create a class Call
    {
        private DateTime dateAndTime;        
        private string dialedNumber;
        private int duration;

        //construktor
        public Call()
        { 
        }

        public Call(DateTime dateAndTime, string dialedNumber, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }
        //properties
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedNumber
        {
            get { return dialedNumber; }
            set {
                if (value.Length != 10)                
                throw new ArgumentException("Invalid number!!!");                
                dialedNumber = value;
                } 
        }

        public int Duration
        {
            get { return duration; }
            set {
                if (value < 0)
                    throw new ArgumentException("Invalid duration!!!");         
                duration = value; 
                }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Call Info: ");
            builder.Append(string.Format("Number: {0} ", this.DialedNumber));
            builder.Append(string.Format("Date: {0} ", this.DateAndTime));            
            builder.Append(string.Format("Duration: {0} seconds", this.Duration));
            return builder.ToString();
        }
    }
}
