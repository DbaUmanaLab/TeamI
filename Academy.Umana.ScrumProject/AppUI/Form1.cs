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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<Alunno> alunni;
        private void Form1_Load(object sender, EventArgs e)
        {
            Csv utilis = new Csv();
            
            alunni = utilis.LoadGraphAlunno("CSV\\ElencoAlunni.csv");

            dataGridView1.DataSource = alunni;
        }
    }
}
