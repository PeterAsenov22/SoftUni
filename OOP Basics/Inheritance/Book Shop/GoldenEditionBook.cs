﻿namespace Book_Shop
{
    public class GoldenEditionBook : Book
    {   
        public GoldenEditionBook(string author, string title, decimal price)
            :base(author,title,price)
        {
            base.price = price + (decimal)((price * 30) / 100);
        }
    }
}
