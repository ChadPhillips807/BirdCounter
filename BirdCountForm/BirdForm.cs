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
            // The following List variables have data used to query the Birds DB
            List<string> regionQuery = new List<string>() { "Region", "RegionName" };
            List<string> birderQuery = new List<string>() { "Birder", "FirstName" };
            List<string> birdQuery = new List<string>() { "Bird", "Name" };

            // The following List variables hold the data retrieved from the Birds DB
            List<String> regionResults = BirdCounterDataAccess.GetData(regionQuery);
            List<String> birderResults = BirdCounterDataAccess.GetData(birderQuery);
            List<String> birdResults = BirdCounterDataAccess.GetData(birdQuery);

            // Populate the combo boxes with the respective queries
            regionComboBox.DataSource = regionResults;
            birderComboBox.DataSource = birderResults;
            birdTypeComboBox.DataSource = birdResults;
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<string> formEntries = CreateEntriesList();
            
            // wasEntered
            int wasEntered = 0;
            wasEntered = BirdCounterDataAccess.AddData(formEntries);

            if (wasEntered == 1)
            {
                MessageBox.Show("Entry inserted");
            }
            else
            {
                MessageBox.Show("Entry not inserted");
            }
        }

        private List<string> CreateEntriesList()
        {
            // The following List contains the values to be inserted into the BirdCount table
            List<string> formEntries = new List<string>();

            // Add values to be inserted into the DB to the formEntries List
            formEntries.Add(regionComboBox.SelectedItem.ToString());// Region Name
            formEntries.Add(birderComboBox.SelectedItem.ToString());// Birder Name
            formEntries.Add(birdTypeComboBox.SelectedItem.ToString());// Bird Type
            formEntries.Add(birdCountDatePicker.Value.ToString());// Count Date
            formEntries.Add(numOfBirdsNumericUpDown.Value.ToString());// Bird Count
            return formEntries;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            List<string> formEntries = CreateEntriesList();

            MessageBox.Show(BirdCounterDataAccess.CountBirds(formEntries).ToString());
            
        }
    }
}
