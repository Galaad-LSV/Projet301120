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
            this.checkSurPlace = new System.Windows.Forms.CheckBox();
            this.checkEmporter = new System.Windows.Forms.CheckBox();
            this.DGVListePizza = new System.Windows.Forms.DataGridView();
            this.DGVIngredients = new System.Windows.Forms.DataGridView();
            this.DGVCommande = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListePizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(374, 110);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 4;
            // 
            // checkSurPlace
            // 
            this.checkSurPlace.AutoSize = true;
            this.checkSurPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSurPlace.Location = new System.Drawing.Point(110, 89);
            this.checkSurPlace.Name = "checkSurPlace";
            this.checkSurPlace.Size = new System.Drawing.Size(139, 33);
            this.checkSurPlace.TabIndex = 5;
            this.checkSurPlace.Text = "Sur Place";
            this.checkSurPlace.UseVisualStyleBackColor = true;
            // 
            // checkEmporter
            // 
            this.checkEmporter.AutoSize = true;
            this.checkEmporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmporter.Location = new System.Drawing.Point(110, 130);
            this.checkEmporter.Name = "checkEmporter";
            this.checkEmporter.Size = new System.Drawing.Size(135, 33);
            this.checkEmporter.TabIndex = 6;
            this.checkEmporter.Text = "Emporter";
            this.checkEmporter.UseVisualStyleBackColor = true;
            // 
            // DGVListePizza
            // 
            this.DGVListePizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListePizza.Location = new System.Drawing.Point(41, 236);
            this.DGVListePizza.Name = "DGVListePizza";
            this.DGVListePizza.RowHeadersWidth = 51;
            this.DGVListePizza.RowTemplate.Height = 24;
            this.DGVListePizza.Size = new System.Drawing.Size(332, 164);
            this.DGVListePizza.TabIndex = 7;
            // 
            // DGVIngredients
            // 
            this.DGVIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIngredients.Location = new System.Drawing.Point(389, 236);
            this.DGVIngredients.Name = "DGVIngredients";
            this.DGVIngredients.RowHeadersWidth = 51;
            this.DGVIngredients.RowTemplate.Height = 24;
            this.DGVIngredients.Size = new System.Drawing.Size(320, 164);
            this.DGVIngredients.TabIndex = 8;
            // 
            // DGVCommande
            // 
            this.DGVCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCommande.Location = new System.Drawing.Point(151, 436);
            this.DGVCommande.Name = "DGVCommande";
            this.DGVCommande.RowHeadersWidth = 51;
            this.DGVCommande.RowTemplate.Height = 24;
            this.DGVCommande.Size = new System.Drawing.Size(485, 85);
            this.DGVCommande.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(492, 557);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liste des Pizzas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ingrédients";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 58);
            this.label6.TabIndex = 14;
            this.label6.Text = "    Pizza \r\ncommandé\r\n";
            // 
            // CommandeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 606);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.DGVCommande);
            this.Controls.Add(this.DGVIngredients);
            this.Controls.Add(this.DGVListePizza);
            this.Controls.Add(this.checkEmporter);
            this.Controls.Add(this.checkSurPlace);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.CheckBox checkSurPlace;
        private System.Windows.Forms.CheckBox checkEmporter;
        private System.Windows.Forms.DataGridView DGVListePizza;
        private System.Windows.Forms.DataGridView DGVIngredients;
        private System.Windows.Forms.DataGridView DGVCommande;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}