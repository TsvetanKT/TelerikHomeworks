namespace School
{
    using System;
    public class Discipline : NameableEntity
    {
        public Discipline (string name,int lectures ,int exercises )
            :base (name)
        {
            this.Lectures = lectures;
            this.Exercises = exercises;
        }
        public int Lectures { get; private set; }

        public int Exercises { get; private set; }

    }
}
