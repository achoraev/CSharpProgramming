namespace OopPrinciplesPart2
{
	using System;	
	/* 2. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and 
	mortgage accounts. Customers could be individuals or companies.
	All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed 
	to deposit and with draw money. Loan and mortgage accounts can only deposit money.
	All accounts can calculate their interest amount for a given period (in months). In the common case 
	its is calculated as follows: number_of_months * interest_rate.
	Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
	Deposit accounts have no interest if their balance is positive and less than 1000.
	Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 
	6 months for individuals. Your task is to write a program to model the bank system by classes and 
	interfaces. You should identify the classes, interfaces, base classes and abstract actions and 
	implement the calculation of the interest functionality through overridden methods.
	*/
	public class TestBank
	{		
		public static void Main()
		{
			DepositAccount myDeposit = new DepositAccount(Customers.Individuals, 150m, 0.9m);
            myDeposit.Deposit(2500);

            Console.WriteLine("Balance: {0}", myDeposit.Balance);
            Console.WriteLine("Interest: {0}", myDeposit.CalculateRate(12));

            Console.WriteLine("... Withdrawing 1500 ...");
            myDeposit.Withdraw(1500);
            //myDeposit.Withdraw(3000); //exception

            Console.WriteLine("New Balance {0}", myDeposit.Balance);
            Console.WriteLine("New Interest rate: {0}", myDeposit.CalculateRate(12));
			
			Loan loanDepositFirma = new Loan(Customers.Companies, 1800m, 1m);// interest rate is per month
			loanDepositFirma.Deposit(4000);
            Console.WriteLine("New Balance {0}", loanDepositFirma.Balance);
            Console.WriteLine("New Interest rate: {0}", loanDepositFirma.CalculateRate(18));
			
			Loan loanDeposit = new Loan(Customers.Individuals, 1800m, 1m);
			loanDeposit.Deposit(4000);
            Console.WriteLine("New Balance {0}", loanDeposit.Balance);
            Console.WriteLine("New Interest rate: {0}", loanDeposit.CalculateRate(18));
			
			Mortgage mortgageDepositFirma = new Mortgage(Customers.Companies, 1800m, 1m);
			mortgageDepositFirma.Deposit(4000);
            Console.WriteLine("New Balance {0}", mortgageDepositFirma.Balance);
            Console.WriteLine("New Interest rate: {0}", mortgageDepositFirma.CalculateRate(24));
            
		}
	}
}