using System;
using Location;
namespace GAL
{
    class Program
    {
        static void Main(string[] args)
        {  
            Location.Location loc1 = new Location.Location("en-US");
            Console.WriteLine(loc1.GetEnglishName());
        }
    }
}
