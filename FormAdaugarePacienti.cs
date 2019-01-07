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
    public partial class FormAdaugarePacienti : Form
    {

        OracleConnection connection;
        MainForm main;

        public FormAdaugarePacienti(OracleConnection connection, MainForm main)
        {
            this.connection = connection;
            this.main = main;
            InitializeComponent();
        }

        private void FormAdaugarePacienti_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox3;
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Boolean error = false;
            bool isAllOk = true;
            if (fieldNotEmpty(textBox1.Text.ToString()))
            {
                if (!hasOnlyNumbers(textBox1.Text.ToString()))
                {
                    MessageBox.Show("CNP Invalid ..");
                    textBox1.ResetText();
                    this.ActiveControl = textBox1;
                    error = true;
                    isAllOk = false;
                    label1.ForeColor = Color.Red;
                }
                if (textBox1.Text.ToString().Length != 13)
                {
                    if (!error)
                    {
                        MessageBox.Show("CNP Invalid ..");
                        textBox1.ResetText();
                        this.ActiveControl = textBox1;
                        label1.ForeColor = Color.Red;
                        isAllOk = false;
                    }
                }
            }
            if (isAllOk && fieldNotEmpty(textBox1.Text.ToString()))
            {
                label1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            bool isAllOk = true;
            if(fieldNotEmpty(textBox2.Text.ToString()) &&
                textBox2.Text.ToString()!=String.Empty)
                if (!hasOnlyLetters(textBox2.Text.ToString()))
                {
                    MessageBox.Show("Adresa Invalida .. \nTrebuie sa contina doar litere !");
                    textBox2.ResetText();
                    this.ActiveControl = textBox2;
                    isAllOk = false;
                    label2.ForeColor = Color.Red;
                }
            if(textBox2.Text.ToString().Length > 50)
            {
                MessageBox.Show("Adresa este prea lunga..");
                textBox2.ResetText();
                this.ActiveControl = textBox2;
                label2.ForeColor = Color.Red;
                isAllOk = false;
            }
            if (isAllOk && fieldNotEmpty(textBox2.Text.ToString()))
            {
                label2.ForeColor = Color.Black;
            }
            this.ActiveControl = dateTimePicker1;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            bool isAllOk = true;
            if (fieldNotEmpty(textBox3.Text.ToString()) &&
                textBox3.Text.ToString() != String.Empty)
                if (!hasOnlyLetters(textBox3.Text.ToString()))
                {
                    MessageBox.Show("Nume invalid .. \nTrebuie sa contina doar litere !");
                    textBox3.ResetText();
                    this.ActiveControl = textBox3;
                    isAllOk = false;
                    label6.ForeColor = Color.Red;
                }
            if (textBox2.Text.ToString().Length > 50)
            {
                MessageBox.Show("Numele este prea lung..");
                textBox3.ResetText();
                this.ActiveControl = textBox3;
                label6.ForeColor = Color.Red;
                isAllOk = false;
            }
            if (isAllOk && fieldNotEmpty(textBox3.Text.ToString()))
            {
                label6.ForeColor = Color.Black;
            }
            this.ActiveControl = textBox5;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            bool isAllOk = true;
            if (fieldNotEmpty(textBox4.Text.ToString()) &&
                !hasOnlyNumbers(textBox4.Text.ToString()))
            {
                MessageBox.Show("Varsta Invalida ..\nTrebuie sa contina doar cifre !");
                textBox4.ResetText();
                this.ActiveControl = textBox4;
                label4.ForeColor = Color.Red;
                isAllOk = false;
            }
            if (textBox4.Text.ToString().Length > 3)
            {
                MessageBox.Show("Varsta Invalida ..");
                textBox4.ResetText();
                this.ActiveControl = textBox4;
                label4.ForeColor = Color.Red;
                isAllOk = false;

            }
            if (isAllOk && fieldNotEmpty(textBox4.Text.ToString()) )
            {
                label4.ForeColor = Color.Black;
            }
        }


        private void textBox5_Leave(object sender, EventArgs e)
        {
            bool isAllOk = true;
            if (fieldNotEmpty(textBox5.Text.ToString()) &&
                textBox5.Text.ToString() != String.Empty)
                if (!hasOnlyLetters(textBox5.Text.ToString()))
                {
                    MessageBox.Show("Prenume invalid .. \nTrebuie sa contina doar litere !");
                    textBox5.ResetText();
                    this.ActiveControl = textBox5;
                    isAllOk = false;
                    label5.ForeColor = Color.Red;
                }
            if (textBox2.Text.ToString().Length > 50)
            {
                MessageBox.Show("Prenumele este prea lung..");
                textBox5.ResetText();
                this.ActiveControl = textBox5;
                label5.ForeColor = Color.Red;
                isAllOk = false;
            }
            if (isAllOk && fieldNotEmpty(textBox5.Text.ToString()))
            {
                label5.ForeColor = Color.Black;
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = textBox4;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleParameter p1, p2, p3, p4, p5, p6;
            OracleCommand cmd;
            if (textBox1.Text.ToString() != String.Empty &&
                textBox2.Text.ToString() != String.Empty &&
                textBox4.Text.ToString() != String.Empty)
            {
                try
                {
                    connection.Open();
                    p5 = new OracleParameter();
                    p6 = new OracleParameter();
                    p1 = new OracleParameter();
                    p2 = new OracleParameter();
                    p3 = new OracleParameter();
                    p4 = new OracleParameter();
                    p5.Value = textBox3.Text;
                    p6.Value = textBox5.Text;
                    p1.Value = textBox1.Text;
                    p2.Value = textBox2.Text;
                    p3.Value = dateTimePicker1.Value.ToString("dd-MMM-yy").ToString();
                    p4.Value = textBox4.Text;
                    String sqlInsertCommand = "Insert into Pacienti Pacienti(nume,prenume,CNP,adresa,data_nasterii,varsta) values (:5,:6,:1,:2,:3,:4)";
                    cmd = new OracleCommand(sqlInsertCommand, connection);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
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
                        textBox1.Clear(); textBox2.Clear(); dateTimePicker1.ResetText(); textBox4.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
