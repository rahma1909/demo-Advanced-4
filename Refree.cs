using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Refree
    {

        public string? Name { get; set; }

        public void look(object? sender, customEventArgs e)
        {
            ball? ballsender = sender as ball;
            Console.WriteLine($"{this} is looking to {ballsender?.location} from this ball:{ballsender}");
        }
        public override string ToString()
        {
            return $"refree name {Name}";
        }

    }
}
