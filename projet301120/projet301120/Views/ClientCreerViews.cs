using projet301120.Models;
using projet301120.Utilistaires;
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
    public partial class ClientCreerViews : Form
    {
        public ClientCreerViews()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            new Client(GestionId.GetNouvelIndexBox(),txtNom.Text);            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
        }
    }
}
