using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace CansatGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Loadmapbtn_Click(object sender, EventArgs e)
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.MapProvider = GMapProviders.GoogleMap;
            double latitude = Convert.ToDouble(gmaplat_txt.Text);
            double longitude = Convert.ToDouble(gmaplong_txt.Text);
            gMap.Position = new GMap.NET.PointLatLng(latitude, longitude);
            gMap.MinZoom = 5;
            gMap.MaxZoom = 100;
            gMap.Zoom = 13;

            PointLatLng point = new PointLatLng(latitude, longitude);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            GMapOverlay overlay = new GMapOverlay("CANSAT");
            overlay.Markers.Add(marker);
            gMap.Overlays.Add(overlay);
        }

        private void gMap_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e) 
        {
        
        }


    }
}
