namespace OopPrinciplesPart2
{
	using System;	
	
	public class Mortgage:Account, IDeposit
	{		
		//construktor
		public Mortgage(Customers customer, decimal balance, decimal interestRate)
		: base (customer, balance, interestRate)
		{
		}	
		
		//methods
		public override decimal CalculateRate (int month)
		{
            if (this.Customer == Customers.Companies && month <= 12)
			{
				return this.Balance * (this.InterestRate/200) * month;
			}
            else if (this.Customer == Customers.Companies)
			{
				return (this.Balance * (this.InterestRate/200) * 12)+(this.Balance * (this.InterestRate/100) * month-12);
			}
            else if (this.Customer == Customers.Individuals && month <= 6)
			{
				return 0;
			}
			else
			{
				return this.Balance * (this.InterestRate/100) * (month-6);
			}
		}
		
		public void Deposit(int deposit)
		{
			this.Balance+=deposit;
		}
	}
}