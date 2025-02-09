using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

    class moviecomparer : IComparer<movie>
    {
        public int Compare(movie? x, movie? y)
        {
            return x?.title.CompareTo(y?.title)??(y?.title is null? 0:-1);
        }
    }

    internal class movie:IEquatable<movie>,IComparable<movie>
    {
     

        public int id { get; set; }
        public string title { get; set; } = null!;
        public decimal  price { get; set; }

        public movie(int id, string title, decimal price)
        {
            this.id = id;
            this.title = title;
            this.price = price;
        }

        public override string ToString()=>
        
           $"id:{id},title:{title},price:{price}";

        public bool Equals(movie? other)
        {
            if (other is null) return false;
            return this.id.Equals(other.id) && this.title.Equals(other.title) && this.price.Equals(other.price);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(id, title, price);
        }

        public int CompareTo(movie? other)
        {
            if (other is null) return 1;

            return id.CompareTo(other.id);
        }
    }
}
