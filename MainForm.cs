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
        OracleConnection connection;
        OracleDataAdapter dataAdapter;
        DataSet dataSet;

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
                connection = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY INFO=True;USER ID=STUDENT");
                connection.Open();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void getPatientsInformation()
        {
            try
            {
                String sqlQuery = "SELECT * FROM Pacienti";
                dataAdapter = new OracleDataAdapter(sqlQuery, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Pacienti");
                dataGridView1.DataSource = dataSet.Tables["Pacienti"];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void adaugatePacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdaugare formAdaugare = new FormAdaugare(connection, this);
            formAdaugare.Show();
        }
    }
}
