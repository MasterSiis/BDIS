using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace BDIS
{
    public partial class MainForm : Form
    {
        OracleConnection conn;
        OracleDataAdapter dataAdapter;
        DataSet dataSet;
        DataTable dataTable;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connectToDatabase();
            getPatientsInformation();
        }


        private void connectToDatabase()
        {
            try
            {
                conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY INFO=True;USER ID=STUDENT");
                conn.Open();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void getPatientsInformation()
        {
            try
            {
                String sqlQuery = "SELECT * FROM Pacienti";
                dataAdapter = new OracleDataAdapter(sqlQuery, conn);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Pacienti");
                dataGridView1.DataSource = dataSet.Tables["Pacienti"];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleParameter p1, p2, p3, p4;
            OracleCommand cmd;
            try
            {
                conn.Open();
                p1 = new OracleParameter();
                p2 = new OracleParameter();
                p3 = new OracleParameter();
                p4 = new OracleParameter();
                p1.Value = textBox1.Text;
                p2.Value = textBox2.Text;
                p3.Value = textBox3.Text;
                p4.Value = textBox4.Text;
                String sqlInsertCommand = "Insert into Pacienti Pacienti(CNP,adresa,data_nasterii,varsta) values (:1,:2,:3,:4)";
                cmd = new OracleCommand(sqlInsertCommand, conn);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.ExecuteNonQuery();
                conn.Close();
                getPatientsInformation();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
