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
    public partial class FormAdaugare : Form
    {

        OracleConnection connection;
        MainForm main;

        public FormAdaugare(OracleConnection connection, MainForm main)
        {
            this.connection = connection;
            this.main = main;

            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleParameter p1, p2, p3, p4;
            OracleCommand cmd;
            try
            {
                connection.Open();
                p1 = new OracleParameter();
                p2 = new OracleParameter();
                p3 = new OracleParameter();
                p4 = new OracleParameter();
                p1.Value = textBox1.Text;
                p2.Value = textBox2.Text;
                p3.Value = textBox3.Text;
                p4.Value = textBox4.Text;
                String sqlInsertCommand = "Insert into Pacienti Pacienti(CNP,adresa,data_nasterii,varsta) values (:1,:2,:3,:4)";
                cmd = new OracleCommand(sqlInsertCommand, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.ExecuteNonQuery();
                connection.Close();
                main.getPatientsInformation();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
