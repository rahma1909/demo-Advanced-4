using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    //sunscriber 
    internal class player
    {

        public string? Name { get; set; }
        public string? Team { get; set; }

        public void Run(object? sender, customEventArgs e)
        {
            ball? ballsender = sender as ball;
            Console.WriteLine($"{this.ToString()} is runnning to {ballsender?.location} from this ball:{ballsender}");
        }
        public override string ToString()
        {
            return $"player name {Name} in team {Team}";
        }

       
    }
}
