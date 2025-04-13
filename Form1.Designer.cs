namespace Mini_ArtikelVerwaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblArtikelName = new Label();
            lblLagerBestand = new Label();
            lblPreis = new Label();
            txtArtikelName = new TextBox();
            txtPreis = new TextBox();
            txtLagerBestand = new TextBox();
            btnHinzufuegen = new Button();
            btnLoeschen = new Button();
            label1 = new Label();
            dgvArtikel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArtikel).BeginInit();
            SuspendLayout();
            // 
            // lblArtikelName
            // 
            lblArtikelName.AutoSize = true;
            lblArtikelName.Location = new Point(32, 82);
            lblArtikelName.Name = "lblArtikelName";
            lblArtikelName.Size = new Size(71, 15);
            lblArtikelName.TabIndex = 0;
            lblArtikelName.Text = "Artikelname";
            lblArtikelName.Click += label1_Click;
            // 
            // lblLagerBestand
            // 
            lblLagerBestand.AutoSize = true;
            lblLagerBestand.Location = new Point(32, 183);
            lblLagerBestand.Name = "lblLagerBestand";
            lblLagerBestand.Size = new Size(78, 15);
            lblLagerBestand.TabIndex = 1;
            lblLagerBestand.Text = "Lagerbestand";
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Location = new Point(32, 133);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(32, 15);
            lblPreis.TabIndex = 2;
            lblPreis.Text = "Preis";
            // 
            // txtArtikelName
            // 
            txtArtikelName.Location = new Point(169, 74);
            txtArtikelName.Name = "txtArtikelName";
            txtArtikelName.Size = new Size(100, 23);
            txtArtikelName.TabIndex = 3;
            // 
            // txtPreis
            // 
            txtPreis.Location = new Point(169, 125);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(100, 23);
            txtPreis.TabIndex = 4;
            // 
            // txtLagerBestand
            // 
            txtLagerBestand.Location = new Point(169, 175);
            txtLagerBestand.Name = "txtLagerBestand";
            txtLagerBestand.Size = new Size(100, 23);
            txtLagerBestand.TabIndex = 5;
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Location = new Point(41, 243);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(88, 33);
            btnHinzufuegen.TabIndex = 6;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(169, 243);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(88, 33);
            btnLoeschen.TabIndex = 7;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 22);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 8;
            label1.Text = "Artikelverwaltung";
            // 
            // dgvArtikel
            // 
            dgvArtikel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtikel.Location = new Point(416, 74);
            dgvArtikel.Name = "dgvArtikel";
            dgvArtikel.RowTemplate.Height = 25;
            dgvArtikel.Size = new Size(240, 150);
            dgvArtikel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvArtikel);
            Controls.Add(label1);
            Controls.Add(btnLoeschen);
            Controls.Add(btnHinzufuegen);
            Controls.Add(txtLagerBestand);
            Controls.Add(txtPreis);
            Controls.Add(txtArtikelName);
            Controls.Add(lblPreis);
            Controls.Add(lblLagerBestand);
            Controls.Add(lblArtikelName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArtikel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArtikelName;
        private Label lblLagerBestand;
        private Label lblPreis;
        private TextBox txtArtikelName;
        private TextBox txtPreis;
        private TextBox txtLagerBestand;
        private Button btnHinzufuegen;
        private Button btnLoeschen;
        private Label label1;
        private DataGridView dgvArtikel;
    }
}