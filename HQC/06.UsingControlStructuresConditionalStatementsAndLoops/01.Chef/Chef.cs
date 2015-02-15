namespace Chef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Chef
    {
        public Vegetable GetVegetable()
        {
            return new Vegetable();
        }

        public Vegetable Peel(Vegetable vegetable)
        {
            vegetable.HasBeenPeeled = true;

            return vegetable;
        }

        public Vegetable Cut(Vegetable vegetable)
        {
            vegetable.HasBeenCut = true;

            return vegetable;
        }

        public Bowl GetBowl()
        {
            return new Bowl();
        }

        public void Cook(Vegetable vegetable)
        {
            vegetable = this.GetVegetable();

            this.Peel(vegetable);

            this.Cut(vegetable);

            Bowl bowl = this.GetBowl();
            bowl.BowlList.Add(vegetable);
        }
    }
}
