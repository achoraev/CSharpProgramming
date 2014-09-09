namespace School
{
    using OOPPrinciplesPart1;
    using System;
    using System.Collections.Generic;
	
	public class Teacher: People, IComment
	{
        public readonly List<Discipline> TeacherDiscipline;

        public Teacher (string name)
		: base(name)
		{
            this.TeacherDiscipline = new List<Discipline>();				
		}
        //method
        public void AddDiscipline(Discipline discipline)
        {
            this.TeacherDiscipline.Add(discipline);
        }
	}
}