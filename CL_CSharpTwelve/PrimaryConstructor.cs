using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CSharpTwelve
{
    public class PrimaryConstructor(string name)
    {
        //Expression-bodied members (C# programming guide)
        public string Name => name?? "empty name";
    }

   public record User(string Name);

    //public class GeoPoint(decimal latitude, decimal longitude)
    //{
    //    public decimal Hemisphere => latitude >= 0 ? 'N' : 'S';
    //    public decimal Meridian => longitude >= 0 ? 'E' : 'W';
    //}

    public record GeoPointRecord(decimal latitude, decimal longitude) { }
    public class GeoPointClass(decimal latitude, decimal longitude) { }

}

