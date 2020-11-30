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
            Client c1 = new Client(1, "Lusven");
            Client c2 = new Client(2, "Trottmann");
            Commande co1 = new Commande(1, "30/11/20", c1);
            Commande co2 = new Commande(2,"01/12/20", c2);
            Commande co3 = new Commande(3,"02/12/20",c1);
            Commande co4 = new Commande(4,"03/12/20",c2);
            Composant i1 = new Composant(1, "Lard", 3, 2);
            Composant i2 = new Composant(2, "Oeuf", 1, 0.5);
            Composant i3 = new Composant(3, "Poivron",5,1);

        }
    }
}
