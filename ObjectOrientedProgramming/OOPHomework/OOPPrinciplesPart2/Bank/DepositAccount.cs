namespace OopPrinciplesPart2
{
	using System;	
	
	public class DepositAccount:Account, IDeposit, IWithdraw
	{		
		//construktor
		public DepositAccount(Customers customer, decimal balance, decimal interestRate)
		: base (customer, balance, interestRate)
		{
		}
		
		//methods
		public override decimal CalculateRate (int month)
		{
			if	(this.Balance < 1000)
			{
				return 0;
			}
			else
			{
				return this.Balance * (this.InterestRate/100)*month;
			}
		}
		
		public void Deposit(int deposit)
		{
			this.Balance+=deposit;
		}
		
		public void Withdraw(int withdraw)
		{
			if ((this.Balance-withdraw) >= 0)
			{
				this.Balance-=withdraw;
			}
			else 
			{
				throw new ApplicationException("You don't have enough money!!!");
			}
		}
	}
}