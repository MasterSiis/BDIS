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
        OracleDataAdapter dataAdapterPacienti, 
                          dataAdapterConsultatii;
        DataSet dataSetPacienti, 
                dataSetConsultatii;
        Boolean inEditMode = false,
                inSearchMode = false;
        String CNP = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            label3.ForeColor = Color.Red;
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

        /* ######### Pacienti ######### */

        public void getPatientsInformation()
        {
            try
            {
                String sqlQuery = "SELECT * FROM Pacienti";
                dataAdapterPacienti = new OracleDataAdapter(sqlQuery, connection);
                dataSetPacienti = new DataSet();
                dataAdapterPacienti.Fill(dataSetPacienti, "Pacienti");
                dataGridView1.DataSource = dataSetPacienti.Tables["Pacienti"];
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
                OracleCommandBuilder command = new OracleCommandBuilder(dataAdapterPacienti);
                dataAdapterPacienti.Update(dataSetPacienti.Tables["Pacienti"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void searchPatientByCNP(String filter)
        {

            String filterQuery = "CNP like'" + filter+"%'";
            var dataViewPacienti = dataSetPacienti.Tables["Pacienti"].DefaultView;
            dataViewPacienti.RowFilter = filterQuery;


            //String filterQuery = "CNP like'" + filter + "%'";
            //dataSetPacienti.Tables["Pacienti"].DefaultView.RowFilter = filterQuery;
            dataGridView1.Refresh();
        }

        private void adaugarePacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdaugarePacienti formAdaugare = new FormAdaugarePacienti(connection, this);
            formAdaugare.Show();
        }

        private void modificareDatePacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCautarePacienti.Text = String.Empty;
            inSearchMode = true;
            inEditMode = true;
            displaySearchElements(true);
            buttonAnuleazaModificari.Enabled = true;
            buttonAnuleazaCautare.Visible = false;
            dataGridView2.DataSource = null;
        }

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displaySearchElements(true);
            dataGridView1.ReadOnly = true;
            buttonSalvareModificari.Visible = false;
            buttonAnuleazaModificari.Visible = false;
            buttonAnuleazaCautare.Visible = true;
            textBoxCautarePacienti.Text = String.Empty;

        }

        private void textBoxCautarePacienti_TextChanged(object sender, EventArgs e)
        {
            if (inEditMode)
            {
                buttonSalvareModificari.Enabled = true;
            }
            if(textBoxCautarePacienti.Text == String.Empty)
            {
                dataGridView2.DataSource = null;
            }
            searchPatientByCNP(textBoxCautarePacienti.Text.ToString());
        }

        private void buttonSalvareModificari_Click(object sender, EventArgs e)
        {
            updatePatientInformation();
            getPatientsInformation();
            displaySearchElements(false);
            textBoxCautarePacienti.Text = String.Empty;
            inSearchMode = false;
            getDiagnosticsForPatients(CNP);

        }

        private void buttonAnuleazaModificari_Click(object sender, EventArgs e)
        {
            displaySearchElements(false);
            getPatientsInformation();
            inSearchMode = false;
        }

        private void buttonAnuleazaCautare_Click(object sender, EventArgs e)
        {
            displaySearchElements(false);
            buttonAnuleazaCautare.Visible = false;
            getPatientsInformation();
            dataGridView2.DataSource = null;
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
                    dataAdapterPacienti.DeleteCommand = oracleCommand;
                    dataAdapterPacienti.DeleteCommand.ExecuteNonQuery();
                    connection.Close();
                    getPatientsInformation();
                    getDiagnosticsForPatients(CNP);
                    MessageBox.Show("Stergerea s-a realizat cu succes");
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati intreg randul care se doreste a fi sters !");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!inSearchMode)
            {
                try
                {
                    CNP = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    getDiagnosticsForPatients(CNP);
                }catch{}
            }
            else
            {
                textBoxCautarePacienti.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            }

            if (dataGridView2.Rows.Count == 1)
                label3.Visible = true;
            else
                label3.Visible = false;
        }

        internal void formReportClosed()
        {
            getPatientsInformation();
            dataGridView2.DataSource = null;
        }



        /* ######### Consultatii ######### */


        public void getDiagnosticsForPatients(String CNP)
        {
            try
            {
                String filterQuery = "CNP like'" + CNP + "%'";
                String sqlQuery = "SELECT * FROM Consultatii";
                dataAdapterConsultatii = new OracleDataAdapter(sqlQuery, connection);
                dataSetConsultatii = new DataSet();
                dataAdapterConsultatii.Fill(dataSetConsultatii, "Consultatii");
                dataGridView2.DataSource = dataSetConsultatii.Tables["Consultatii"];
                dataSetConsultatii.Tables["Consultatii"].DefaultView.RowFilter = filterQuery;
                dataGridView1.Refresh();


                dataGridView2.Rows[0].Cells[0].Selected = false;
                dataGridView2.ReadOnly = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
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

        private void modificareConsultatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[0].Cells[0].Displayed)
                {
                    button1.Visible = true;
                    dataGridView2.ReadOnly = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Selectati pacientul pentru care doriti sa modificati consultatiile !");
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[0].Cells[0].Displayed)
                {
                    if (dataGridView2.SelectedRows.Count == 1)
                    {
                        DialogResult dialog = MessageBox.Show("Doriti sa stergeti?", "Stergere",
                        MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {

                            String cnpSelectat = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value.ToString();
                            String diagnosticSelectat = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[3].Value.ToString();
                            String sqlDeleteQuery = "DELETE FROM Consultatii WHERE CNP= :p1 AND diagnostic= :p2";

                            connection.Open();
                            OracleCommand oracleCommand = new OracleCommand(sqlDeleteQuery, connection);
                            oracleCommand.BindByName = true;
                            oracleCommand.Parameters.Add("p1", cnpSelectat);
                            oracleCommand.Parameters.Add("p2", diagnosticSelectat);
                            dataAdapterConsultatii.DeleteCommand = oracleCommand;
                            dataAdapterConsultatii.DeleteCommand.ExecuteNonQuery();
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
            }
            catch (Exception exception)
            {
                MessageBox.Show("Selectati pacientul pentru care doriti sa stergeti consultatiile !");
            }
        }

        private void buttonAnuleazaModificariConsultatie_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            try
            {
                OracleCommandBuilder command = new OracleCommandBuilder(dataAdapterConsultatii);
                dataAdapterConsultatii.Update(dataSetConsultatii.Tables["Consultatii"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            getDiagnosticsForPatients(CNP);
        }

        

        /* ######### Crystal Report ######### */
        
        private void fisaPacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[0].Cells[0].Displayed)
                {
                    if (!label3.Visible)
                    { 
                        String filterQuery = "CNP=" + CNP;
                        var dataViewConsultatii = dataSetConsultatii.Tables["Consultatii"].DefaultView;
                        var dataViewPacienti = dataSetPacienti.Tables["Pacienti"].DefaultView;
                        dataViewPacienti.RowFilter = filterQuery;
                        dataViewConsultatii.RowFilter = filterQuery;
                        var newDataSet = new DataSet();
                        newDataSet.Tables.Add(dataViewConsultatii.ToTable());
                        newDataSet.Tables.Add(dataViewPacienti.ToTable());
                        CrystalReport1 raport = new CrystalReport1();
                        raport.SetDataSource(newDataSet);
                        FormRaport formRaport = new FormRaport(raport, this);
                        formRaport.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pacientul nu are consultatii !");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Selectati pacientul pentru care doriti sa modificati consultatiile !");
            }
            
        }
        
        
        /* ######### Utils ######### */
        
        private void displaySearchElements(Boolean visible)
        {
            labelCautareNume.Visible = visible;
            textBoxCautarePacienti.Visible = visible;
            buttonSalvareModificari.Visible = visible;
            buttonAnuleazaModificari.Visible = visible;
            dataGridView1.ReadOnly = !visible;
        }

        public void hideLabel()
        {
            label3.Visible = false;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
