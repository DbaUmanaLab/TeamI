using AppLogic.Entities;
using System;
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


        Classe[] classi = new Classe[200];

        public View()
        {
            InitializeComponent();
        }

        private void btnElencoClassi_Click(object sender, EventArgs e)
        {
            Csv utilis = new Csv();

            classi = utilis.LoadGraph("CSV\\ElencoClassi.csv");

            dataGridView1.DataSource = classi;
              
        }

        private void BtnAlunniClasse_Click(object sender, EventArgs e)
        {
            Csv utilis = new Csv();

            classi = utilis.LoadGraph("CSV\\ElencoAlunni.csv");
           
            dataGridView1.DataSource = classi;
        }

        private void BtnMaterieVoti_Click(object sender, EventArgs e)
        {
            Csv utilis = new Csv();

            classi = utilis.LoadGraph("CSV\\ElencoMaterie.csv");

            dataGridView1.DataSource = classi;

        }

        private void BtnAlunniInsufficienti_Click(object sender, EventArgs e)
        {
            /*
            Csv utilis = new Csv();

            classi = utilis.LoadGraph("CSV\\ElencoClassi.csv");

            dataGridView1.DataSource = classi; */

        }

        private void BtnInfoVoto_Click(object sender, EventArgs e)
        {
            Csv utilis = new Csv();

            classi = utilis.LoadGraph("CSV\\ElencoVoti.csv");

            dataGridView1.DataSource = classi;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
