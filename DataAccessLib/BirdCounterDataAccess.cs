using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public static class BirdCounterDataAccess
    {
        // Once birds db is added to SQL
        // TODO: ADD CONNECTOIN STRING!!
        private const string connectionString = @"Server=SLAVE_1\SQLEXPRESS;Database=Birds;Integrated Security=SSPI";

        //  Region where the birds were observed. A list of regions should be retrieved
        //  from the database and the user should be able to choose from the list.
        public static List<string> GetData(List<string> query)
        {

            string tableName = query[0];
            string columnName = query[1];
          
            SqlCommand selectCommand;

            SqlDataReader sqlReader;

            List<string> queryResultList;

            selectCommand = new SqlCommand();

            try
            {
                selectCommand.Connection = new SqlConnection();
                selectCommand.Connection.ConnectionString = connectionString;
                //Get data by setting List<string> variable = to query of Birds DB
                //then pass it to Combo box.

                selectCommand.CommandText = "SELECT " + columnName + " FROM " + tableName;
                selectCommand.Connection.Open();

                sqlReader = selectCommand.ExecuteReader();

                queryResultList = new List<string>();

                while (sqlReader.Read())
                {
                    queryResultList.Add((string)sqlReader[columnName]);
                }

                sqlReader.Close();

                return queryResultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int AddData(List<string> birdCountData)
        {
            //(string tableName, string idColumn, string columnName, string tableValue)
            string birdTable = "Bird";
            string birdIdColumn = "BirdID";
            string birdNameColumn = "Name";

            string birderTable = "Birder";
            string birderIdColumn = "BirderID";
            string birderNameColumn = "FirstName";

            string regionTable = "Region";
            string regionIdColumn = "RegionID";
            string regionNameColumn = "RegionName";

            // The following variables represent a row in the BirdCount table
            // TODO - Get region ID
            string regionId = getRowId(regionTable, regionIdColumn, regionNameColumn, birdCountData[0]);

            // TODO - Get birder ID
            string birderId = getRowId(birderTable, birderIdColumn, birderNameColumn, birdCountData[1]);

            //TODO - Get Bird ID
            string birdId = getRowId(birdTable, birdIdColumn, birdNameColumn, birdCountData[2]);

            DateTime countDate = DateTime.Parse(birdCountData[3]);
            int countOfBirds = Convert.ToInt32(birdCountData[4]);

            SqlCommand insertCommand;
            int rowsAffected;

            insertCommand = new SqlCommand();

            try
            {
                insertCommand.Connection = new SqlConnection();
                insertCommand.Connection.ConnectionString = connectionString;

                insertCommand.CommandText = "INSERT INTO BirdCount"
                    + "(RegionID, BirderID, BirdID, CountDate, Counted)"
                    + "VALUES('" + regionId + "', '" + birderId + "', '" + birdId + "', '" + countDate + "', '" + countOfBirds + "')";

                insertCommand.Connection.Open();

                rowsAffected = insertCommand.ExecuteNonQuery();

                return rowsAffected;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private static string getRowId(string tableName, string idColumn, string columnName, string tableValue)
        {
            SqlCommand selectCommand;

            SqlDataReader sqlReader;

            selectCommand = new SqlCommand();
            try
            {
                selectCommand.Connection = new SqlConnection();
                selectCommand.Connection.ConnectionString = connectionString;

                selectCommand.CommandText = "SELECT " + idColumn + " FROM " + tableName + " WHERE " + columnName + " = '" + tableValue + "'";
                selectCommand.Connection.Open();

                sqlReader = selectCommand.ExecuteReader();

                string result = "";

                while (sqlReader.Read())
                {
                    result = sqlReader[0].ToString();
                }
                sqlReader.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }           

        }

        // May need check box to disable bird count combo box
        public static int CountBirds(List<string> formEntries)
        {
            SqlCommand selectCommand;

            string region = formEntries[0];
            string birder = formEntries[1];
            string bird = formEntries[2];
            string countDate = formEntries[3];

            /*
              SELECT Counted
              FROM BirdCount as BC
              INNER JOIN Region as R on BC.RegionID = R.RegionID
              INNER JOIN Birder as BR on BC.BirderID = BC.BirderID
              INNER JOIN Bird as B on BC.BirdID = B.BirdID
              WHERE FirstName = 'Linda' 
              AND RegionName = 'East Lake Washington' 
              AND Name = 'Bushtit'
              AND CountDate = '2006-03-21 11:10:00'
            */
            string query = "SELECT Counted "
                + "FROM BirdCount as BC "
                + "INNER JOIN Region as R on BC.RegionID = R.RegionID "
                + "INNER JOIN Birder as BR on BC.BirderID = BC.BirderID "
                + "INNER JOIN Bird as B on BC.BirdID = B.BirdID "
                + "WHERE FirstName = 'firstName' "
                + "AND RegionName = 'regionName' "
                + "AND Name = 'birdName' "
                + "AND CountDate = 'countDate'";

            string birdCountQuery = query.Replace("firstName", birder);
            birdCountQuery = birdCountQuery.Replace("regionName", region);
            birdCountQuery = birdCountQuery.Replace("birdName", bird);
            birdCountQuery = birdCountQuery.Replace("countDate", countDate);

            selectCommand = new SqlCommand(birdCountQuery, new SqlConnection(connectionString));
            try
            {
                selectCommand.Connection.Open();
                return Convert.ToInt32(selectCommand.ExecuteReader());
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                selectCommand.Connection.Close();
            }
        }
    }
}
