namespace gestion_des_commandes
{
    partial class clientForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.T_ville = new System.Windows.Forms.TextBox();
            this.T_adresse = new System.Windows.Forms.TextBox();
            this.T_nom = new System.Windows.Forms.TextBox();
            this.T_num = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.T_find_num = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nbrcl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(658, 354);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 87;
            // 
            // T_ville
            // 
            this.T_ville.Location = new System.Drawing.Point(188, 257);
            this.T_ville.Name = "T_ville";
            this.T_ville.Size = new System.Drawing.Size(148, 20);
            this.T_ville.TabIndex = 86;
            // 
            // T_adresse
            // 
            this.T_adresse.Location = new System.Drawing.Point(188, 201);
            this.T_adresse.Name = "T_adresse";
            this.T_adresse.Size = new System.Drawing.Size(148, 20);
            this.T_adresse.TabIndex = 85;
            // 
            // T_nom
            // 
            this.T_nom.Location = new System.Drawing.Point(188, 153);
            this.T_nom.Name = "T_nom";
            this.T_nom.Size = new System.Drawing.Size(148, 20);
            this.T_nom.TabIndex = 84;
            // 
            // T_num
            // 
            this.T_num.Location = new System.Drawing.Point(188, 112);
            this.T_num.Name = "T_num";
            this.T_num.Size = new System.Drawing.Size(148, 20);
            this.T_num.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.T_find_num);
            this.panel1.Controls.Add(this.btn_find);
            this.panel1.Location = new System.Drawing.Point(614, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "numéro de client:";
            // 
            // T_find_num
            // 
            this.T_find_num.Location = new System.Drawing.Point(26, 40);
            this.T_find_num.Name = "T_find_num";
            this.T_find_num.Size = new System.Drawing.Size(148, 20);
            this.T_find_num.TabIndex = 16;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(44, 74);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(116, 23);
            this.btn_find.TabIndex = 12;
            this.btn_find.Text = "Rechercher";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(710, 190);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 41);
            this.btn_delete.TabIndex = 81;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(710, 259);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(116, 44);
            this.btn_modify.TabIndex = 80;
            this.btn_modify.Text = "Modifier";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(710, 129);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 40);
            this.btn_add.TabIndex = 79;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(710, 55);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(116, 40);
            this.btn_new.TabIndex = 78;
            this.btn_new.Text = "Nouveau";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgv_clients
            // 
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Location = new System.Drawing.Point(87, 354);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.RowHeadersWidth = 62;
            this.dgv_clients.Size = new System.Drawing.Size(460, 195);
            this.dgv_clients.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "liste des clients:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "ville:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Numéro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 37);
            this.label1.TabIndex = 71;
            this.label1.Text = "GESTION DES CLIENTS";
            // 
            // label_nbrcl
            // 
            this.label_nbrcl.AutoSize = true;
            this.label_nbrcl.Location = new System.Drawing.Point(378, 564);
            this.label_nbrcl.Name = "label_nbrcl";
            this.label_nbrcl.Size = new System.Drawing.Size(35, 13);
            this.label_nbrcl.TabIndex = 89;
            this.label_nbrcl.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "nombre de client:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_des_commandes.Properties.Resources.closingicon;
            this.pictureBox1.Location = new System.Drawing.Point(854, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_nbrcl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.T_ville);
            this.Controls.Add(this.T_adresse);
            this.Controls.Add(this.T_nom);
            this.Controls.Add(this.T_num);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv_clients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox T_ville;
        private System.Windows.Forms.TextBox T_adresse;
        private System.Windows.Forms.TextBox T_nom;
        private System.Windows.Forms.TextBox T_num;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox T_find_num;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nbrcl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

