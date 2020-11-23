using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics; 

namespace DBAccessDemo
{
    public partial class Form1 : Form
    {
        //Database connection attributes
        string connectionString;
        SqlConnection cnn; //Connection to the SQL server
        bool connected = false;
        //Sql data adapter used for insert, delete and update commands
        SqlDataAdapter dataAdapter;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configure the UI 
            this.dbDisconnectMenuItem.Enabled = false;

            ////Connection string
            ////Data Source=(local)\SQLEXPRESS;Initial Catalog=RPGCharacter;Integrated Security=True
            //connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = RPGCharacter; Integrated Security=True";

            //try
            //{
            //    //Assign the connection
            //    cnn = new SqlConnection(connectionString);
            //    cnn.Open();
            //    MessageBox.Show("Connected to the SQL server");
            //    connected = true;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "Unable to connect to the SQL server", MessageBoxButtons.OK);
            //}

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If connected close the DB Server connection
            if (connected)
            {
                cnn.Close();
                Debug.WriteLine("DEBUG: Closing the DB connection");
            }
        }

        private void dbConnectMenuItem_Click(object sender, EventArgs e)
        {
            //Connection string
            //Data Source=(local)\SQLEXPRESS;Initial Catalog=RPGCharacter;Integrated Security=True
            connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = RPGCharacter; Integrated Security=True";

            try
            {
                //Assign the connection
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                dataAdapter = new SqlDataAdapter();
                MessageBox.Show("Connected to the SQL server");
                connected = true;
                this.dbConnectMenuItem.Enabled = false;
                this.dbDisconnectMenuItem.Enabled = true;
                this.btnReadData.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Unable to connect to the SQL server", MessageBoxButtons.OK);
            }
        }

        private void dbDisconnectMenuItem_Click(object sender, EventArgs e)
        {
            //If connected close the DB Server connection
            if (connected)
            {
                cnn.Close();
                Debug.WriteLine("DEBUG: Closing the DB connection");
                this.dbConnectMenuItem.Enabled = true;
                this.dbDisconnectMenuItem.Enabled = false;
                this.btnReadData.Enabled = false;
            }

        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            //Read data from the database
            string sqlQuery = "Select * from Characters";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cnn);
            using(SqlDataReader mysqlDataReader = sqlCommand.ExecuteReader())
            {
                while(mysqlDataReader.Read())
                {
                    this.lstCharacters.Items.Add(mysqlDataReader[0].ToString());
                    this.lstCharacters.Items.Add(mysqlDataReader[1].ToString());
                    this.lstCharacters.Items.Add(mysqlDataReader[2].ToString());
                    this.lstCharacters.Items.Add(mysqlDataReader[3].ToString());
                    this.lstCharacters.Items.Add("------------------------------");
                }

            }
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            //Write to the DB
            SqlCommand command; //SQL Command to execute
            string sqlQuery = "Insert into Characters (CharacterName, CharacterExperience, CharacterStrength)" +
                "VALUES ('Tommy', 33, 44)"  ;

            //Create the SQL command
            command = new SqlCommand(sqlQuery, cnn);
            dataAdapter.InsertCommand = command;
            dataAdapter.InsertCommand.ExecuteNonQuery(); //ExecuteNonQuery - used to execute DML inserts, deletes and update statements
            command.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update a row in the DB
            SqlCommand command; //SQL Command to execute
            string sqlQuery = "Update Characters set CharacterName = 'Niamh' WHERE CharacterID = 8";

            //Create the SQL command
            command = new SqlCommand(sqlQuery, cnn);
            dataAdapter.UpdateCommand = new SqlCommand(sqlQuery, cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery(); //ExecuteNonQuery - used to execute DML inserts, deletes and update statements
            command.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete a row in the DB
            SqlCommand command; //SQL Command to execute
            string sqlQuery = "Delete Characters WHERE CharacterID = 5";

            //Create the SQL command
            command = new SqlCommand(sqlQuery, cnn);
            dataAdapter.DeleteCommand = new SqlCommand(sqlQuery, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery(); //ExecuteNonQuery - used to execute DML inserts, deletes and update statements
            command.Dispose();

        }

        private void btnUpdateParams_Click(object sender, EventArgs e)
        {
            //Write to the DB with params
            //SQL Data provider for SQL does not support the question mar (?) for passing
            //Parameters to SQL statement for stored procedures called by a command

            SqlCommand command;
            string sqlQuery = "INSERT INTO Characters (CharacterName, CharacterExperience, CharacterStrength)" +
                " VALUES (@CharacterName, @CharacterExperience, @CharacterStrength)";

            command = new SqlCommand(sqlQuery, cnn);
            command.Parameters.AddWithValue("@CharacterName", SqlDbType.NVarChar).Value = "Mario";
            command.Parameters.AddWithValue("@CharacterExperience", SqlDbType.Int).Value = 50;
            command.Parameters.AddWithValue("@CharacterStrength", SqlDbType.Int).Value = 99;

            command.ExecuteNonQuery();
            command.Dispose();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDataControls dataform = new frmDataControls();
            dataform.Show();
        }
    }
}
