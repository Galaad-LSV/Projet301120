using projet301120.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet301120.Views
{
    public partial class CommandeView : Form
    {
        public CommandeView()
        {
            InitializeComponent();
        }

        private void CommandeView_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Prix", typeof(double));
            foreach (Pizza lesPizza in Pizza.CollClassePizza)
            {
                dt.Rows.Add(lesPizza.Id, lesPizza.Nom, lesPizza.Prix);
            }
            DGVListePizza.DataSource = dt;
        }
        

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void DGVListePizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetListPizza()
        {

        }
    }
}
