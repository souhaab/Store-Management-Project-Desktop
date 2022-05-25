namespace gestion_des_commandes
{
    partial class ProduitForm
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
            this.lbl_nbr = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_nbrtotale = new System.Windows.Forms.Label();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_prec = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.comboBox_fournisseur = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.t_find_num = new System.Windows.Forms.TextBox();
            this.t_description = new System.Windows.Forms.TextBox();
            this.t_prix = new System.Windows.Forms.TextBox();
            this.t_num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nbr
            // 
            this.lbl_nbr.AutoSize = true;
            this.lbl_nbr.Location = new System.Drawing.Point(305, 276);
            this.lbl_nbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nbr.Name = "lbl_nbr";
            this.lbl_nbr.Size = new System.Drawing.Size(0, 13);
            this.lbl_nbr.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 276);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "/";
            // 
            // lbl_nbrtotale
            // 
            this.lbl_nbrtotale.AutoSize = true;
            this.lbl_nbrtotale.Location = new System.Drawing.Point(370, 276);
            this.lbl_nbrtotale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nbrtotale.Name = "lbl_nbrtotale";
            this.lbl_nbrtotale.Size = new System.Drawing.Size(0, 13);
            this.lbl_nbrtotale.TabIndex = 101;
            // 
            // btn_derniere
            // 
            this.btn_derniere.Location = new System.Drawing.Point(423, 308);
            this.btn_derniere.Margin = new System.Windows.Forms.Padding(2);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(68, 24);
            this.btn_derniere.TabIndex = 93;
            this.btn_derniere.Text = ">>";
            this.btn_derniere.UseVisualStyleBackColor = true;
            this.btn_derniere.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_prec
            // 
            this.btn_prec.Location = new System.Drawing.Point(249, 308);
            this.btn_prec.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prec.Name = "btn_prec";
            this.btn_prec.Size = new System.Drawing.Size(68, 24);
            this.btn_prec.TabIndex = 97;
            this.btn_prec.Text = "<";
            this.btn_prec.UseVisualStyleBackColor = true;
            this.btn_prec.Click += new System.EventHandler(this.btn_prec_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(159, 308);
            this.btn_premier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(68, 24);
            this.btn_premier.TabIndex = 99;
            this.btn_premier.Text = "<<";
            this.btn_premier.UseVisualStyleBackColor = true;
            this.btn_premier.Click += new System.EventHandler(this.btn_premier_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(343, 308);
            this.btn_suivant.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(68, 24);
            this.btn_suivant.TabIndex = 100;
            this.btn_suivant.Text = ">";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(545, 88);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(110, 24);
            this.btn_supprimer.TabIndex = 98;
            this.btn_supprimer.Text = "supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(545, 143);
            this.btn_nouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(110, 24);
            this.btn_nouveau.TabIndex = 92;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(692, 143);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(110, 24);
            this.btn_modifier.TabIndex = 96;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // comboBox_fournisseur
            // 
            this.comboBox_fournisseur.FormattingEnabled = true;
            this.comboBox_fournisseur.Location = new System.Drawing.Point(180, 160);
            this.comboBox_fournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_fournisseur.Name = "comboBox_fournisseur";
            this.comboBox_fournisseur.Size = new System.Drawing.Size(82, 21);
            this.comboBox_fournisseur.TabIndex = 95;
            this.comboBox_fournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBox_fournisseur_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.t_find_num);
            this.panel1.Location = new System.Drawing.Point(561, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 65);
            this.panel1.TabIndex = 94;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(147, 25);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(37, 24);
            this.btn_ok.TabIndex = 16;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Num :";
            // 
            // t_find_num
            // 
            this.t_find_num.Location = new System.Drawing.Point(65, 29);
            this.t_find_num.Margin = new System.Windows.Forms.Padding(2);
            this.t_find_num.Name = "t_find_num";
            this.t_find_num.Size = new System.Drawing.Size(68, 20);
            this.t_find_num.TabIndex = 14;
            // 
            // t_description
            // 
            this.t_description.Location = new System.Drawing.Point(180, 98);
            this.t_description.Margin = new System.Windows.Forms.Padding(2);
            this.t_description.Name = "t_description";
            this.t_description.Size = new System.Drawing.Size(68, 20);
            this.t_description.TabIndex = 91;
            // 
            // t_prix
            // 
            this.t_prix.Location = new System.Drawing.Point(180, 129);
            this.t_prix.Margin = new System.Windows.Forms.Padding(2);
            this.t_prix.Name = "t_prix";
            this.t_prix.Size = new System.Drawing.Size(68, 20);
            this.t_prix.TabIndex = 90;
            // 
            // t_num
            // 
            this.t_num.Location = new System.Drawing.Point(180, 65);
            this.t_num.Margin = new System.Windows.Forms.Padding(2);
            this.t_num.Name = "t_num";
            this.t_num.Size = new System.Drawing.Size(68, 20);
            this.t_num.TabIndex = 89;
            this.t_num.TextChanged += new System.EventHandler(this.t_num_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Fournisseur :";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(156, 199);
            this.lbl_num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(0, 13);
            this.lbl_num.TabIndex = 87;
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(275, 199);
            this.lbl_ville.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(0, 13);
            this.lbl_ville.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Ville  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Num :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Gestion des produits";
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(692, 87);
            this.btn_sup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(110, 24);
            this.btn_sup.TabIndex = 104;
            this.btn_sup.Text = "supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_des_commandes.Properties.Resources.closingicon;
            this.pictureBox1.Location = new System.Drawing.Point(778, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProduitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.lbl_nbr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_nbrtotale);
            this.Controls.Add(this.btn_derniere);
            this.Controls.Add(this.btn_prec);
            this.Controls.Add(this.btn_premier);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.comboBox_fournisseur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.t_description);
            this.Controls.Add(this.t_prix);
            this.Controls.Add(this.t_num);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduitForm";
            this.Text = "ProduitForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProduitForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nbr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_nbrtotale;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_prec;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.ComboBox comboBox_fournisseur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_find_num;
        private System.Windows.Forms.TextBox t_description;
        private System.Windows.Forms.TextBox t_prix;
        private System.Windows.Forms.TextBox t_num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}