namespace OopPrinciplesPart2
{
	using System;	
	
	public class InvalidRangeException<T>
	: ApplicationException
	{		
		// fields
		private T start;
		private T end;
		private const string OutMessage = "Out of range!!!";
		// properties
		public T Start
		{
			get { return this.start;}
			set {this.start = value;}
		}
		
		public T End
		{
			get { return this.end;}
			set {this.end = value;}
		}
		// construktors
		public InvalidRangeException (string msg)
		: base(msg)
		{
		}
		
		public InvalidRangeException(T start, T end, Exception innerException = null)
		: base(OutMessage, innerException)
		{
			this.Start = start;   
			this.End = end;
		}
	}
}