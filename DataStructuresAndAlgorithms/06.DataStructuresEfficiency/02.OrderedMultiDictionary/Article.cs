
namespace OrderedMultiDictionary
{
    using System;

    public class Article : IComparable
    {
        private string barcode;
        private string vendor;
        private string title;
        private double price;

        public Article(string barcode, string vendor, string title, double price)
        {
            this.barcode = barcode;
            this.vendor = vendor;
            this.title = title;
            this.price = price;
        }

        public string Barcode
        {
            get
            {
                return this.barcode;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("barcode", "The barcode of the article cannot be null or whitespace!");
                }
                this.barcode = value;
            }
        }

        public string Vendor
        {
            get
            {
                return this.vendor;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("vendor", "The vendor of the article cannot be null or whitespace!");
                }
                this.vendor = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("title", "The title of the article cannot be null or whitespace!");
                }
                this.title = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("price", "The price of the product has to be positive!");
                }

                this.price = value;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Article otherArticle = obj as Article;
            if (otherArticle != null)
            {
                return this.Price.CompareTo(otherArticle.Price);
            }
            else
            {
                throw new ArgumentException("Object is not an Article");
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Article: {0}\nBarcode: {1}\nVendor: {2}",
                this.title,
                this.barcode,
                this.vendor);
        }
    }
}
