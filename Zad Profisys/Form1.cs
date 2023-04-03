using System;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;

namespace Zad_Profisys
{
    public partial class Form1 : Form
    {
        private string ConnectionString;
        private OracleConnection con;
        private OracleCommand cmd;
        private bool connectionStatus = false;
        private bool fileOk = false;
        private bool errorInSaving = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath.Text = openFileDialog1.FileName;
            if(Path.GetExtension(filePath.Text) != ".csv") //checking file extention
            {
                MessageBox.Show("Please select csv file");
            }
            else
            {
                fileOk = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) //selecting file
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filepath = openFileDialog1.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //connecting database
        {
            ConnectionString = "User Id =" + userTextBox.Text + "; Password = " + passTextBox.Text + "; DBA PRIVILEGE=sysdba; Data Source = " + dataSourceTextBox.Text;
            con = new OracleConnection();
            con.ConnectionString = ConnectionString;
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                connStatus.Text = "Connected";
                connectionStatus = true;
                LoadDocuments(); //loading documents on grid
            }
            else
            {
                CloseConnect();
                MessageBox.Show("Not Connected!");
            }
        }

        private void closeConnection_Click(object sender, EventArgs e)
        {
            if(connectionStatus)
            CloseConnect();
        }

        private void CloseConnect() //closing connection to database
        {
            con.Close();
            con.Dispose();
            connStatus.Text = "Disconnected";
            connectionStatus = false;
        }

        private void readDocuments(string filePath) //uploadung documents file
        {
            int linesAmount = File.ReadAllLines(filePath).Length;
            StreamReader file = new StreamReader(filePath);
            string[] fields;
            fields = file.ReadLine().Split(';'); // skip column name
            for (int i = 1; i < linesAmount; i++) //sending each record separetly
            {
                fields = file.ReadLine().Split(';');
                using (cmd = con.CreateCommand())
                {
                    for (int j = 0; j < fields.Length; j++)
                    {
                        fields[j] = fields[j].Replace('\'', '`'); //repleacing possible signs 
                    }
                    try
                    {
                        cmd.CommandText = "insert into documents(id,type,orderDate,FirstName,lastName,city) " + $"values('{fields[0]}', '{fields[1]}', DATE '{fields[2]}','{fields[3]}','{fields[4]}', '{fields[5]}')";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        errorInSaving = true;
                        break;
                    }
                }
            }
        }

        private void readOrders(string filePath) //uploading orders file
        {
            int linesAmount = File.ReadAllLines(filePath).Length;
            StreamReader file = new StreamReader(filePath);
            string[] fields;
            fields = file.ReadLine().Split(';'); // skip column name
            for (int i = 1; i < linesAmount; i++)
            {
                fields = file.ReadLine().Split(';');
                using (cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "insert into positions(id,document,product,quality,price,taxRate) " + $"values('{i}', '{fields[0]}','{fields[2]}','{fields[3]}','{fields[4]}', '{fields[5]}')";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        errorInSaving = true;
                        break;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //adding data to database from document
        {
            if (fileOk)
            {
                if (connectionStatus) //selecting which document to upload
                {
                    if (docs.Checked == true)
                    {
                        readDocuments(filePath.Text);
                    }
                    else
                    {
                        readOrders(filePath.Text);
                    }
                    if(!errorInSaving)
                    {
                        MessageBox.Show("Saved in database");
                    }
                }
                else
                {
                    MessageBox.Show("Please connect to database");
                }
            }
            else
            {
                MessageBox.Show("Please load file");
            }
        }
        private void LoadDocuments() //loading documents from database
        {  
            string sqlSelect = selectSqlGenerate();
            if (sqlSelect != "0")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sqlSelect;
                cmd.CommandType = CommandType.Text;
                OracleDataReader selectedData = cmd.ExecuteReader();
                using (OracleDataAdapter orclAdapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    dt.Load(selectedData);  
                    orclAdapter.Fill(dt);  
                    dataGridView.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Can't show empty records");
            }
        }

        private void RefreshTable_Click(object sender, EventArgs e) //refreshing data in grid
        {
            if(connectionStatus)
            {
                LoadDocuments();
            }
            else
            {
                MessageBox.Show("You are not connected to database");
            }
        }
        private string selectSqlGenerate() //selecting data
        {
            bool check = false;
            string sqlSelect = "select ";
            if (IdColumn.Checked)
            {
                sqlSelect += "id, ";
                check = true;
            }
            if (TypeColumn.Checked)
            {
                sqlSelect += "type, ";
                check = true;
            }
            if (DateColumn.Checked)
            {
                sqlSelect += "orderdate, ";
                check = true;
            }
            if (FirstNameColumn.Checked)
            {
                sqlSelect += "firstname, ";
                check = true;
            }
            if (LastNameColumn.Checked)
            {
                sqlSelect += "lastname, ";
                check = true;
            }
            if (CityColumn.Checked)
            {
                sqlSelect += "city, ";
                check = true;
            }
            if (check)
            {
                sqlSelect = sqlSelect.Remove(sqlSelect.Length - 2, 2);
                sqlSelect += " from documents order by ";
                switch (orderBy.Text)
                {
                    case "Id":
                        sqlSelect += "id";
                        break;
                    case "Order Type":
                        sqlSelect += "type";
                        break;
                    case "Date":
                        sqlSelect += "orderdate";
                        break;
                    case "First Name":
                        sqlSelect += "firstname";
                        break;
                    case "Last Name":
                        sqlSelect += "lastname";
                        break;
                    case "City":
                        sqlSelect += "city";
                        break;
                    default:
                        sqlSelect += "id";
                        break;
                }
                if(sortDesc.Checked)
                {
                    sqlSelect += " desc";
                }
            }
            else
            {
                sqlSelect = "0";
            }
            return sqlSelect;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) //function opening new window with orders
        {
            dataGridView.CurrentRow.Selected = true;
            Form2 form = new Form2();
            form.Show();
            form.Text = dataGridView.Rows[e.RowIndex].Cells["FIRSTNAME"].Value.ToString() + " " + dataGridView.Rows[e.RowIndex].Cells["LASTNAME"].Value.ToString(); //adding data to second form like name in bar, date
            form.date.Text = dataGridView.Rows[e.RowIndex].Cells["ORDERDATE"].Value.ToString().Remove(dataGridView.Rows[e.RowIndex].Cells["ORDERDATE"].Value.ToString().Length - 9, 9); //remove to delete time
            form.orderId = dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString(); //sending order id to public variable
            form.con = con;
            LoadDocumentProducts(form, dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString()); //preloading grid in second form
        }

        private void LoadDocumentProducts(Form2 form, string orderId)
        {
            string selectSql = $"select * from positions where document = '{orderId}'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = selectSql;
            cmd.CommandType = CommandType.Text;
            OracleDataReader selectedData = cmd.ExecuteReader();
            using (OracleDataAdapter orclAdapter = new OracleDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                dt.Load(selectedData);
                orclAdapter.Fill(dt);
                form.dataGridView.DataSource = dt;
            }
            decimal priceSum = 0;
            for(int i = 0; i < form.dataGridView.Rows.Count; ++i) //calculating final price
            {
                priceSum += Convert.ToDecimal(form.dataGridView.Rows[i].Cells["PRICE"].Value);
            }
            form.price.Text = priceSum.ToString();
        }
    }
}
