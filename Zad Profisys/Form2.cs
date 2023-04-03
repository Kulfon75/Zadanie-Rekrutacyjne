using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Zad_Profisys
{
    public partial class Form2 : Form
    {
        public string orderId;
        public OracleConnection con;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void LoadDocument() //refreshind data in grid
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
        private string selectSqlGenerate() //choice which data to schow and in what order
        {
            bool check = false;
            string sqlSelect = "select ";
            if (IdColumn.Checked)
            {
                sqlSelect += "id, ";
                check = true;
            }
            if (DocumentColumn.Checked)
            {
                sqlSelect += "document, ";
                check = true;
            }
            if (ProductColumn.Checked)
            {
                sqlSelect += "product, ";
                check = true;
            }
            if (QualityColumn.Checked)
            {
                sqlSelect += "quality, ";
                check = true;
            }
            if (PriceColumn.Checked)
            {
                sqlSelect += "price, ";
                check = true;
            }
            if (TaxColumn.Checked)
            {
                sqlSelect += "taxrate, ";
                check = true;
            }
            if (check)
            {
                sqlSelect = sqlSelect.Remove(sqlSelect.Length - 2, 2);
                sqlSelect += $" from positions where document = '{orderId}' order by ";
                switch (orderBy.Text)
                {
                    case "Id":
                        sqlSelect += "id";
                        break;
                    case "Document Number":
                        sqlSelect += "document";
                        break;
                    case "Product Name":
                        sqlSelect += "product";
                        break;
                    case "Quality":
                        sqlSelect += "quality";
                        break;
                    case "Price":
                        sqlSelect += "price";
                        break;
                    case "Tax Rate":
                        sqlSelect += "city";
                        break;
                    default:
                        sqlSelect += "taxrate";
                        break;
                }
                if (sortDesc.Checked)
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

        private void button1_Click(object sender, EventArgs e) //button call
        {
            LoadDocument();
        }
    }
}
