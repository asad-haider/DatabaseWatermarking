using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseWatermarking
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            string server = tbServer.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string database = tbDatabaseName.Text;


            conn = ConnectToDatabase(server, username, password, database);

            if (conn == null)
            {
                Prompt.ShowDialog("Invalid Credentials", "Error Connecting Database: Please Enter correct details");
            }
            else
            {
                //Prompt.ShowDialog("Connected", "Success: Connected to database");

                tbServer.Enabled = false;
                tbUsername.Enabled = false;
                tbPassword.Enabled = false;
                tbDatabaseName.Enabled = false;
                btnConnect.Enabled = false;
                comboTables.Enabled = true;
                PopulateTableComboBox();
                PopulateCompareTableComboBox();
                grdTableData.DataSource = GetDataFromTable(comboTables.SelectedValue.ToString());
            }
        }

        private void btnWatermark_Click(object sender, EventArgs e)
        {
            DataTable updatedDt = EncryptDatabase();
            grdTableData.DataSource = updatedDt;

            string encryptedTableName = "Encrypted" + comboTables.SelectedValue.ToString();
            string createTableQuery = GenerateSQL.CreateTABLE(encryptedTableName, updatedDt);
            SqlCommand command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();

            foreach (DataRow row in updatedDt.Rows)
            {
                command = GenerateSQL.CreateInsertCommand(row, encryptedTableName);
                command.Connection = conn;
                command.ExecuteScalar();
            }

            PopulateTableComboBox();
            PopulateCompareTableComboBox();

        }

        private void comboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = comboTables.SelectedValue.ToString();
            grdTableData.DataSource = GetDataFromTable(tableName);
            comboSeries.Enabled = true;
            FillSeriesComboBox();
        }

        private void comboSeries_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tableName = comboTables.SelectedValue.ToString();
            DataTable dt = GetDataFromTable(tableName);

            if(dt != null)
            {
                DataTable updatedDt = new DataTable();

                string selectedSeries = comboSeries.SelectedValue.ToString();

                int startNumber = 1;
                int difference = 2;

                if (selectedSeries.Equals("Arithmetic series"))
                { 
                    updatedDt = dt.Clone();

                    for (int i = startNumber - 1; i < dt.Rows.Count; i += difference)
                    {
                        DataRow row = dt.Rows[i];
                        updatedDt.ImportRow(row);
                    }

                    grdTableData.DataSource = updatedDt;
                }

                if (selectedSeries.Equals("Geometric series"))
                {
                    updatedDt = dt.Clone();

                    int counter = startNumber;

                    while(counter < dt.Rows.Count)
                    {
                        DataRow row = dt.Rows[counter - 1];
                        updatedDt.ImportRow(row);
                        counter = counter * difference;
                    }

                    grdTableData.DataSource = updatedDt;

                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            DataTable compareWithdt = GetDataFromTable(comboCompareTable.Text);
            DataTable selectedTable = GetDataFromTable(comboTables.Text);

            int columnCount = 0;

            float totalRecords = 0;
            float matchedRecord = 0;

            if (compareWithdt.Columns.Count == selectedTable.Columns.Count)
            {

                string waterMark = tbWatermark.Text;

                if (!string.IsNullOrEmpty(waterMark))
                {
                    char[] waterMarkArray = StringToByteArray(waterMark);

                    int counter = 0;

                    DataTable temporarydDt = selectedTable.Clone();

                    foreach (DataRow row in selectedTable.Rows)
                    {
                        for (int i = 1; i < selectedTable.Columns.Count; i++)
                        {
                            if (counter == waterMarkArray.Length)
                            {
                                counter = 0;
                            }

                            string columnData = row[i].ToString();
                            char[] dataArray = StringToByteArray(columnData);
                            dataArray[dataArray.Length - 1] = waterMarkArray[counter];
                            counter++;
                            row[i] = Encoding.UTF8.GetString(GetBytes(string.Join("", dataArray)));
                        }
                        temporarydDt.ImportRow(row);
                    }

                    columnCount = compareWithdt.Columns.Count;

                    foreach (DataRow temporaryRow in temporarydDt.Rows)
                    {
                        string id = temporaryRow[0].ToString();

                        DataRow compareRow = compareWithdt.Select("id = " + id).SingleOrDefault();

                        for (int i = 0; i < columnCount; i++)
                        {

                            totalRecords++;

                            string leftHandValue = temporaryRow[i].ToString();
                            string rightHandValue = compareRow[i].ToString();

                            if (leftHandValue.Equals(rightHandValue))
                            {
                                matchedRecord++;
                            }
                        }

                    }

                    lblMatchedRecords.Text = "" + matchedRecord + " record(s)";
                    lblPercentage.Text = "" + ((matchedRecord/totalRecords) * 100) + " %";

                }
            }
        }

        private DataTable GetDataFromTable(string tableName)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM " + tableName, conn);

            int rows = 0;
            int columns = 0;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);

                columns = dt.Columns.Count;
                rows = dt.Rows.Count;

                tbRowCount.Text = rows + " Row(s)";
                tbColumnCount.Text = columns + " Columns(s)";

                return dt;
            }

        }

        private void FillSeriesComboBox()
        {
            comboSeries.SelectedIndexChanged -= new EventHandler(comboSeries_SelectedIndexChanged);
            List<string> series = new List<string>();
            series.Add("Arithmetic series");
            series.Add("Geometric series");
            comboSeries.DataSource = series;
            comboSeries.SelectedIndexChanged += new EventHandler(comboSeries_SelectedIndexChanged);
        }

        public SqlConnection ConnectToDatabase(string server, string username, string password, string database)
        {
            try
            {
                SqlConnection connection = new SqlConnection();


                if (!string.IsNullOrEmpty(database))
                {
                    if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                        connection.ConnectionString = "Server=" + server + ";Database=" + database + ";Trusted_Connection=true";
                    else
                        connection.ConnectionString = "Server=" + server + ";Database=" + database + ";Trusted_Connection=false;" +
                            "user id =" + username + "; password=" + password + ";";

                    connection.Open();
                    return connection;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void PopulateTableComboBox()
        {
            comboTables.SelectedIndexChanged -= new EventHandler(comboTables_SelectedIndexChanged);
            DataTable schema = conn.GetSchema("Tables");
            List<string> TableNames = new List<string>();
            foreach (DataRow row in schema.Rows)
            {
                TableNames.Add(row[2].ToString());
            }
            comboTables.DataSource = TableNames;
            comboTables.SelectedIndexChanged += new EventHandler(comboTables_SelectedIndexChanged);
        }

        public void PopulateCompareTableComboBox()
        {
            DataTable schema = conn.GetSchema("Tables");
            List<string> TableNames = new List<string>();
            foreach (DataRow row in schema.Rows)
            {
                TableNames.Add(row[2].ToString());
            }
            comboCompareTable.DataSource = TableNames;
        }

        public DataTable EncryptDatabase()
        {
            string waterMark = tbWatermark.Text;

            if (!string.IsNullOrEmpty(waterMark))
            {
                char[] waterMarkArray = StringToByteArray(waterMark);

                int counter = 0;

                DataTable dt = (DataTable)grdTableData.DataSource;
                DataTable updatedDt = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        if (counter == waterMarkArray.Length)
                        {
                            counter = 0;
                        }

                        string columnData = row[i].ToString();
                        char[] dataArray = StringToByteArray(columnData);
                        dataArray[dataArray.Length - 1] = waterMarkArray[counter];
                        counter++;
                        row[i] = Encoding.UTF8.GetString(GetBytes(string.Join("", dataArray)));
                    }
                    updatedDt.ImportRow(row);
                }

                return updatedDt;
            }

            return null;
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? text : "";
            }
        }

        public static byte[] GetBytes(string bitString)
        {
            return Enumerable.Range(0, bitString.Length / 8).
                Select(pos => Convert.ToByte(
                    bitString.Substring(pos * 8, 8),
                    2)
                ).ToArray();
        }
    
        public static char[] StringToByteArray(string str)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return string.Join("", encoding.GetBytes(str).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')).ToArray()).ToArray();
        }

        public string ByteArrayToString(byte[] input)
        {
            UTF8Encoding enc = new UTF8Encoding();
            string str = enc.GetString(input);
            return str;
        }

    }
}
