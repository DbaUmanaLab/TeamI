namespace AppUI
{
    partial class View
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnElencoClassi = new System.Windows.Forms.Button();
            this.btnAlunniClasse = new System.Windows.Forms.Button();
            this.btnMaterieVoti = new System.Windows.Forms.Button();
            this.btnAlunniInsufficienti = new System.Windows.Forms.Button();
            this.btnInfoVoto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElencoClassi
            // 
            this.btnElencoClassi.Location = new System.Drawing.Point(44, 29);
            this.btnElencoClassi.Name = "btnElencoClassi";
            this.btnElencoClassi.Size = new System.Drawing.Size(146, 73);
            this.btnElencoClassi.TabIndex = 0;
            this.btnElencoClassi.Text = "Elenco Classi";
            this.btnElencoClassi.UseVisualStyleBackColor = true;
            this.btnElencoClassi.Click += new System.EventHandler(this.btnElencoClassi_Click);
            // 
            // btnAlunniClasse
            // 
            this.btnAlunniClasse.Location = new System.Drawing.Point(44, 181);
            this.btnAlunniClasse.Name = "btnAlunniClasse";
            this.btnAlunniClasse.Size = new System.Drawing.Size(146, 73);
            this.btnAlunniClasse.TabIndex = 1;
            this.btnAlunniClasse.Text = "Visualizza alunni di ogni classe";
            this.btnAlunniClasse.UseVisualStyleBackColor = true;
            this.btnAlunniClasse.Click += new System.EventHandler(this.BtnAlunniClasse_Click);
            // 
            // btnMaterieVoti
            // 
            this.btnMaterieVoti.Location = new System.Drawing.Point(44, 319);
            this.btnMaterieVoti.Name = "btnMaterieVoti";
            this.btnMaterieVoti.Size = new System.Drawing.Size(146, 91);
            this.btnMaterieVoti.TabIndex = 2;
            this.btnMaterieVoti.Text = "Visualizza elenco materie e voti per ogni alunno";
            this.btnMaterieVoti.UseVisualStyleBackColor = true;
            this.btnMaterieVoti.Click += new System.EventHandler(this.BtnMaterieVoti_Click);
            // 
            // btnAlunniInsufficienti
            // 
            this.btnAlunniInsufficienti.Location = new System.Drawing.Point(44, 495);
            this.btnAlunniInsufficienti.Name = "btnAlunniInsufficienti";
            this.btnAlunniInsufficienti.Size = new System.Drawing.Size(146, 73);
            this.btnAlunniInsufficienti.TabIndex = 3;
            this.btnAlunniInsufficienti.Text = "Visualizza alunni con insufficienza";
            this.btnAlunniInsufficienti.UseVisualStyleBackColor = true;
            this.btnAlunniInsufficienti.Click += new System.EventHandler(this.BtnAlunniInsufficienti_Click);
            // 
            // btnInfoVoto
            // 
            this.btnInfoVoto.Location = new System.Drawing.Point(44, 658);
            this.btnInfoVoto.Name = "btnInfoVoto";
            this.btnInfoVoto.Size = new System.Drawing.Size(146, 73);
            this.btnInfoVoto.TabIndex = 4;
            this.btnInfoVoto.Text = "Visualizza info per ogni voto";
            this.btnInfoVoto.UseVisualStyleBackColor = true;
            this.btnInfoVoto.Click += new System.EventHandler(this.BtnInfoVoto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(253, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1129, 702);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInfoVoto);
            this.Controls.Add(this.btnAlunniInsufficienti);
            this.Controls.Add(this.btnMaterieVoti);
            this.Controls.Add(this.btnAlunniClasse);
            this.Controls.Add(this.btnElencoClassi);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElencoClassi;
        private System.Windows.Forms.Button btnAlunniClasse;
        private System.Windows.Forms.Button btnMaterieVoti;
        private System.Windows.Forms.Button btnAlunniInsufficienti;
        private System.Windows.Forms.Button btnInfoVoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

