namespace School
{
    using System;
    public abstract class NameableEntity
    {
        public NameableEntity (string name)
        {
            this.Name = name;
        }
        public string Name {get; private set; }
        public string Comments { get; set; } // Get and set are public
    }
}
