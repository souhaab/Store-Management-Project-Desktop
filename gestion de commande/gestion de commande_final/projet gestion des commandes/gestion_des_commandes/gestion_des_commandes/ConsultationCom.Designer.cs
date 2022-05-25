namespace gestion_des_commandes
{
    partial class ConsultationCom
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
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.tb_pht = new System.Windows.Forms.TextBox();
            this.tb_tva = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_detailcmd = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_cmd = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.combo_client = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailcmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(469, 264);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(170, 48);
            this.btn_supprimer.TabIndex = 39;
            this.btn_supprimer.Text = ">> supprimer la commandre";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // tb_pht
            // 
            this.tb_pht.Location = new System.Drawing.Point(733, 525);
            this.tb_pht.Name = "tb_pht";
            this.tb_pht.Size = new System.Drawing.Size(100, 20);
            this.tb_pht.TabIndex = 38;
            // 
            // tb_tva
            // 
            this.tb_tva.Location = new System.Drawing.Point(733, 491);
            this.tb_tva.Name = "tb_tva";
            this.tb_tva.Size = new System.Drawing.Size(100, 20);
            this.tb_tva.TabIndex = 37;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(733, 465);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(100, 20);
            this.tb_total.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(652, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Prix HT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "TVA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total :";
            // 
            // dgv_detailcmd
            // 
            this.dgv_detailcmd.AllowUserToAddRows = false;
            this.dgv_detailcmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detailcmd.Location = new System.Drawing.Point(104, 451);
            this.dgv_detailcmd.Name = "dgv_detailcmd";
            this.dgv_detailcmd.Size = new System.Drawing.Size(459, 237);
            this.dgv_detailcmd.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Détails  de la commande selectionée :";
            // 
            // dgv_cmd
            // 
            this.dgv_cmd.AllowUserToAddRows = false;
            this.dgv_cmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cmd.Location = new System.Drawing.Point(107, 226);
            this.dgv_cmd.Name = "dgv_cmd";
            this.dgv_cmd.Size = new System.Drawing.Size(310, 150);
            this.dgv_cmd.TabIndex = 30;
            this.dgv_cmd.Click += new System.EventHandler(this.dgv_cmd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Commandes du client ";
            // 
            // tb_ca
            // 
            this.tb_ca.Location = new System.Drawing.Point(586, 128);
            this.tb_ca.Name = "tb_ca";
            this.tb_ca.Size = new System.Drawing.Size(100, 20);
            this.tb_ca.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "chiffre d\'affaire :";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(177, 164);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(100, 20);
            this.tb_ville.TabIndex = 26;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(177, 135);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 25;
            // 
            // combo_client
            // 
            this.combo_client.FormattingEnabled = true;
            this.combo_client.Location = new System.Drawing.Point(177, 104);
            this.combo_client.Name = "combo_client";
            this.combo_client.Size = new System.Drawing.Size(121, 21);
            this.combo_client.TabIndex = 24;
            this.combo_client.SelectedIndexChanged += new System.EventHandler(this.combo_client_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Code client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ville :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultation des commandes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_des_commandes.Properties.Resources.closingicon;
            this.pictureBox1.Location = new System.Drawing.Point(964, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ConsultationCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.tb_pht);
            this.Controls.Add(this.tb_tva);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_detailcmd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_cmd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_ca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.combo_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultationCom";
            this.Text = "ConsultationCom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultationCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailcmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.TextBox tb_pht;
        private System.Windows.Forms.TextBox tb_tva;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_detailcmd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_cmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.ComboBox combo_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}