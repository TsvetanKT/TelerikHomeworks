namespace MobilePhone
{
    using System;
    using System.Text;

    public class Battery
    {
        // Fields
        private double? hoursIdle;
        private double? hoursTalk;

        // Fonstructors
        public Battery()
            : this(null, null, null, BatteryType.LiIon)
        {
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        // Properties
        public string Model { get; private set; }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle coud not be negative number!");
                }

                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk  coud not be negative number!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type { get; private set; }

        // Mmethods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\n");
            result.AppendFormat("\n-Model: {0}", this.Model);
            result.AppendFormat("\n-Battery type: {0}", this.Type);
            result.AppendFormat("\n-Hours idle: {0}", this.HoursIdle);         
            result.AppendFormat("\n-Hours talk: {0}", this.HoursTalk);
   
            return result.ToString();
        }
    }
}