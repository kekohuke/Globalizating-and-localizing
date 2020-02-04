using System;
using System.Globalization;

namespace Location{
    public class Location
    {
        CultureInfo cultureInfo;
        RegionInfo region;
        string EnglishName;
        string CultureName;
        string CurrencyEnglishName;
        public Location(string cultureName){
            region = new RegionInfo(cultureName);
            EnglishName = region.EnglishName;
            CultureName = cultureName;
            CurrencyEnglishName = region.CurrencyEnglishName;
            cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);
        }
        public string GetEnglishName()
        {
            return EnglishName;                                 
        }
        public string GetTime()
        {
            return DateTimeOffset.Now.ToString(cultureInfo);                              
        }
    }
}