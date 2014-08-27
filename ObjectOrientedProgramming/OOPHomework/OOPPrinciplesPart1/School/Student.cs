namespace School
{
    using OOPPrinciplesPart1;
    using System;
    using System.Collections.Generic;
	
	public class Student: People, IComment
	{
		private int uniqueID;        

		public int UniqueID
		{
            get { return this.uniqueID; }
			set {this.uniqueID = value;}
		}
		
		public Student (string name, int uniqueID)
		: base(name)
		{			
            this.UniqueID = uniqueID;            
		}

        public override string ToString()
        {
            return string.Format("{0} ID: {1}", this.Name, this.UniqueID);
        }
	}
}