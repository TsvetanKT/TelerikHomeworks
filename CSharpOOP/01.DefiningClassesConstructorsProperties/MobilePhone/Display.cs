namespace MobilePhone
{
    using System;
    using System.Text;

    public class Display
    {
        // Fields
        private double? size;
        private string numberOfColors;

        // Constructors
        public Display(): this(null, null)
        {

        }

        public Display(double? diagonal, string colors)
        {
            this.Size = diagonal;
            this.NumberOfColors = colors;
        }

        // Properties
        public double? Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The display size cannot be lesser than 0!");
                }

                this.size = value;
            }
        }

        public string NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The display colors must contain more than 2 characters!");
                }

                this.numberOfColors = value;
            }
        }

        // Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\n-Size: {0}", this.size);
            result.AppendFormat("\n-Number of colors: {0}", this.numberOfColors);
            return result.ToString();
        }
    }
}