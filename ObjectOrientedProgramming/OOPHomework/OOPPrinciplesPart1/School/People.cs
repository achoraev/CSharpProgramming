namespace School
{
    using OOPPrinciplesPart1;
    using System;
    using System.Collections.Generic;
	
	public class People: IComment
	{
		//fields
        private string name;
        private List<string> comment;
		//properties
		public string Name
		{
			get {return this.name;}
			set {this.name = value;}
		}

        public List<string> Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

		//construktor
		public People (string name)
		{
			this.Name = name;
            this.Comment = new List<string>();
		}

        public void AddComment(string commentar)
        {
            this.Comment.Add(commentar);
        }
        // override ToString
        public override string ToString()
        {
            return this.Name;
        }
	}
}