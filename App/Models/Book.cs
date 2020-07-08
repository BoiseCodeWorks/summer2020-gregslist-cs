using System.Collections;
using gregslist_cs.Interfaces;

namespace gregslist_cs.Models
{
    public class Book : IPurchasable, IEnumerable
    {
        public Book(double price)
        {
            this.Price = price;

        }
        public double Price { get; set; }

        public double CalculateTax(double rate)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}