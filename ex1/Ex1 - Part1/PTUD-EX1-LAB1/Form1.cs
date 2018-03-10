using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_EX1_LAB1
{
    public partial class Form1 : Form
    {
        public Location location;
        public string GOOGLE_API_KEY = "AIzaSyCSelmZHzPFMcqEVrN-VYbiywZ32fXBIf8";

        public Form1()
        {
            InitializeComponent();
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            if(tLong.Text.Length == 0 || tLat.Text.Length == 0)
            {
                MessageBox.Show("Please Input Data!!!!!");
                return;
            }

            try
            {
                location = new Location();
                location.lat = double.Parse(tLat.Text.Trim());
                location.lng = double.Parse(tLong.Text.Trim());
            } catch (FormatException ex)
            {
                MessageBox.Show("Wrong Location!!!");
            }
            using (var client = new HttpClient())
            {
                
                var response = client.GetStringAsync(string.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={0},{1}&radius=500&type=bar&key={2}", location.lat, location.lng, GOOGLE_API_KEY));
              
                PlacesApiQueryResponse result = JsonConvert.DeserializeObject<PlacesApiQueryResponse>(response.Result);
                StringBuilder add = new StringBuilder();
                for (int i = 0; i < result.results.Count; i++) {
                    String temp = string.Format("{0} - {1}", result.results[i].name, result.results[i].vicinity);
                    add.Append("\n" + temp);
                }
                lResult.Text = add.ToString();
            }
        }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Result
    {
        public string name { get; set; }
        public string vicinity { get; set; }
    }

    public class PlacesApiQueryResponse
    {
        public List<Result> results { get; set; }
    }

}
