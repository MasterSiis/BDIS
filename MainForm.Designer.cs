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
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCautareNume = new System.Windows.Forms.Label();
            this.textBoxCautarePacienti = new System.Windows.Forms.TextBox();
            this.buttonSalvareModificari = new System.Windows.Forms.Button();
            this.buttonAnuleazaModificari = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 325);
            this.dataGridView1.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
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
            this.stergerePacientToolStripMenuItem.Text = "Stergere pacient";
            this.stergerePacientToolStripMenuItem.Click += new System.EventHandler(this.stergerePacientToolStripMenuItem_Click);
            // 
            // consultatiiToolStripMenuItem
            // 
            this.consultatiiToolStripMenuItem.Name = "consultatiiToolStripMenuItem";
            this.consultatiiToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.consultatiiToolStripMenuItem.Text = "Consultatii";
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
            this.buttonAnuleazaModificari.Text = "Anuleaza modificarile";
            this.buttonAnuleazaModificari.UseVisualStyleBackColor = true;
            this.buttonAnuleazaModificari.Visible = false;
            this.buttonAnuleazaModificari.Click += new System.EventHandler(this.buttonAnuleazaModificari_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(532, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(448, 325);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pacienti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consultatii";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 542);
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
            this.Text = "Form1";
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
    }
}

