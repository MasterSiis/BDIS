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
            this.stergerePacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugarePacientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugarePacientToolStripMenuItem
            // 
            this.adaugarePacientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugatePacientToolStripMenuItem,
            this.modificareDatePacientToolStripMenuItem,
            this.stergerePacientToolStripMenuItem,
            this.cautareToolStripMenuItem});
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
            // 
            // stergerePacientToolStripMenuItem
            // 
            this.stergerePacientToolStripMenuItem.Name = "stergerePacientToolStripMenuItem";
            this.stergerePacientToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.stergerePacientToolStripMenuItem.Text = "Stergere pacient";
            // 
            // cautareToolStripMenuItem
            // 
            this.cautareToolStripMenuItem.Name = "cautareToolStripMenuItem";
            this.cautareToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cautareToolStripMenuItem.Text = "Cautare";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

