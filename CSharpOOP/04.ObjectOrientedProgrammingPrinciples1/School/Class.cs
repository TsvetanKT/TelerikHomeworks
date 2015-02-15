namespace School
{
    using System;
    using System.Collections.Generic;
    public class Class : NameableEntity
    {

        public Class (string name, List<Teacher> teachers )
            :base (name)
        {
            this.SetOfTeachers= teachers;
        }

        public List<Teacher> SetOfTeachers {get; private set;}
    }
}
