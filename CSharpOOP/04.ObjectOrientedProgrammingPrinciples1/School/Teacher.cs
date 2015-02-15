namespace School
{
    using System;
    using System.Collections.Generic;
    public class Teacher : People
    {
        public Teacher(string name, Discipline discipline)
            : base(name)
        {
            this.SetOfDisciplines = new List<Discipline> { discipline };
        }

        public List<Discipline> SetOfDisciplines { get; private set; }
    }
}
