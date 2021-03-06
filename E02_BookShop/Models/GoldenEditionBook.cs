﻿namespace E02_BookShop.Models
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        { }

        protected override decimal Price
        {
            get { return base.Price * 1.3m; }
            set { base.Price = value; }
        }
    }
}