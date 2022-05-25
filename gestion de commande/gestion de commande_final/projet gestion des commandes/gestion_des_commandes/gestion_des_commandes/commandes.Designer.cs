namespace gestion_des_commandes
{
    partial class commandes
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
            this.T_ville_cl = new System.Windows.Forms.TextBox();
            this.T_nom_cl = new System.Windows.Forms.TextBox();
            this.date_comd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_ville_comd = new System.Windows.Forms.Label();
            this.combo_num_cl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_num_cmd = new System.Windows.Forms.TextBox();
            this.lbl_dateC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.T_prix_prod = new System.Windows.Forms.TextBox();
            this.T_code_prod = new System.Windows.Forms.TextBox();
            this.btn_supp_article = new System.Windows.Forms.Button();
            this.dgv_commande = new System.Windows.Forms.DataGridView();
            this.nump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_qtte_c = new System.Windows.Forms.TextBox();
            this.combodesc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t_totale_p = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // T_ville_cl
            // 
            this.T_ville_cl.Enabled = false;
            this.T_ville_cl.Location = new System.Drawing.Point(759, 136);
            this.T_ville_cl.Name = "T_ville_cl";
            this.T_ville_cl.Size = new System.Drawing.Size(121, 20);
            this.T_ville_cl.TabIndex = 134;
            // 
            // T_nom_cl
            // 
            this.T_nom_cl.Enabled = false;
            this.T_nom_cl.Location = new System.Drawing.Point(759, 94);
            this.T_nom_cl.Name = "T_nom_cl";
            this.T_nom_cl.Size = new System.Drawing.Size(121, 20);
            this.T_nom_cl.TabIndex = 133;
            // 
            // date_comd
            // 
            this.date_comd.Location = new System.Drawing.Point(296, 115);
            this.date_comd.Name = "date_comd";
            this.date_comd.Size = new System.Drawing.Size(200, 20);
            this.date_comd.TabIndex = 132;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 131;
            this.label9.Text = "selection article";
            // 
            // lbl_ville_comd
            // 
            this.lbl_ville_comd.AutoSize = true;
            this.lbl_ville_comd.Location = new System.Drawing.Point(762, 120);
            this.lbl_ville_comd.Name = "lbl_ville_comd";
            this.lbl_ville_comd.Size = new System.Drawing.Size(0, 13);
            this.lbl_ville_comd.TabIndex = 130;
            // 
            // combo_num_cl
            // 
            this.combo_num_cl.FormattingEnabled = true;
            this.combo_num_cl.Location = new System.Drawing.Point(759, 63);
            this.combo_num_cl.Name = "combo_num_cl";
            this.combo_num_cl.Size = new System.Drawing.Size(121, 21);
            this.combo_num_cl.TabIndex = 129;
            this.combo_num_cl.SelectedIndexChanged += new System.EventHandler(this.combo_num_cl_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "numero de client:";
            // 
            // t_num_cmd
            // 
            this.t_num_cmd.Location = new System.Drawing.Point(296, 87);
            this.t_num_cmd.Name = "t_num_cmd";
            this.t_num_cmd.Size = new System.Drawing.Size(200, 20);
            this.t_num_cmd.TabIndex = 125;
            // 
            // lbl_dateC
            // 
            this.lbl_dateC.AutoSize = true;
            this.lbl_dateC.Location = new System.Drawing.Point(192, 113);
            this.lbl_dateC.Name = "lbl_dateC";
            this.lbl_dateC.Size = new System.Drawing.Size(85, 13);
            this.lbl_dateC.TabIndex = 124;
            this.lbl_dateC.Text = "Date commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "Num de commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 122;
            this.label1.Text = "Gestion de commande";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(805, 216);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 121;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // T_prix_prod
            // 
            this.T_prix_prod.Enabled = false;
            this.T_prix_prod.Location = new System.Drawing.Point(479, 211);
            this.T_prix_prod.Name = "T_prix_prod";
            this.T_prix_prod.Size = new System.Drawing.Size(100, 20);
            this.T_prix_prod.TabIndex = 120;
            // 
            // T_code_prod
            // 
            this.T_code_prod.Enabled = false;
            this.T_code_prod.Location = new System.Drawing.Point(352, 211);
            this.T_code_prod.Name = "T_code_prod";
            this.T_code_prod.Size = new System.Drawing.Size(100, 20);
            this.T_code_prod.TabIndex = 119;
            // 
            // btn_supp_article
            // 
            this.btn_supp_article.Location = new System.Drawing.Point(1025, 272);
            this.btn_supp_article.Name = "btn_supp_article";
            this.btn_supp_article.Size = new System.Drawing.Size(117, 23);
            this.btn_supp_article.TabIndex = 118;
            this.btn_supp_article.Text = "Supprimer article";
            this.btn_supp_article.UseVisualStyleBackColor = true;
            this.btn_supp_article.Click += new System.EventHandler(this.btn_supp_article_Click);
            // 
            // dgv_commande
            // 
            this.dgv_commande.AllowUserToAddRows = false;
            this.dgv_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nump,
            this.descriptionp,
            this.qtte,
            this.prix,
            this.montant});
            this.dgv_commande.Location = new System.Drawing.Point(156, 272);
            this.dgv_commande.Name = "dgv_commande";
            this.dgv_commande.RowHeadersWidth = 62;
            this.dgv_commande.Size = new System.Drawing.Size(863, 184);
            this.dgv_commande.TabIndex = 117;
            // 
            // nump
            // 
            this.nump.HeaderText = "Nom produit";
            this.nump.MinimumWidth = 8;
            this.nump.Name = "nump";
            this.nump.Width = 150;
            // 
            // descriptionp
            // 
            this.descriptionp.HeaderText = "Description";
            this.descriptionp.MinimumWidth = 8;
            this.descriptionp.Name = "descriptionp";
            this.descriptionp.Width = 150;
            // 
            // qtte
            // 
            this.qtte.HeaderText = "Qtte";
            this.qtte.MinimumWidth = 8;
            this.qtte.Name = "qtte";
            this.qtte.Width = 150;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.MinimumWidth = 8;
            this.prix.Name = "prix";
            this.prix.Width = 150;
            // 
            // montant
            // 
            this.montant.HeaderText = "Montant";
            this.montant.MinimumWidth = 8;
            this.montant.Name = "montant";
            this.montant.Width = 150;
            // 
            // t_qtte_c
            // 
            this.t_qtte_c.Location = new System.Drawing.Point(649, 218);
            this.t_qtte_c.Name = "t_qtte_c";
            this.t_qtte_c.Size = new System.Drawing.Size(100, 20);
            this.t_qtte_c.TabIndex = 116;
            // 
            // combodesc
            // 
            this.combodesc.FormattingEnabled = true;
            this.combodesc.Location = new System.Drawing.Point(192, 210);
            this.combodesc.Name = "combodesc";
            this.combodesc.Size = new System.Drawing.Size(121, 21);
            this.combodesc.TabIndex = 115;
            this.combodesc.SelectedIndexChanged += new System.EventHandler(this.combodesc_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 114;
            this.label14.Text = "Contenu commande";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(645, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 113;
            this.label13.Text = "Quantité de commande";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(497, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 112;
            this.label12.Text = "Prix unitére";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Disignation";
            // 
            // t_totale_p
            // 
            this.t_totale_p.AutoSize = true;
            this.t_totale_p.Location = new System.Drawing.Point(497, 475);
            this.t_totale_p.Name = "t_totale_p";
            this.t_totale_p.Size = new System.Drawing.Size(0, 13);
            this.t_totale_p.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 135;
            this.label7.Text = "PrixTotale:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 44);
            this.button1.TabIndex = 137;
            this.button1.Text = "Save Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_des_commandes.Properties.Resources.closingicon;
            this.pictureBox1.Location = new System.Drawing.Point(1115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1174, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_totale_p);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.T_ville_cl);
            this.Controls.Add(this.T_nom_cl);
            this.Controls.Add(this.date_comd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_ville_comd);
            this.Controls.Add(this.combo_num_cl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_num_cmd);
            this.Controls.Add(this.lbl_dateC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.T_prix_prod);
            this.Controls.Add(this.T_code_prod);
            this.Controls.Add(this.btn_supp_article);
            this.Controls.Add(this.dgv_commande);
            this.Controls.Add(this.t_qtte_c);
            this.Controls.Add(this.combodesc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "commandes";
            this.Text = "commandes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.commandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_ville_cl;
        private System.Windows.Forms.TextBox T_nom_cl;
        private System.Windows.Forms.DateTimePicker date_comd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_ville_comd;
        private System.Windows.Forms.ComboBox combo_num_cl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_num_cmd;
        private System.Windows.Forms.Label lbl_dateC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox T_prix_prod;
        private System.Windows.Forms.TextBox T_code_prod;
        private System.Windows.Forms.Button btn_supp_article;
        private System.Windows.Forms.DataGridView dgv_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn nump;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionp;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtte;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.TextBox t_qtte_c;
        private System.Windows.Forms.ComboBox combodesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label t_totale_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}