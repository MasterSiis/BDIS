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
using System.Text.RegularExpressions;

namespace BDIS
{
    public partial class FormAdaugareConsultatie : Form
    {

        OracleConnection connection;
        MainForm main;
        String CNP = String.Empty;

        public FormAdaugareConsultatie(OracleConnection connection, MainForm main, String cnp)
        {
            this.connection = connection;
            this.main = main;
            InitializeComponent();
            this.CNP = cnp;
            labelCNP.Text = cnp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleParameter p1, p2, p3, p4, p5;
            OracleCommand cmd;
            try
            {
                connection.Open();
               // p1 = new OracleParameter();
                p2 = new OracleParameter();
                p3 = new OracleParameter();
                p4 = new OracleParameter();
                p5 = new OracleParameter();
                p5.Value = CNP;
              //  p1.Value = textBox1.Text;
                p2.Value = dateTimePicker1.Value.ToString("dd-MMM-yy").ToString();
                p3.Value = textBox3.Text;
                p4.Value = textBox4.Text;
                String sqlInsertCommand = "Insert into Consultatii(CNP,data_consultatiei,diagnostic,medicamentatie) values (:5,:2,:3,:4)";
                cmd = new OracleCommand(sqlInsertCommand, connection);
                cmd.Parameters.Add(p5);
                //cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2); 
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.ExecuteNonQuery();
                connection.Close();
                main.getDiagnosticsForPatients(CNP);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Boolean hasOnlyLetters(String input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z\s\.\,]*$") && input != "")
                return true;
            else
                return false;

        }

        Boolean fieldNotEmpty(String input)
        {
            if (input != String.Empty)
                return true;
            else
                return false;
        }

        private void textBox3_Leave(object sender, EventArgs e) //diagnostic label4
        {
            bool isAllOk = true;
            if (fieldNotEmpty(textBox3.Text.ToString()) &&
                textBox3.Text.ToString() != String.Empty)
                if (!hasOnlyLetters(textBox3.Text.ToString()))
                {
                    MessageBox.Show("Diagnostic Invalid .. \nTrebuie sa contina doar litere !");
                    textBox3.ResetText();
                    this.ActiveControl = textBox3;
                    isAllOk = false;
                    label4.ForeColor = Color.Red;
                }
            if (textBox3.Text.ToString().Length > 50)
            {
                MessageBox.Show("Diagnosticul este prea lung!");
                textBox3.ResetText();
                this.ActiveControl = textBox3;
                label4.ForeColor = Color.Red;
                isAllOk = false;
            }
            if (isAllOk && fieldNotEmpty(textBox3.Text.ToString()))
            {
                label4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e) //medicamentatie label3
        {
            bool isAllOk = true;
            if (fieldNotEmpty(textBox4.Text.ToString()))
            { 
                if (textBox4.Text.ToString().Length > 50)
                {
                    MessageBox.Show("Diagnosticul este prea lung!");
                    textBox4.ResetText();
                    this.ActiveControl = textBox3;
                    label3.ForeColor = Color.Red;
                    isAllOk = false;
                }
            }
            if (isAllOk && fieldNotEmpty(textBox4.Text.ToString()))
            {
                label3.ForeColor = Color.Black;
            }
        }
    }
}
