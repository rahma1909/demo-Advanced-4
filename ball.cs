using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

    //publisher
    class ball
    {

        public int id { get; set; }

        public location location;

        public location Location { get { return Location; } set {
                if (!value.Equals(location))
                {
                    location = value;
                    //fire event
                    on_locationChanged();
                }


            } }

        public event EventHandler<customEventArgs>? locationChanged; //nullable action

        protected void on_locationChanged()
        {
            locationChanged?.Invoke(this, new customEventArgs() { massage="hello"});
        }
        public override string ToString()
        {
            return $"ball id :{id}";
        }
    }
}
