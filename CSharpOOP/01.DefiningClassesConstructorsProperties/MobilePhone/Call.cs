namespace MobilePhone
{
    using System;
    using System.Text;

    public class Call
    {
        // Fields
        private int duration;

        // Constructors
        public Call(DateTime date, string number, int seconds)
        {
            this.TimeOfCall = date;
            this.DialedPhone = number;
            this.Duration = seconds;
        }

        // Properties
        public DateTime TimeOfCall { get; private set; }

        public string DialedPhone { get; private set; }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration cannot be negative number !");
                }

                this.duration = value;
            }
        }

        // Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\n-Dialed number: {0}", this.DialedPhone);
            result.AppendFormat("\n-Date and time: {0}", this.TimeOfCall);
            result.AppendFormat("\n-Call duration: {0} sec", this.Duration);

            return result.ToString();
        }
    }
}