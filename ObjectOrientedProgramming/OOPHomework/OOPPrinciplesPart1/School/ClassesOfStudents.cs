namespace School
{
    using OOPPrinciplesPart1;
    using System;
    using System.Collections.Generic;
	
	public class ClassesOfStudents:IComment
	{
		private List<Student> students;
		private List<Teacher> teachers;
        private List<string> comment;
		
		public List<Student> Students
		{
			get {return this.students;}
			set
			{
                //if (value.Count <= 0) // problem here
                //{
                //    throw new Exception("Class must have at least one student!!!");
                //}
				this.students = value;
			}
		}

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                //if (teachers.Count <= 0)
                //{
                //    throw new Exception ("Class must have at least one teacher!!!");
                //}
                this.teachers = value;
            }
        }

        public List<string> Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
		//construktor
		public ClassesOfStudents ()		
		{
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
		}

        public void AddComment(string commentar)
        {
            this.Comment.Add(commentar);
        }
        //methods
        public void AddTeacher(Teacher teachers)
        {            
            this.Teachers.Add(teachers);
        }
        public void AddStudent(Student students)
        {
            this.Students.Add(students);
        }
	}
}