namespace School
{
    using OOPPrinciplesPart1;
    using System;
using System.Collections.Generic;

    public class Discipline:IComment
    {
        //fields
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        private List<string> comment;
        //properties
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new NullReferenceException("You must enter name!!!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (numberOfLectures <= 0)
                {
                    throw new NullReferenceException("Must have at least one lectures.");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (numberOfExercises <= 0)
                {
                    throw new NullReferenceException("Must have at least one exercises.");
                }
                this.numberOfExercises = value;
            }
        }

        public List<string> Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        // construktors
        public Discipline()
        { }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            :this()
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.Comment = new List<string>();
        }

        public void AddComment(string commentar)
        {
            this.Comment.Add(commentar);
        }
    }
}