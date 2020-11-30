namespace projet301120.Views
{
    partial class CommandeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.DGVListePizza = new System.Windows.Forms.DataGridView();
            this.DGVIngredients = new System.Windows.Forms.DataGridView();
            this.DGVCommande = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListePizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(280, 89);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 4;
            // 
            // DGVListePizza
            // 
            this.DGVListePizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListePizza.Location = new System.Drawing.Point(31, 192);
            this.DGVListePizza.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListePizza.Name = "DGVListePizza";
            this.DGVListePizza.RowHeadersWidth = 51;
            this.DGVListePizza.RowTemplate.Height = 24;
            this.DGVListePizza.Size = new System.Drawing.Size(249, 133);
            this.DGVListePizza.TabIndex = 7;
            this.DGVListePizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListePizza_CellContentClick);
            this.DGVListePizza.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListePizza_CellDoubleClick);
            this.DGVListePizza.SelectionChanged += new System.EventHandler(this.DGVListePizza_SelectionChanged);
            // 
            // DGVIngredients
            // 
            this.DGVIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIngredients.Location = new System.Drawing.Point(292, 192);
            this.DGVIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.DGVIngredients.Name = "DGVIngredients";
            this.DGVIngredients.RowHeadersWidth = 51;
            this.DGVIngredients.RowTemplate.Height = 24;
            this.DGVIngredients.Size = new System.Drawing.Size(240, 133);
            this.DGVIngredients.TabIndex = 8;
            this.DGVIngredients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVIngredients_CellContentClick);
            // 
            // DGVCommande
            // 
            this.DGVCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCommande.Location = new System.Drawing.Point(113, 354);
            this.DGVCommande.Margin = new System.Windows.Forms.Padding(2);
            this.DGVCommande.Name = "DGVCommande";
            this.DGVCommande.RowHeadersWidth = 51;
            this.DGVCommande.RowTemplate.Height = 24;
            this.DGVCommande.Size = new System.Drawing.Size(364, 69);
            this.DGVCommande.TabIndex = 9;
            this.DGVCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCommande_CellContentClick);
            this.DGVCommande.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVCommande_CellMouseDoubleClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(369, 453);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liste des Pizzas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ingrédients";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "    Pizza \r\ncommandé\r\n";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(477, 23);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(54, 26);
            this.btnRetour.TabIndex = 15;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sur Place",
            "Emporter"});
            this.checkedListBox1.Location = new System.Drawing.Point(63, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(84, 34);
            this.checkedListBox1.TabIndex = 16;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Enabled = false;
            this.btnConfirmer.Location = new System.Drawing.Point(193, 453);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(74, 27);
            this.btnConfirmer.TabIndex = 17;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // CommandeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 492);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.DGVCommande);
            this.Controls.Add(this.DGVIngredients);
            this.Controls.Add(this.DGVListePizza);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "CommandeView";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.CommandeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListePizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView DGVListePizza;
        private System.Windows.Forms.DataGridView DGVIngredients;
        private System.Windows.Forms.DataGridView DGVCommande;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnConfirmer;
    }
}