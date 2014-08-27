namespace DefineClassGSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        //fields
        private string model;
        private string manifacturer;
        private string owner;
        private decimal price;
        private const double priceOfCall = 0.37;
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 980, "Anjel");

        private List<Call> callHistory = new List<Call>();
        
        // instance of Battery and Display
        Battery battery = new Battery(); 
        Display display = new Display();

        //property   
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manifacturer
        {
            get { return manifacturer; }
            set { manifacturer = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        // 9. Define property for Call History
        public List<Call> CallHistory
        {
            get { return this.callHistory;}
            set {this.callHistory = value;}
        }

        // second exercize define constructor without parameters
        public GSM()
        {            
        }

        public GSM(string model, string manifacturer, decimal price, string owner) // second exercize constructor with parameters
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;            
        }
        
        public void AddCall(DateTime DateAndTime, string DialedNumber, int Duration) // 10. Add method
        {
            this.CallHistory.Add(new Call(DateAndTime, DialedNumber, Duration));
        }

        public void RemoveCalls() // 10. Remove method
        {
            int callToDelete = 0;
            if (CallHistory.Count > 0)
            {
                Console.WriteLine("Enter number to delete from 1 to {0}!!!", CallHistory.Count);                
                callToDelete = int.Parse(Console.ReadLine());
                if (callToDelete == 0)
                {
                    return;
                }
                if (callToDelete < 1 || callToDelete > CallHistory.Count)
                {
                    Console.WriteLine("Entered wrong number!!!");
                }
                else
                {
                    this.CallHistory.RemoveAt(callToDelete-1);
                }			
            }
            else 
            {
                Console.WriteLine("Call history is empty!!!");
            }	
        }

        public void ClearCallHistory() // 10. Clear method
	    {
            CallHistory.Clear();            
	    }
	
	    public double CalculatePriceOfCall() // 11. Calc Price Method
	    {
		    double totalDuration = 0;
		    foreach (Call call in this.CallHistory)
		    {
			    totalDuration += call.Duration;
		    }
            double totalCost = (totalDuration / 60) * priceOfCall;
		    return totalCost;
	    }
	
	    public void DeleteLongestCall() // 12. Delete Longest Call
	    {
		    double longestCall = double.MinValue;
		    Call selectedItem = null;
		    foreach (Call call in this.CallHistory)
		    {
			    if (call.Duration > longestCall)
			    {
				    longestCall = call.Duration;
				    selectedItem = call;
			    }			
		    }
		    if (selectedItem != null)
		    {
			    this.CallHistory.Remove(selectedItem);
		    }
	    }

        public override string ToString() // override ToString
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Phone information:");
            if (Model != null)
            {
                info.AppendLine("Model is: " + Model);
            }
            if (Manifacturer != null)
            {
                info.AppendLine("Produced from: " + Manifacturer);
            }
            if (Price != 0)
            {
                info.AppendLine("The Price is: " + Price + " lv.");
            }
            if (Owner != null)
	        {
		        info.AppendLine("Owner of the phone is: " + Owner);
            }
            if (Battery != null)
            {
                info.AppendLine(battery.ToString());
            }
            if (Display != null)
            {
                info.AppendLine("Display is: "+Display);
            }
            return info.ToString();
        }

    }
}