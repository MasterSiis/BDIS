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
            if( textBox1.Text.ToString() != String.Empty &&
                textBox2.Text.ToString() != String.Empty &&
                textBox3.Text.ToString() != String.Empty &&
                textBox4.Text.ToString() != String.Empty 
                )
            {

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
                    DialogResult dialog = MessageBox.Show("Doriti sa mai adaugati alt pacient?",
                               "Adaugare pacienti", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                        main.getPatientsInformation();
                    }
                    else
                    {
                        main.getPatientsInformation();
                        this.Close();
                    }
                   
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nu ati completat toate campurile!");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Boolean error = false;
            if (fieldNotEmpty(textBox1.Text.ToString()))
            { 
                if (!hasOnlyNumbers(textBox1.Text.ToString()))
                {
                    MessageBox.Show("CNP Invalid");
                    error = true;
                }
                if (textBox1.Text.ToString().Length != 13)
                {
                    if(!error)
                        MessageBox.Show("CNP Invalid");
                }
            }
        }

        Boolean hasOnlyNumbers(String input)
        {
            if (Regex.IsMatch(input, @"^[0-9]+$") && input != String.Empty)
                return true;
            else
                return false;

        }

        Boolean hasOnlyLetters(String input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$") && input != "")
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(fieldNotEmpty(textBox2.Text.ToString()) &&
                textBox2.Text.ToString()!=String.Empty)
                if (!hasOnlyLetters(textBox2.Text.ToString()))
                {
                    MessageBox.Show("Adresa Invalida");
                }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (fieldNotEmpty(textBox4.Text.ToString()) &&
                !hasOnlyNumbers(textBox4.Text.ToString()))
            {
                MessageBox.Show("Varsta Invalida");
            }
        }
    }

    
}
