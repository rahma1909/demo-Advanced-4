namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region simple game example 1 --event-driven programmimg 

            //ball Ball = new ball() { id = 0,new location() { X = 0, Y = 0, Z = 0 } };//invalid bec parameterless constructor in the struct location
            //will intilize every single attr with default value
            ball Ball = new ball() { id = 111 };
            ball Ball01 = new ball() { id = 222 };

            //Console.WriteLine(Ball.Location);


            //team1
            player p11 = new player()
            {
                Name="paderi",
                Team="barce"
            };
            player p21 = new player()
            {
                Name = "yamal",
                Team = "barce"
            };


            //team 2
            player p12 = new player()
            {
                Name = "vini",
                Team = "madrid"
            };
            player p22 = new player()
            {
                Name = "rodri",
                Team = "madrid"
            };




            Refree R1 = new Refree()
            {
                Name = "grisha"
            
             
            };

            //subscription

            Ball.locationChanged += p11.Run;
            Ball.locationChanged += p21.Run;
            Ball.locationChanged += p12.Run;
            Ball.locationChanged += p22.Run;


            Ball.locationChanged += R1.look;

            Ball01.locationChanged += p11.Run;
            Ball01.locationChanged += p21.Run;
            Ball01.locationChanged += p12.Run;
            Ball01.locationChanged += p22.Run;


            Ball01.locationChanged += R1.look;
            Console.WriteLine("*****************************match is started now*************************");

            Ball01.Location = new location() { X = 10, Y = 20, Z = 30 };

            Console.WriteLine("*****************************after yamal is fired*************************");
            //Ball.locationChanged -= p21.Run; //unsubscribe
            //Ball.Location = new location() { X = 10, Y = 20, Z = 40 };



            #endregion

        }
    }
}
