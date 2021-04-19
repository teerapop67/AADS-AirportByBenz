using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.ShowCategory
{
    public partial class Line : UserControl
    {
        public Line()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            var CorridorPage = new Views.Corridor.mains();
            panelShowDetail.Controls.Clear();
            panelShowDetail.Controls.Add(CorridorPage);
        }
    }
}
