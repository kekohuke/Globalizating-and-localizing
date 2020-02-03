using System;
using System.Globalization;

namespace Location{
    public class Location
    {
        RegionInfo region;
        string EnglishName;
        string CultureName;
        string CurrencyEnglishName;
        public Location(string cultureName){
            region = new RegionInfo(cultureName);
            EnglishName = region.EnglishName;
            CultureName = cultureName;
            CurrencyEnglishName = region.CurrencyEnglishName;
        }
        public string GetEnglishName()
        {
            return EnglishName;                                 
        }
    }
}