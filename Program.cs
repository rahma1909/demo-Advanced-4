using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace demo
{

    #region generic string equality
    class stringequality : IEqualityComparer<string>
    {


        public bool Equals(string? x, string? y)
        {


            return x?.ToLower().Equals(y) ?? (y is null ? true : false);
        }


        public int GetHashCode([DisallowNull] string other)
        {
            if (other is null)

                return 0;
            return other.ToLower().GetHashCode();
        }
    }
    #endregion

    #region non generic stringequality
    //class stringequality : IEqualityComparer
    //{
    //    public new bool Equals(object? x, object? y)
    //    {
    //        string? strx = x as string;
    //        string? stry = y as string;

    //        return strx?.ToLower().Equals(stry) ?? (stry is null ? true : false);
    //    }

    //    public int GetHashCode(object obj)
    //    {
    //        string? other = obj as string;

    //        if (other is null)

    //            return 0;
    //        return other.ToLower().GetHashCode();
    //    }
    //} 
    #endregion


    #region old syntax
    //class customhashcodeprovider : IHashCodeProvider
    //{
    //    public int GetHashCode(object obj)
    //    {
    //        string? other = obj as string;

    //        if (other is null)

    //            return 0;
    //        return other.ToLower().GetHashCode();
    //    }
    //}

    //class customcomparer : IComparer
    //{
    //    public int Compare(object? x, object? y)
    //    {
    //      string?  strx = x as string;
    //      string?  stry = y as string;

    //        return strx?.ToLower().CompareTo(stry) ?? (stry is null ? 0 : -1);
    //    }
    //} 
    #endregion

    #region sorted dictionary
    class stringcomparerdesc : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return y?.CompareTo(x) ?? (x is null ? 0 : -1);
        }
    }


    #endregion

    #region sorted list ex02
    class descsotednumcomparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            //return -x.CompareTo(y);//descinding
            //return y.CompareTo(x);//descinding
            return y - x;//sorting descinding
        }
    }



    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            #region simple game example 1 --event-driven programmimg 

            ////ball Ball = new ball() { id = 0,new location() { X = 0, Y = 0, Z = 0 } };//invalid bec parameterless constructor in the struct location
            ////will intilize every single attr with default value
            //ball Ball = new ball() { id = 111 };
            //ball Ball01 = new ball() { id = 222 };

            ////Console.WriteLine(Ball.Location);


            ////team1
            //player p11 = new player()
            //{
            //    Name="paderi",
            //    Team="barce"
            //};
            //player p21 = new player()
            //{
            //    Name = "yamal",
            //    Team = "barce"
            //};


            ////team 2
            //player p12 = new player()
            //{
            //    Name = "vini",
            //    Team = "madrid"
            //};
            //player p22 = new player()
            //{
            //    Name = "rodri",
            //    Team = "madrid"
            //};




            //Refree R1 = new Refree()
            //{
            //    Name = "grisha"


            //};

            ////subscription

            //Ball.locationChanged += p11.Run;
            //Ball.locationChanged += p21.Run;
            //Ball.locationChanged += p12.Run;
            //Ball.locationChanged += p22.Run;


            //Ball.locationChanged += R1.look;

            //Ball01.locationChanged += p11.Run;
            //Ball01.locationChanged += p21.Run;
            //Ball01.locationChanged += p12.Run;
            //Ball01.locationChanged += p22.Run;


            //Ball01.locationChanged += R1.look;
            //Console.WriteLine("*****************************match is started now*************************");

            //Ball01.Location = new location() { X = 10, Y = 20, Z = 30 };

            Console.WriteLine("*****************************after yamal is fired*************************");
            //Ball.locationChanged -= p21.Run; //unsubscribe
            //Ball.Location = new location() { X = 10, Y = 20, Z = 40 };



            #endregion

            #region non generic collection hashtable
            //**********************************************************
            //Hashtable note = new Hashtable()
            //{
            //    {"ahmed",333 },{"salah",999 },{"mo",666 },//object intilizer
            //};

            //Hashtable note02 = new Hashtable(note);//idictionary


            ////note.Add("ahmed", 333);//will accept it
            //foreach (DictionaryEntry person in note)
            //{
            //    Console.WriteLine($"{person.Key}::::{person.Value}");
            //}

            //**********************************************************

            //Hashtable note = new Hashtable(new customhashcodeprovider(),new customcomparer())
            //{
            //    {"ahmed",333 },{"salah",999 },{"mo",666 },//object intilizer
            //};

            ////note.Add("ahmed", 333);//invalid
            //foreach (DictionaryEntry person in note)
            //{
            //    Console.WriteLine($"{person.Key}::::{person.Value}");
            //}

            //**********************************************************
            //Hashtable note = new Hashtable(new stringequality())
            //{
            //    {"ahmed",333 },{"salah",999 },{"mo",666 },//object intilizer
            //};

            ////note.Add("ahmed", 333);//invalid
            //foreach (DictionaryEntry person in note)
            //{
            //    Console.WriteLine($"{person.Key}::::{person.Value}");
            //}

            //*****************************************************

            //Hashtable note = new Hashtable()
            //{
            //    {"ahmed",333 },{"salah",999 },{"mo",666 },//object intilizer
            //};

            #region ADD
            //note.Add("ahmed", 333);//invalid

            //note.Add("omar", 333);//unsafe

            //safe
            //if (!note.ContainsKey("omar"))
            //{
            //    note.Add("omar", 333);
            //}

            //note.tryadd("omar", 333) 

            //note["manaer"] = 666; //indexer
            #endregion

            #region retrive(get)
            //Console.WriteLine(note["manar"]??"na");

            //note.TryGetVlaue("key",out int value);


            #endregion

            //***************************just for printing*****************************
            //foreach (DictionaryEntry person in note)
            //{
            //    Console.WriteLine($"{person.Key}::::{person.Value}");
            //}

            #endregion

            #region generic hashtable-dictionary -ex01


            //Dictionary<string, int> note = new Dictionary<string, int>()
            //{
            //    {"ahmed",333 },
            //    {"omar",333 },
            //    {"mo",333 },
            //};

            //Dictionary<string, int> note02 = new Dictionary<string, int>(note);




            ////note.Add("ahmed",333);//valid




            //foreach (var person in note)//bec inside it getenumrator
            //{
            //    Console.WriteLine($"{person.Key}:::{person.Value}");
            //}
            //***************************************************************

            //KeyValuePair<string, int>[] keyvalue =
            //{
            //    new KeyValuePair<string, int>("mona",1232),
            //    new KeyValuePair<string, int>("hamdy",1232),
            //};
            //Dictionary<string, int> note = new Dictionary<string, int>(new stringequality())
            //{
            //    {"ahmed",333 },
            //    {"omar",333 },
            //    {"mo",333 },
            //};

            //Dictionary<string, int> note02 = new Dictionary<string, int>(note,new stringequality());
            //Dictionary<string, int> note02 = new Dictionary<string, int>(keyvalue);//ienumrable





            //note.Add("ahmed",333);//invalid : An item with the same key has already been added.

            #region add

            //note.Add("ahmed",222);//unsafe

            //if (!note.ContainsKey("ahmed"))
            //    note.Add("ahmed", 111);//safe
            //else
            //{
            //    note["ahmed"] = 333;//update if the value exist using indexer
            //}

            //if(!note.TryAdd("ahmed", 333))
            // {
            //     //update
            //     note["ahmed"] = 333;
            // }

            //note["ahmed"] = 888;//using indexer update and set



            #endregion

            #region get
            //Console.WriteLine(note["ahmed"]);//unsafe

            ////safe
            //if (note.ContainsKey("ahmed"))
            //{
            //    Console.WriteLine(note["ahmed"]);
            //}

            //note.TryGetValue("ahmed", out int value);
            //Console.WriteLine($"value: {value}");


            #endregion


            //foreach (KeyValuePair<string, int> person in note)//bec inside it getenumrator
            //{
            //    Console.WriteLine($"{person.Key}:::{person.Value}");
            //}


            #endregion


            #region generic hashtable-dictionary -ex02


            //Dictionary<employee, string> employees = new Dictionary<employee, string>(new employeeequalitycomar())
            //{
            //    { new employee(1,"ahmed",12356),"employee with id 1" },
            //    { new employee(10,"omar",1236),"employee with id 10" },


            //};


            //employees.Add(new employee(1, "ahmed", 12356), "employee with id 1");// An item with the same key has already been added. Key: id:1,name:ahmed,salary:12356


            //employee emp01 = new employee(10, "ahmed", 2000);

            //Dictionary<employee, string> employees = new Dictionary<employee, string>()
            //{
            //    { emp01,"employee with id 1" },
            //    { new employee(10,"omar",1236),"employee with id 10" },


            //};




            //emp01.id = 50;//must be immutable

            //employees.Add(new employee(50, "eyad", 12356), "employee with id 50");//key must be immutable type
            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.Key}");
            //}

            #endregion


            #region sorted dictionary- generic collection [binary search tree]
            //SortedDictionary<string, int> sortednode = new SortedDictionary<string, int>();


            //sortednode.Add("ahmed", 10);
            //sortednode.Add("omnia", 30);
            //sortednode.Add("rahma", 20);
            //sortednode.Add("mahmoud", 5);

            //foreach (var person in sortednode)
            //{
            //    Console.WriteLine($"{person.Key}, {person.Value}");//sorted
            //}


            //**********************************
            #region ex01
            //SortedDictionary<string, int> sortednode = new SortedDictionary<string, int>( new stringcomparerdesc());//desending


            //sortednode.Add("ahmed", 10);
            //sortednode.Add("omnia", 30);
            //sortednode.Add("rahma", 20);
            //sortednode.Add("mahmoud", 5);

            //foreach (var person in sortednode)
            //{
            //    Console.WriteLine($"{person.Key}, {person.Value}");//sorted
            //} 
            #endregion

            #region ex02
            //SortedDictionary<employee, string> sortedemp = new SortedDictionary<employee, string>(new empicomparer())//based on name length
            //{
            //    { new employee(1,"ahmed",2_000) ,"emp 1"},
            //    { new employee(3,"mo",2_000) ,"emp 2"},
            //    { new employee(2,"weal",2_000) ,"emp 3"},


            //};

            //foreach (var person in sortedemp)
            //{
            //    Console.WriteLine($"{person.Key}, {person.Value}");
            //}
            #endregion

            #endregion

            #region generic collections- sorted list

            //SortedList<string, int> sortednote = new SortedList<string, int>()
            //{
            //    {"ahmed",333 },
            //    {"omar",333 },
            //    {"mo",333 },
            //};

            //Console.WriteLine(sortednote.GetValueAtIndex(0));
            //Console.WriteLine(sortednote.GetKeyAtIndex(0));


            //foreach (var item in sortednote)
            //{
            //    Console.WriteLine($"{item.Key}::{item.Value}");
            //}
            #endregion

            #region generic collections- sorted list ex02

            //SortedList<int, string> sortednums = new SortedList<int, string>(new descsotednumcomparer())
            //{
            //    { 2,"two"},
            //    { 3,"three"},
            //    { 1,"one"},
            //};


            //foreach (var item in sortednums)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



        }
    }
}
