using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// import data
using System.Data.OleDb; // import data
using System.IO; // import

namespace COMS_276_Program4
{
    class clsData
    {
        string _strConnectionString = clsGlobal.DatabaseConnectionString; // varible to link to connectionstring property
        string _strSQL = "";// variable to link to sql property
        DataTable dtData; // data table for data from databse

        // String to contain connection string to database
        public string ConnectionString
        {
            get
            {
                return _strConnectionString;
            }
            set
            {
                _strConnectionString = value;
                FillDataTable();
            }
        }

        // store quary to database
        public string SQL
        {
            get
            {
                return _strSQL;
            }
            set
            {
                _strSQL = value;
                FillDataTable(); // fill the data table
            }
        }

        // Data table accessible from application
        public DataTable dt
        {
            get
            {
                return dtData;
            }
            set
            {
                dtData = value;
            }
        }

        // Fill database with data from database based on properties of SQL and ConnectionString

        private void FillDataTable()
        {
            // if connection string and sql are filled, continue
            if (ConnectionString != "" && SQL != "")
            {
                // create connection to database
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                // Open connection
                conn.Open();
                // create dataset
                DataSet ds = new DataSet();
                // fill dataset with data adaptor
                OleDbDataAdapter adaptor = new OleDbDataAdapter(SQL, ConnectionString);
                adaptor.Fill(ds);
                // close connection to database
                conn.Close();
                // fill database with data set
                dtData = ds.Tables[0];
            }
        }

        public void CreateEquipment (string EquipmentName, string PurchaseDate, string Notes )
        {
            // create sql statement for new customer
            SQL = "SELECT ID, EquipmentName, PurchaseDate, Notes FROM tblEquipment WHERE ID = 0";
            // create connection to database
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            // Open connection
            conn.Open();
            // create dataset
            DataSet ds = new DataSet();
            // fill dataset with data adaptor
            OleDbDataAdapter adaptor = new OleDbDataAdapter(SQL, ConnectionString);
            adaptor.Fill(ds);
            // create data row
            DataRow dr = ds.Tables[0].NewRow();
            // update values in data row
            dr["EquipmentName"] = EquipmentName;
            dr["PurchaseDate"] = PurchaseDate;
            dr["Notes"] = Notes;

            // add data row to table
            ds.Tables[0].Rows.Add(dr);

            // create command builder
            System.Data.OleDb.OleDbCommandBuilder cb = new System.Data.OleDb.OleDbCommandBuilder(adaptor);

            // update adaptor
            adaptor.Update(ds.Tables[0]);

            //close connection 
            conn.Close();

        }

        public void DeleteRecord(string _SQLStatement)
        {
            // create connection to database
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            // Open connection
            conn.Open();
            // create command
            OleDbCommand command = new OleDbCommand(_SQLStatement, conn);
            // execute command
            command.ExecuteNonQuery();
            // close connection
            conn.Close();

        }// end method



        public void UpdateData(DataTable _DataTable, string _SQLStatement)
        {
            // update property with _SQL Statement
            SQL = _SQLStatement;
            // if connection string and sql are filled, continue
            if (ConnectionString != "" && SQL != "")
            {
                // create connection to database
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                // Open connection
                conn.Open();
                // create dataset
                DataSet ds = new DataSet();
                // fill dataset with data adaptor
                OleDbDataAdapter adaptor = new OleDbDataAdapter(SQL, ConnectionString);
                adaptor.Fill(ds);

                // create command builder
                System.Data.OleDb.OleDbCommandBuilder cb = new System.Data.OleDb.OleDbCommandBuilder(adaptor);

                // update database with datatable
                adaptor.Update(_DataTable);

                // close connection to database
                conn.Close();
               
            }// end if

        }// end method
    }
}
