namespace Human
{

    public abstract class Human
    {
        public Human (string first, string second)
        {
            this.FirstName = first;
            this.LastName = second;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; } 
    }
}
