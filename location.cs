using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    struct location:IEquatable<location>
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public bool Equals(location other)
        {
            return this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z);
        }

        public override string ToString() =>

             $"X:{X} , Y:{Y} , Z:{Z}";

    }
}
