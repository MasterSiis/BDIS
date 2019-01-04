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
        Boolean inEditMode = false;

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
            displaySearchElements(true);
            inEditMode = true;
        }

       private void buttonSalvareModificari_Click(object sender, EventArgs e)
        {
            textBoxCautarePacienti.Clear();
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
            displaySearchElements(true);
            dataGridView1.ReadOnly = true;
            searchPatientByCNP();
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
    }
}
