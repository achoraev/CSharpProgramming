namespace OopPrinciplesPart2
{
	using System;	
	
	public class Loan:Account, IDeposit
	{		
		//construktor
		public Loan(Customers customer, decimal balance, decimal interestRate)
		: base (customer, balance, interestRate)
		{
		}	
		
		//methods
		public override decimal CalculateRate (int month)
		{
			if(month <= 2 && this.Customer == Customers.Companies)
			{
				return 0;
			}
			else if (month <= 3 && this.Customer == Customers.Individuals)
			{
				return 0;
			}
			else if (this.Customer == Customers.Companies)
			{
				return this.Balance * (this.InterestRate/100) * (month-2);
			}
			else 
			{
                return this.Balance * (this.InterestRate / 100) * (month - 3);
			}			
		}
		
		public void Deposit(int deposit)
		{
			this.Balance+=deposit;
		}
	}
}