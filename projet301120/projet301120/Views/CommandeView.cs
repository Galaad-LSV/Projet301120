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
            Composant i1 = new Composant(1, "Anchois", 3, 2);
            Composant i2 = new Composant(2, "Oeuf", 1, 0.5);
            Composant i3 = new Composant(3, "Poivron",5,1);
            Composant i4 = new Composant(4, "Fromage", 100, 1.50);
            Composant i5 = new Composant(5, "Olives", 10, 5);
            Composant i6 = new Composant(6, "Champignon", 5, 2.5);
            Composant i7 = new Composant(7, "Tomates", 15, 0.25);
            Composant i8 = new Composant(8, "Jambon", 50, 4);
            Composant i9 = new Composant(9, "Oignons", 60, 5);
            Composant i10 = new Composant(10, "Sauce Tomates", 500, 6);
            Composant i11 = new Composant(11, "Merguez", 50, 2);
            Pizza p1= new Emporter(1, "Margherita ", 15, 2);
            Pizza p2 = new Emporter(2,"Reine",19,1);
            Pizza p3 = new SurPlace("Jouet Mignon",3, "Napolitaine", 19);
            Pizza p4 = new SurPlace("Jouet LapinCretin",4, "Rustique",25);
            c1.LesCommandes.Add(co1);
            c2.LesCommandes.Add(co2);
            c2.LesCommandes.Add(co3);
            c1.LesCommandes.Add(co4);           
            p1.LesIngredients.Add(i10);
            p1.LesIngredients.Add(i4);
            p2.LesIngredients.Add(i10);
            p2.LesIngredients.Add(i4);
            p2.LesIngredients.Add(i6);
            p2.LesIngredients.Add(i8);
            p3.LesIngredients.Add(i10);
            p3.LesIngredients.Add(i4);
            p3.LesIngredients.Add(i5);
            p3.LesIngredients.Add(i1);
            p4.LesIngredients.Add(i10);
            p4.LesIngredients.Add(i4);
            p4.LesIngredients.Add(i9);
            p4.LesIngredients.Add(i3);
            p4.LesIngredients.Add(i2);
            p4.LesIngredients.Add(i11);
        }
    }
}
