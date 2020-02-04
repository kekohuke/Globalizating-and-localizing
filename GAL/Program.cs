using System;
using Location;

using System.Globalization;
using System.Threading;
namespace GAL
{
    class Program
    {
        static void Main(string[] args)
        {  
            Location.Location US = new Location.Location("en-US");
            Console.WriteLine(US.GetEnglishName());
            Console.WriteLine(US.GetTime());
            
            Location.Location CN = new Location.Location("zh-CN");
            Console.WriteLine(CN.GetEnglishName());
            Console.WriteLine(CN.GetTime());
        }
    }
}
