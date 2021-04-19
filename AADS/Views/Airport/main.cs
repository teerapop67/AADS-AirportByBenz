using Demo.WindowsForms.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.Airport
{

    public partial class main : UserControl
    {

        public int buttonClick;
        public MarkerHandler handler;
        private static mainForm mainInstance = mainForm.GetInstance();
        private GMapControl map = mainInstance.GetmainMap();
        MarkerDetails details = new MarkerDetails();
        //Dictionary<GMapMarker, MarkerDetails> Allmarkers = new Dictionary<GMapMarker, MarkerDetails>(); //keep all marker
        public static int temp = 0;

        public main()
        {
            handler = MarkerHandler.Instance;
            InitializeComponent();
            mainInstance.SelectMakrer += MainInstance_SelectMakrer1;
            mainInstance.MarkerCurrent += MainInstance_MarkerCurrent;
            buttonClick = 0;
            btnAdd.Text = "ADD";

        }
        GMapMarker CurrentMarkersSelect;

        private void MainInstance_MarkerCurrent(object sender, GMapMarker e)
        {
            CurrentMarkersSelect = e;
            /*PointLatLng getPoint = e.Position;
            var get = PositionConverter.ParsePointToString(getPoint, "Signed Degree");
            txtLocation.Text = get;*/

            //var pickdata = Allmarkers[e];
        }

        //private void radio_OnClick(object sender, EventArgs e)
        //{
        //    if (radioBtnBoth.Checked == true)
        //    {
        //        details.filter = radioBtnBoth.Text;
        //        MessageBox.Show("Both", "eee");
        //    }
        //    else if (radioBtnNeighbor.Checked == true)
        //    {
        //        details.filter = radioBtnNeighbor.Text;
        //        MessageBox.Show("neighbor", "eee");
        //        Debug.WriteLine("sdsd");
        //    }
        //    else if (radioBtnTH.Checked == true)
        //    {
        //        details.filter = radioBtnTH.Text;
        //        MessageBox.Show("thai", "eee");
        //    }
        //}

        void blankData()
        {
            txtName.Text = "";
            txtLabel.Text = "";
            txtCountry.Text = "";
            txtLocation.Text = "";
            txtProvince.Text = "";
            txtType.Text = "";
        }

        void editData()
        {
            ListMarkerdetail.nameMarker[indCurrentMarker] = (txtName.Text);
            ListMarkerdetail.labelMarker[indCurrentMarker] = (txtLabel.Text);
            ListMarkerdetail.province[indCurrentMarker] = (txtProvince.Text);
            ListMarkerdetail.country[indCurrentMarker] = (txtCountry.Text);
            ListMarkerdetail.typeAirport[indCurrentMarker] = (txtType.Text);
            ListMarkerdetail.LatLng[indCurrentMarker] = (txtLocation.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (AirportMarkerDetails.airportOpen && buttonClick == 0)
            {
                if (txtName.Text != "" && 
                    txtLabel.Text != "" && 
                    txtLocation.Text != "" &&
                    txtType.Text != "" &&
                    txtCountry.Text != "" &&
                    txtProvince.Text != ""
                    )
                {
                    if (txtLabel.TextLength <= 4 && txtType.TextLength <= 4 )
                    {
                        PointLatLng point = new PointLatLng(AirportMarkerDetails.Lattitude, AirportMarkerDetails.Lngtitude);
                        //Bitmap bmpMarker = (Bitmap)Image.FromFile("/Airport.png");
                        GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                        GMapOverlay markersOverlay = mainForm.GetInstance().GetOverlay("markersP");

                        //Allmarkers.Add(marker, details);
                        marker.Tag = temp += 1;
                        marker.ToolTipText = "\n" + txtName.Text + "\n" + txtLabel.Text;
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                        ListMarkerdetail.nameMarker.Add(txtName.Text);
                        ListMarkerdetail.labelMarker.Add(txtLabel.Text);
                        ListMarkerdetail.province.Add(txtProvince.Text);
                        ListMarkerdetail.country.Add(txtCountry.Text);
                        ListMarkerdetail.typeAirport.Add(txtType.Text);
                        ListMarkerdetail.LatLng.Add(txtLocation.Text);
                        ListMarkerdetail.Tag.Add(Convert.ToInt32(marker.Tag));
                        MessageBox.Show("ADD Completed", "ADD");
                        blankData();
                        //test
                    }
                    else
                    {
                        MessageBox.Show("only 4 character for Label and Type");

                    }
                }
                else
                {
                    MessageBox.Show("Please complete all infomation");
                }
                    
            }
            else if (AirportMarkerDetails.airportOpen && buttonClick == 1)
            {
                //EDIT 
                if (ListMarkerdetail.LatLng[indCurrentMarker] != txtLocation.Text)
                {
                    GMapOverlay markersOverlay = mainForm.GetInstance().GetOverlay("markersP");
                    markersOverlay.Markers.Remove(CurrentMarkersSelect);

                    PointLatLng point = new PointLatLng(AirportMarkerDetails.Lattitude, AirportMarkerDetails.Lngtitude);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);

                    //Allmarkers.Add(marker, details);
                    marker.Tag = indCurrentMarker;
                    marker.ToolTipText = "\n" + txtName.Text + "\n" + txtLabel.Text;
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    markersOverlay.Markers.Add(marker);
                    map.Overlays.Add(markersOverlay);
                    editData();
                    MessageBox.Show("EDIT Completed", "EDIT");
                    blankData();

                }
                else
                {
                    CurrentMarkersSelect.ToolTipText = "\n" + txtName.Text + "\n" + txtLabel.Text;
                    CurrentMarkersSelect.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    editData();
                    MessageBox.Show("EDIT Completed", "EDIT");
                    blankData();
                }
            }
            else
            {
                GMapOverlay markersOverlay = mainForm.GetInstance().GetOverlay("markersP");
                markersOverlay.Markers.Remove(CurrentMarkersSelect);
                ListMarkerdetail.nameMarker.RemoveAt(indMarkerDel);
                ListMarkerdetail.labelMarker.RemoveAt(indMarkerDel);
                ListMarkerdetail.province.RemoveAt(indMarkerDel);
                ListMarkerdetail.country.RemoveAt(indMarkerDel);
                ListMarkerdetail.typeAirport.RemoveAt(indMarkerDel);
                ListMarkerdetail.LatLng.RemoveAt(indMarkerDel);
                ListMarkerdetail.Tag.RemoveAt(indMarkerDel);
                blankData();
                map.Refresh();

            }


        }
        private void main_Load(object sender, EventArgs e)
        {
            handler.OnLandmarkAdd += new LandmarkAdd(button_onClick);
            AirportMarkerDetails.airportOpen = true;
            mainInstance.DelMarkerCurrent += MainInstance_DelMarkerCurrent;
        }

        int indMarkerDel;
        private void MainInstance_DelMarkerCurrent(object sender, int e)
        {
            indMarkerDel = e;
            buttonClick = 2;
            btnAdd.Text = "DELETE";
            txtLocation.Text = ListMarkerdetail.LatLng[e];
            txtName.Text = ListMarkerdetail.nameMarker[e];
            txtLabel.Text = ListMarkerdetail.labelMarker[e];
            txtProvince.Text = ListMarkerdetail.province[e];
            txtCountry.Text = ListMarkerdetail.country[e];
            txtType.Text = ListMarkerdetail.typeAirport[e];

            txtName.Enabled = false;
            txtLabel.Enabled = false;
            txtProvince.Enabled = false;
            txtCountry.Enabled = false;
            txtType.Enabled = false;
            txtLocation.Enabled = false;
        }

        int indCurrentMarker;
        private void MainInstance_SelectMakrer1(object sender, int e)
        {
            indCurrentMarker = e;
            buttonClick = 1;
            btnAdd.Text = "EDIT";
            txtLocation.Text = ListMarkerdetail.LatLng[e];
            txtName.Text = ListMarkerdetail.nameMarker[e];
            txtLabel.Text = ListMarkerdetail.labelMarker[e];
            txtProvince.Text = ListMarkerdetail.province[e];
            txtCountry.Text = ListMarkerdetail.country[e];
            txtType.Text = ListMarkerdetail.typeAirport[e];


        }



        private void button_onClick(LandmarkEventArgs args)
        {
            txtLocation.Text = args.latLng;
        }
    }
}
