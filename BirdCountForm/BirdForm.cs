using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLib;

namespace BirdCountForm
{
    public partial class birdCountForm : Form
    {
        public birdCountForm()
        {
            InitializeComponent();
        }

        

        private void birdCountForm_Load(object sender, EventArgs e)
        {
            List<string> regionQuery = new List<string>() { "Region", "RegionName" };
            List<string> birderQuery = new List<string>() { "Birder", "FirstName" };
            List<string> birdQuery = new List<string>() { "Bird", "Name" };



            List<String> regionResults = BirdCounterDataAccess.GetData(regionQuery);
            List<String> birderResults = BirdCounterDataAccess.GetData(birderQuery);
            List<String> birdResults = BirdCounterDataAccess.GetData(birdQuery);
            
            regionComboBox.DataSource = regionResults;
            birderComboBox.DataSource = birderResults;
            birdTypeComboBox.DataSource = birdResults;
            
            
        }
    }
}
