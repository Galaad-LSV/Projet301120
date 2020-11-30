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
            DGVListePizza.Refresh();
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

        private void SetListPizza()
        {

        }

        private void DGVIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            /*if(checkedListBox1.SelectedItem.ToString() == "Sur Place")
            {
                new SurPlace();
            }
            else if (checkedListBox1.SelectedItem.ToString() == "Emporter")
            {
                new Emporter();
            }*/
        }

        private void DGVListePizza_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = new DataTable();
                DGVIngredients.Refresh();
                dt1.Columns.Add("Id", typeof(int));
                dt1.Columns.Add("Nom", typeof(string));
                dt1.Columns.Add("Quantité", typeof(int));
                dt1.Columns.Add("Prix", typeof(double));
                foreach (Pizza unePizza in Pizza.CollClassePizza)
                {
                    if (DGVListePizza.Rows[DGVListePizza.SelectedCells[0].RowIndex].Cells[1].Value.ToString() == unePizza.Nom)
                    {
                        foreach (Composant uneComposant in unePizza.LesIngredients)
                        {
                            dt1.Rows.Add(uneComposant.Id, uneComposant.NomIngredients, uneComposant.Quantite, uneComposant.Prix);
                        }
                    }

                }

                DGVIngredients.DataSource = dt1;
            }
            catch  { }
        }

        private void DGVCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVCommande_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGVListePizza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVListePizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
