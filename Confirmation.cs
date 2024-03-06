using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Confirmation : Form
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Message { get; set; }
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            label1.Text =Latitude.ToString();

            label2.Text = Longitude.ToString();
            label3.Text = Message;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void wb_but_Click(object sender, EventArgs e)
        {

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "waypoint.txt");

            string newLatitude = Latitude; // New latitude value
            string newLongitude = Longitude; // New longitude value

            if (!File.Exists(filePath))
            {
                // Create the file and write the initial line
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("QGC WPL 110");
                }
            }


            List<string> lines = new List<string>();
            int waypointCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                    if (waypointCount == 2) // Assuming the second waypoint is the second line (index 1)
                    {
                        // Split the line into fields
                        string[] fields = line.Split('\t');
                        if (fields.Length >= 10) // Ensure there are enough fields
                        {
                            // Update the latitude and longitude
                            fields[8] = newLatitude; // 9th field is latitude
                            fields[9] = newLongitude; // 10th field is longitude

                            // Reconstruct the line with the updated fields
                            lines[lines.Count - 1] = string.Join("\t", fields);
                        }
                        // Exit the loop after updating the second waypoint
                    }
                    waypointCount++;
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            //MessageBox.Show("The second waypoint has been updated successfully.");
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
