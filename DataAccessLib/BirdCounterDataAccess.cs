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


        // Region where the birds were observed. A list of regions should be retrieved
        // from the database and the user should be able to choose from the list.
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
            catch (Exception)
            {

                throw;
            }

        }


        // Date of count

        // Birder (person doing the count). A list of birders should be retrieved from the database
        // and the user should be able to choose from the list.

        // Bird (e.g., robin, blue jay, towhee) A list of birds should be retrieved from the database and the user
        // should be able to choose from the list.


        // Number of birds observed

    }
}
