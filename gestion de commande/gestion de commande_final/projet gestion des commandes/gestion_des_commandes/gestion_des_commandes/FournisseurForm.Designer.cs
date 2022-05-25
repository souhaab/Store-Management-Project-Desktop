namespace gestion_des_commandes
{
    partial class FournisseurForm
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
            this.dgv_f = new System.Windows.Forms.DataGridView();
            this.T_villeF = new System.Windows.Forms.TextBox();
            this.T_nomF = new System.Windows.Forms.TextBox();
            this.T_numF = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.T_find_numF = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label_nbrf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_f)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_f
            // 
            this.dgv_f.AllowUserToAddRows = false;
            this.dgv_f.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_f.Location = new System.Drawing.Point(22, 376);
            this.dgv_f.Name = "dgv_f";
            this.dgv_f.Size = new System.Drawing.Size(343, 212);
            this.dgv_f.TabIndex = 69;
            // 
            // T_villeF
            // 
            this.T_villeF.Location = new System.Drawing.Point(142, 223);
            this.T_villeF.Name = "T_villeF";
            this.T_villeF.Size = new System.Drawing.Size(148, 20);
            this.T_villeF.TabIndex = 68;
            // 
            // T_nomF
            // 
            this.T_nomF.Location = new System.Drawing.Point(142, 175);
            this.T_nomF.Name = "T_nomF";
            this.T_nomF.Size = new System.Drawing.Size(148, 20);
            this.T_nomF.TabIndex = 67;
            // 
            // T_numF
            // 
            this.T_numF.Location = new System.Drawing.Point(142, 133);
            this.T_numF.Name = "T_numF";
            this.T_numF.Size = new System.Drawing.Size(148, 20);
            this.T_numF.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.T_find_numF);
            this.panel1.Controls.Add(this.btn_find);
            this.panel1.Location = new System.Drawing.Point(567, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "numéro de fournisseur:";
            // 
            // T_find_numF
            // 
            this.T_find_numF.Location = new System.Drawing.Point(26, 40);
            this.T_find_numF.Name = "T_find_numF";
            this.T_find_numF.Size = new System.Drawing.Size(148, 20);
            this.T_find_numF.TabIndex = 16;
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
            this.btn_delete.Location = new System.Drawing.Point(663, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 41);
            this.btn_delete.TabIndex = 64;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(663, 281);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(116, 44);
            this.btn_modify.TabIndex = 63;
            this.btn_modify.Text = "Modifier";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(663, 151);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 40);
            this.btn_add.TabIndex = 62;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(663, 76);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(116, 40);
            this.btn_new.TabIndex = 61;
            this.btn_new.Text = "Nouveau";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label_nbrf
            // 
            this.label_nbrf.AutoSize = true;
            this.label_nbrf.Location = new System.Drawing.Point(224, 608);
            this.label_nbrf.Name = "label_nbrf";
            this.label_nbrf.Size = new System.Drawing.Size(35, 13);
            this.label_nbrf.TabIndex = 60;
            this.label_nbrf.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "nombre de fournisseurs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "liste des fournisseurs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "ville:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Numéro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "GESTION DES FOURNISSEURS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_des_commandes.Properties.Resources.closingicon;
            this.pictureBox1.Location = new System.Drawing.Point(741, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FournisseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_f);
            this.Controls.Add(this.T_villeF);
            this.Controls.Add(this.T_nomF);
            this.Controls.Add(this.T_numF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label_nbrf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FournisseurForm";
            this.Text = "FournisseurForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FournisseurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_f)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_f;
        private System.Windows.Forms.TextBox T_villeF;
        private System.Windows.Forms.TextBox T_nomF;
        private System.Windows.Forms.TextBox T_numF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox T_find_numF;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label_nbrf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}