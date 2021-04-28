using System;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;

namespace AADS.Views.Corridor
{
    public partial class mains : UserControl
    {

        private static mainForm mainInstance = mainForm.GetInstance();
        private GMapControl map = mainInstance.GetmainMap();
        private List<PointLatLng> LatLngSide1;
        private Dictionary<GMapRoute, string> keepAllRoute = new Dictionary<GMapRoute, string>();
        private List<PointLatLng> LatLngSide2;
        bool btnWasClick1;
        bool btnWasClick2;
        int counterSide1 = 1;
        int counterSide2 = 1;
        private GMapRoute delRoute;


        public mains()
        {
            InitializeComponent();
            LatLngSide1 = new List<PointLatLng>();
            LatLngSide2 = new List<PointLatLng>();
            mainInstance._GetPoint += MainInstance__GetPoint;
            mainInstance.RouteCurrent += MainInstance_RouteCurrent;
        }

        private void MainInstance_RouteCurrent(object sender, GMapRoute e)
        {
            delRoute = e;
            MessageBox.Show(delRoute.ToString());
        }

        private void MainInstance__GetPoint(object sender, PointLatLng e)
        {
            if (OpenCorridor.OpenCorridors && btnWasClick1 && AirportMarkerDetails.Lattitude != 0)
            {

                LatLngSide1.Add(new PointLatLng(AirportMarkerDetails.Lattitude, AirportMarkerDetails.Lngtitude));
                setListBoxPoint();
                CreateCorridorSide1();

            }
            if (OpenCorridor.OpenCorridors && btnWasClick2 && AirportMarkerDetails.Lattitude != 0)
            {
                LatLngSide2.Add(new PointLatLng(AirportMarkerDetails.Lattitude, AirportMarkerDetails.Lngtitude));
                setListBoxPoint();
                CreateCorridorSide2();
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSide1_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem != null)
            {
                btnWasClick2 = false;
                btnWasClick1 = true;
            }
            else
            {
                MessageBox.Show("Please Select Type", "Warnning");
            }

        }

        private void btnSide2_Click(object sender, EventArgs e)
        {

            if (cmbType.SelectedItem != null)
            {
                btnWasClick2 = true;
                btnWasClick1 = false;
            }
            else
            {
                MessageBox.Show("Please Select Type", "Warnning");
            }
            

        }

        private void mains_Load(object sender, EventArgs e)
        {
            OpenCorridor.OpenCorridors = true;
            cmbType.Items.Add("Safe Passage");
            cmbType.Items.Add("Others");

        }

        void setListBoxPoint()
        {
            if (btnWasClick1)
            {
                listPoint.Items.Add("Point" + counterSide1 + "=" + " " + LatLngSide1[counterSide1-1].ToString());
                counterSide1++;
            }
            else if (btnWasClick2)
            {
                listPoint.Items.Add("Point" + counterSide1 + "=" + " " + LatLngSide2[counterSide2-1].ToString());
                counterSide1++;
                counterSide2++;

            }
        }

        void CreateCorridorSide1()
        {
            GMapRoute c = new GMapRoute(LatLngSide1, "Corridor1");
            if(cmbType.Text == "Safe Passage")
            {
                c.Stroke.Width = 1;
                c.Stroke.Color = Color.Red;
            }
            else
            {
                c.Stroke.Width = 1;
                c.Stroke.Color = Color.Blue;
            }
            keepAllRoute.Add(c, cmbType.Text);

            GMapOverlay corridorOverlay = mainForm.GetInstance().GetOverlay("lineDistance");

            corridorOverlay.Routes.Add(c);
            map.Overlays.Add(corridorOverlay);
            map.Refresh();

        }

        void CreateCorridorSide2()
        {
            GMapRoute c = new GMapRoute(LatLngSide2, "Corridor2");
            if (cmbType.Text == "Others")
            {
                c.Stroke.Width = 1;
                c.Stroke.Color = Color.Blue;
            }
            else
            {
                c.Stroke.Width = 1;
                c.Stroke.Color = Color.Red;
            }
            keepAllRoute.Add(c, cmbType.Text);

            GMapOverlay corridorOverlay = mainForm.GetInstance().GetOverlay("lineDistance");

            corridorOverlay.Routes.Add(c);
            map.Overlays.Add(corridorOverlay);
            map.Refresh();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cmbType.Text = "Select Type";
            counterSide1 = 1;
            counterSide2 = 1;
            btnWasClick1 = false;
            btnWasClick2 = false;
            mains reset = new mains();
            LatLngSide1.Clear();
            LatLngSide2.Clear();
            listPoint.Items.Clear();
            reset.InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
           if(delRoute != null)
            {
                keepAllRoute.Remove(delRoute);
            }
        }
    }
}
