namespace School
{
    public abstract class People : NameableEntity
    {
        public People (string name)
            :base(name)
        {

        }

        // I can't think of anithing unique for "People" (Teachers and Students) to inherit here, so i'm
        //  leaving this class empty.
    }
}