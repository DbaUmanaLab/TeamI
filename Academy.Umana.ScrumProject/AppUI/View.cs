﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnElencoClassi_Click(object sender, EventArgs e)
        {   
          /*  DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Csv utilis = new Csv();

                classi = utilis.LoadGraph(openFileDialog1.FileName);
                MessageBox.Show("Hai aperto un file", "File aperto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = classi;

            }  */
        }

        private void BtnAlunniClasse_Click(object sender, EventArgs e)
        {

        }

        private void BtnMaterieVoti_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlunniInsufficienti_Click(object sender, EventArgs e)
        {

        }

        private void BtnInfoVoto_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
