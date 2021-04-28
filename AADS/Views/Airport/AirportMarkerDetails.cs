using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    class AirportMarkerDetails
    {
        public static string LattitudeLng;
        public static double Lattitude;
        public static double Lngtitude;

        public static bool airportOpen;
        public static Dictionary<string, string> openWith =
                                                new Dictionary<string, string>();
    }
    
    class MarkerDetails
    {
        public string filter;
        public string nameMarker;
        public string labelMarker;
        public string country;
        public string province;
        public int aircraft;
        public string typeAirport;

        //aircraft
        public string type;
        public static int quantity;

    }

    public class ListMarkerdetail
    {
        public static List<string> LatLng = new List<string>();
        public static List<string> filter = new List<string>();
        public static List<string> nameMarker = new List<string>();
        public static List<string> labelMarker = new List<string>();
        public static List<string> country = new List<string>();
        public static List<string> province = new List<string>();
        public static List<string> typeAirport = new List<string>();
        public static List<int> Tag = new List<int>();

    }

}
