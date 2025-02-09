using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

 

    internal class movie:IEquatable<movie>
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
    }
}
