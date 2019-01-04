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
        Boolean inEditMode = false,
            inSearchMode = false;
        String CNP = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
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
                dataGridView1.Rows[0].Cells[0].Selected = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

       private void updatePatientInformation()
        {
            try
            {
                OracleCommandBuilder command = new OracleCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet.Tables["Pacienti"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void searchPatientByCNP()
        {
            String filterQuery = "CNP like'" + textBoxCautarePacienti.Text.ToString() + "%'";
            dataSet.Tables["Pacienti"].DefaultView.RowFilter = filterQuery;
            dataGridView1.Refresh();
        }

        private void displaySearchElements(Boolean visible)
        {
            labelCautareNume.Visible = visible;
            textBoxCautarePacienti.Visible = visible;
            buttonSalvareModificari.Visible = visible;
            buttonAnuleazaModificari.Visible = visible;
            dataGridView1.ReadOnly = !visible;
        }

        private void adaugatePacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdaugare formAdaugare = new FormAdaugare(connection, this);
            formAdaugare.Show();
        }

        private void modificareDatePacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inSearchMode = true;
            displaySearchElements(true);
            inEditMode = true;
        }

       private void buttonSalvareModificari_Click(object sender, EventArgs e)
        {
            textBoxCautarePacienti.Clear();
            inSearchMode = false;
            updatePatientInformation();
            getPatientsInformation();
            displaySearchElements(false);
        }

        private void textBoxCautarePacienti_TextChanged(object sender, EventArgs e)
        {
            if (inEditMode)
            {
                buttonSalvareModificari.Enabled = true;
                buttonAnuleazaModificari.Enabled = true;
            }
            searchPatientByCNP();
        }

        private void buttonAnuleazaModificari_Click(object sender, EventArgs e)
        {
            displaySearchElements(false);
            getPatientsInformation();
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCautarePacienti.Clear();
            displaySearchElements(true);
            dataGridView1.ReadOnly = true;
            //searchPatientByCNP();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stergerePacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult dialog = MessageBox.Show("Doriti sa stergeti?", "Stergere",
                MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                
                        String cnpSelectat = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                        String sqlDeleteQuery = "DELETE FROM Pacienti WHERE CNP= :p1";

                        connection.Open();
                        OracleCommand oracleCommand = new OracleCommand(sqlDeleteQuery, connection);
                        oracleCommand.BindByName = true;
                        oracleCommand.Parameters.Add("p1", cnpSelectat);
                        dataAdapter.DeleteCommand = oracleCommand;
                        dataAdapter.DeleteCommand.ExecuteNonQuery();
                        connection.Close();
                        getPatientsInformation();

                        MessageBox.Show("Stergerea s-a realizat cu succes");
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati intreg randul care se doreste a fi sters !");
            }
        }

        public void getDiagnosticsForPatients(String CNP)
        {
            try
            {
                String filterQuery = "CNP like'" + CNP + "%'";
                String sqlQuery = "SELECT * FROM Consultatii";
                dataAdapter = new OracleDataAdapter(sqlQuery, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Consultatii");
                dataGridView2.DataSource = dataSet.Tables["Consultatii"];            
                dataSet.Tables["Consultatii"].DefaultView.RowFilter = filterQuery;
                dataGridView1.Refresh();


                dataGridView2.Rows[0].Cells[0].Selected = false;
                dataGridView2.ReadOnly = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!inSearchMode)
            { 
                CNP = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                getDiagnosticsForPatients(CNP);
            }

        }

        private void adaugaConsultatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CNP != String.Empty)
            {
                FormAdaugareConsultatie formAdaugare = new FormAdaugareConsultatie(connection, this, CNP);
                formAdaugare.Show();
            }
            else
            {
                MessageBox.Show("Selectati pacientul pentru a putea adauga consultatie !");
            }
               
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                DialogResult dialog = MessageBox.Show("Doriti sa stergeti?", "Stergere",
                MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    String cnpSelectat = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value.ToString();
                    String sqlDeleteQuery = "DELETE FROM Consultatii WHERE CNP= :p1";

                    connection.Open();
                    OracleCommand oracleCommand = new OracleCommand(sqlDeleteQuery, connection);
                    oracleCommand.BindByName = true;
                    oracleCommand.Parameters.Add("p1", cnpSelectat);
                    dataAdapter.DeleteCommand = oracleCommand;
                    dataAdapter.DeleteCommand.ExecuteNonQuery();
                    connection.Close();
                    getDiagnosticsForPatients(CNP);

                    MessageBox.Show("Stergerea s-a realizat cu succes");
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati intreg randul care se doreste a fi sters !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            try
            {
                OracleCommandBuilder command = new OracleCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet.Tables["Consultatii"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            getDiagnosticsForPatients(CNP);
        }

        private void modificareConsultatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView2.Rows[0].Cells[0].Displayed)
                { 
                    button1.Visible = true;
                    dataGridView2.ReadOnly = false;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Selectati pacientul pentru care doriti sa modificati consultatiile !");
            }
        }
    }
}
