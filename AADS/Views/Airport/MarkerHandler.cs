using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public delegate void LandmarkAdd(LandmarkEventArgs e);
    public class LandmarkEventArgs : EventArgs
    {
        public string latLng { get; set; }
    }
    public class MarkerHandler
    {
        private static MarkerHandler _Instance;
        public static MarkerHandler Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MarkerHandler();
                }
                return _Instance;
            }
        }
        public event LandmarkAdd OnLandmarkAdd;
        public void InvokeLandmarkAdd(LandmarkEventArgs args)
        {

            if (AirportMarkerDetails.airportOpen)
            {
                OnLandmarkAdd.Invoke(args);
            }

        }
    }
}