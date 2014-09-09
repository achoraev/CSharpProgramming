namespace OopPrinciplesPart2
{
	using System;		
	
	public abstract class Account
	{		
		// fields
		private Customers customer;
		private decimal balance;
		private decimal interestRate;			
		
		//properties
        public Customers Customer
        {
            get {return this.customer;}
            set {this.customer = value;}
        }
		
		public decimal Balance
		{
			get {return this.balance;}
			set 
			{
				if(value < 0)
				{                    			
                    throw new ArgumentException("Balance must be positive!!!");
				}
				this.balance = value;
			}
		}
		
		public decimal InterestRate
		{
			get {return this.interestRate;}
			set {this.interestRate = value;}
		}
		
		//construktor
		public Account(Customers customer, decimal balance, decimal interestRate)
		{
			this.Customer = customer;
			this.Balance = balance;
			this.InterestRate = interestRate;
		}	
		
		//methods
		public abstract decimal CalculateRate (int month);		
	}
}