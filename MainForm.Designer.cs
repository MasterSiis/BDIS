namespace BDIS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugarePacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugatePacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareDatePacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergerePacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaConsultatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareConsultatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCautareNume = new System.Windows.Forms.Label();
            this.textBoxCautarePacienti = new System.Windows.Forms.TextBox();
            this.buttonSalvareModificari = new System.Windows.Forms.Button();
            this.buttonAnuleazaModificari = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAnuleazaCautare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugarePacientToolStripMenuItem,
            this.consultatiiToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugarePacientToolStripMenuItem
            // 
            this.adaugarePacientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugatePacientToolStripMenuItem,
            this.modificareDatePacientToolStripMenuItem,
            this.cautareToolStripMenuItem,
            this.stergerePacientToolStripMenuItem});
            this.adaugarePacientToolStripMenuItem.Name = "adaugarePacientToolStripMenuItem";
            this.adaugarePacientToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.adaugarePacientToolStripMenuItem.Text = "Pacienti";
            // 
            // adaugatePacientToolStripMenuItem
            // 
            this.adaugatePacientToolStripMenuItem.Name = "adaugatePacientToolStripMenuItem";
            this.adaugatePacientToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.adaugatePacientToolStripMenuItem.Text = "Adaugare pacient";
            this.adaugatePacientToolStripMenuItem.Click += new System.EventHandler(this.adaugatePacientToolStripMenuItem_Click);
            // 
            // modificareDatePacientToolStripMenuItem
            // 
            this.modificareDatePacientToolStripMenuItem.Name = "modificareDatePacientToolStripMenuItem";
            this.modificareDatePacientToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modificareDatePacientToolStripMenuItem.Text = "Modificare date pacient";
            this.modificareDatePacientToolStripMenuItem.Click += new System.EventHandler(this.modificareDatePacientToolStripMenuItem_Click);
            // 
            // cautareToolStripMenuItem
            // 
            this.cautareToolStripMenuItem.Name = "cautareToolStripMenuItem";
            this.cautareToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cautareToolStripMenuItem.Text = "Cautare";
            this.cautareToolStripMenuItem.Click += new System.EventHandler(this.cautareToolStripMenuItem_Click);
            // 
            // stergerePacientToolStripMenuItem
            // 
            this.stergerePacientToolStripMenuItem.Name = "stergerePacientToolStripMenuItem";
            this.stergerePacientToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.stergerePacientToolStripMenuItem.Text = "Stergere";
            this.stergerePacientToolStripMenuItem.Click += new System.EventHandler(this.stergerePacientToolStripMenuItem_Click);
            // 
            // consultatiiToolStripMenuItem
            // 
            this.consultatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaConsultatiiToolStripMenuItem,
            this.modificareConsultatieToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.consultatiiToolStripMenuItem.Name = "consultatiiToolStripMenuItem";
            this.consultatiiToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.consultatiiToolStripMenuItem.Text = "Consultatii";
            // 
            // adaugaConsultatiiToolStripMenuItem
            // 
            this.adaugaConsultatiiToolStripMenuItem.Name = "adaugaConsultatiiToolStripMenuItem";
            this.adaugaConsultatiiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.adaugaConsultatiiToolStripMenuItem.Text = "Adauga consultatii";
            this.adaugaConsultatiiToolStripMenuItem.Click += new System.EventHandler(this.adaugaConsultatiiToolStripMenuItem_Click);
            // 
            // modificareConsultatieToolStripMenuItem
            // 
            this.modificareConsultatieToolStripMenuItem.Name = "modificareConsultatieToolStripMenuItem";
            this.modificareConsultatieToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modificareConsultatieToolStripMenuItem.Text = "Modificare consultatie";
            this.modificareConsultatieToolStripMenuItem.Click += new System.EventHandler(this.modificareConsultatieToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // labelCautareNume
            // 
            this.labelCautareNume.AutoSize = true;
            this.labelCautareNume.Location = new System.Drawing.Point(89, 42);
            this.labelCautareNume.Name = "labelCautareNume";
            this.labelCautareNume.Size = new System.Drawing.Size(82, 13);
            this.labelCautareNume.TabIndex = 4;
            this.labelCautareNume.Text = "Cautare pacient";
            this.labelCautareNume.Visible = false;
            // 
            // textBoxCautarePacienti
            // 
            this.textBoxCautarePacienti.Location = new System.Drawing.Point(177, 39);
            this.textBoxCautarePacienti.Name = "textBoxCautarePacienti";
            this.textBoxCautarePacienti.Size = new System.Drawing.Size(100, 20);
            this.textBoxCautarePacienti.TabIndex = 5;
            this.textBoxCautarePacienti.Visible = false;
            this.textBoxCautarePacienti.TextChanged += new System.EventHandler(this.textBoxCautarePacienti_TextChanged);
            // 
            // buttonSalvareModificari
            // 
            this.buttonSalvareModificari.Enabled = false;
            this.buttonSalvareModificari.Location = new System.Drawing.Point(283, 27);
            this.buttonSalvareModificari.Name = "buttonSalvareModificari";
            this.buttonSalvareModificari.Size = new System.Drawing.Size(130, 23);
            this.buttonSalvareModificari.TabIndex = 6;
            this.buttonSalvareModificari.Text = "Salveaza modificarile";
            this.buttonSalvareModificari.UseVisualStyleBackColor = true;
            this.buttonSalvareModificari.Visible = false;
            this.buttonSalvareModificari.Click += new System.EventHandler(this.buttonSalvareModificari_Click);
            // 
            // buttonAnuleazaModificari
            // 
            this.buttonAnuleazaModificari.Enabled = false;
            this.buttonAnuleazaModificari.Location = new System.Drawing.Point(283, 56);
            this.buttonAnuleazaModificari.Name = "buttonAnuleazaModificari";
            this.buttonAnuleazaModificari.Size = new System.Drawing.Size(130, 23);
            this.buttonAnuleazaModificari.TabIndex = 6;
            this.buttonAnuleazaModificari.Text = "Anuleaza";
            this.buttonAnuleazaModificari.UseVisualStyleBackColor = true;
            this.buttonAnuleazaModificari.Visible = false;
            this.buttonAnuleazaModificari.Click += new System.EventHandler(this.buttonAnuleazaModificari_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(536, 114);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(547, 325);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pacienti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consultatii";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salveaza modificarile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAnuleazaCautare
            // 
            this.buttonAnuleazaCautare.Location = new System.Drawing.Point(283, 39);
            this.buttonAnuleazaCautare.Name = "buttonAnuleazaCautare";
            this.buttonAnuleazaCautare.Size = new System.Drawing.Size(130, 23);
            this.buttonAnuleazaCautare.TabIndex = 9;
            this.buttonAnuleazaCautare.Text = "Anuleaza";
            this.buttonAnuleazaCautare.UseVisualStyleBackColor = true;
            this.buttonAnuleazaCautare.Visible = false;
            this.buttonAnuleazaCautare.Click += new System.EventHandler(this.buttonAnuleazaCautare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Acest pacient nu are consultatii inregistrate ..";
            this.label3.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAnuleazaCautare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnuleazaModificari);
            this.Controls.Add(this.buttonSalvareModificari);
            this.Controls.Add(this.textBoxCautarePacienti);
            this.Controls.Add(this.labelCautareNume);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Evidenta Pacienti";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugarePacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugatePacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareDatePacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergerePacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareToolStripMenuItem;
        private System.Windows.Forms.Label labelCautareNume;
        private System.Windows.Forms.TextBox textBoxCautarePacienti;
        private System.Windows.Forms.Button buttonSalvareModificari;
        private System.Windows.Forms.Button buttonAnuleazaModificari;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem consultatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem adaugaConsultatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareConsultatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAnuleazaCautare;
        private System.Windows.Forms.Label label3;
    }
}

