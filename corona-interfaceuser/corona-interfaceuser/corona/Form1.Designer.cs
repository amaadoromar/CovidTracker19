
namespace corona
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dbresults = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.checkstate = new System.Windows.Forms.Button();
            this.searchcin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.etat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rendresuspect = new System.Windows.Forms.Button();
            this.Historique = new System.Windows.Forms.Button();
            this.misajoursuspect = new System.Windows.Forms.Button();
            this.mettreajourpatient = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rendrevacc = new System.Windows.Forms.Button();
            this.affichevaccin = new System.Windows.Forms.Button();
            this.listedc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ntdall = new System.Windows.Forms.Label();
            this.ntgall = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ntcall = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ntdnow = new System.Windows.Forms.Label();
            this.ntgnow = new System.Windows.Forms.Label();
            this.ntcnow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.supprimecitoyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbresults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbresults
            // 
            this.dbresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbresults.Location = new System.Drawing.Point(280, 73);
            this.dbresults.Name = "dbresults";
            this.dbresults.RowHeadersWidth = 51;
            this.dbresults.RowTemplate.Height = 24;
            this.dbresults.Size = new System.Drawing.Size(392, 228);
            this.dbresults.TabIndex = 1;
            this.dbresults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbresults_CellClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(767, 584);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(198, 33);
            this.Add.TabIndex = 3;
            this.Add.Text = "Ajouter un citoyen";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // checkstate
            // 
            this.checkstate.Enabled = false;
            this.checkstate.Location = new System.Drawing.Point(17, 584);
            this.checkstate.Name = "checkstate";
            this.checkstate.Size = new System.Drawing.Size(164, 33);
            this.checkstate.TabIndex = 4;
            this.checkstate.Text = "Modifier Citoyen";
            this.checkstate.UseVisualStyleBackColor = true;
            this.checkstate.Click += new System.EventHandler(this.checkstate_Click);
            // 
            // searchcin
            // 
            this.searchcin.Location = new System.Drawing.Point(385, 37);
            this.searchcin.Name = "searchcin";
            this.searchcin.Size = new System.Drawing.Size(229, 22);
            this.searchcin.TabIndex = 5;
            this.searchcin.TextChanged += new System.EventHandler(this.searchcin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rechercher CIN";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(814, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 146);
            this.panel1.TabIndex = 7;
            // 
            // etat
            // 
            this.etat.AutoSize = true;
            this.etat.Location = new System.Drawing.Point(884, 345);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(0, 17);
            this.etat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // rendresuspect
            // 
            this.rendresuspect.Enabled = false;
            this.rendresuspect.Location = new System.Drawing.Point(17, 238);
            this.rendresuspect.Name = "rendresuspect";
            this.rendresuspect.Size = new System.Drawing.Size(146, 63);
            this.rendresuspect.TabIndex = 10;
            this.rendresuspect.Text = "Rendre Suspect";
            this.rendresuspect.UseVisualStyleBackColor = true;
            this.rendresuspect.Click += new System.EventHandler(this.rendresuspect_Click);
            // 
            // Historique
            // 
            this.Historique.Enabled = false;
            this.Historique.Location = new System.Drawing.Point(397, 584);
            this.Historique.Name = "Historique";
            this.Historique.Size = new System.Drawing.Size(193, 33);
            this.Historique.TabIndex = 11;
            this.Historique.Text = "Vérifier l\'historique";
            this.Historique.UseVisualStyleBackColor = true;
            this.Historique.Click += new System.EventHandler(this.Historique_Click);
            // 
            // misajoursuspect
            // 
            this.misajoursuspect.Enabled = false;
            this.misajoursuspect.Location = new System.Drawing.Point(17, 157);
            this.misajoursuspect.Name = "misajoursuspect";
            this.misajoursuspect.Size = new System.Drawing.Size(146, 69);
            this.misajoursuspect.TabIndex = 12;
            this.misajoursuspect.Text = "Mettre a jour  Resultat du test";
            this.misajoursuspect.UseVisualStyleBackColor = true;
            this.misajoursuspect.Click += new System.EventHandler(this.button3_Click);
            // 
            // mettreajourpatient
            // 
            this.mettreajourpatient.Enabled = false;
            this.mettreajourpatient.Location = new System.Drawing.Point(17, 73);
            this.mettreajourpatient.Name = "mettreajourpatient";
            this.mettreajourpatient.Size = new System.Drawing.Size(146, 78);
            this.mettreajourpatient.TabIndex = 13;
            this.mettreajourpatient.Text = "Mettre a jour  le patient";
            this.mettreajourpatient.UseVisualStyleBackColor = true;
            this.mettreajourpatient.Click += new System.EventHandler(this.mettreajourpatient_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(814, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "Afficher Suspects";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Afficher Patients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(814, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Afficher Citoyens";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // rendrevacc
            // 
            this.rendrevacc.Enabled = false;
            this.rendrevacc.Location = new System.Drawing.Point(17, 11);
            this.rendrevacc.Name = "rendrevacc";
            this.rendrevacc.Size = new System.Drawing.Size(146, 56);
            this.rendrevacc.TabIndex = 17;
            this.rendrevacc.Text = "Rendre Vacciné";
            this.rendrevacc.UseVisualStyleBackColor = true;
            this.rendrevacc.Click += new System.EventHandler(this.rendrevacc_Click);
            // 
            // affichevaccin
            // 
            this.affichevaccin.Location = new System.Drawing.Point(814, 132);
            this.affichevaccin.Name = "affichevaccin";
            this.affichevaccin.Size = new System.Drawing.Size(151, 36);
            this.affichevaccin.TabIndex = 18;
            this.affichevaccin.Text = "Afficher Vaccinés";
            this.affichevaccin.UseVisualStyleBackColor = true;
            this.affichevaccin.Click += new System.EventHandler(this.affichevaccin_Click);
            // 
            // listedc
            // 
            this.listedc.Location = new System.Drawing.Point(767, 546);
            this.listedc.Name = "listedc";
            this.listedc.Size = new System.Drawing.Size(198, 32);
            this.listedc.TabIndex = 19;
            this.listedc.Text = "Afficher les décédés";
            this.listedc.UseVisualStyleBackColor = true;
            this.listedc.Click += new System.EventHandler(this.listedc_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ntdall);
            this.panel2.Controls.Add(this.ntgall);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ntcall);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(570, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 175);
            this.panel2.TabIndex = 20;
            // 
            // ntdall
            // 
            this.ntdall.AutoSize = true;
            this.ntdall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntdall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ntdall.Location = new System.Drawing.Point(220, 116);
            this.ntdall.Name = "ntdall";
            this.ntdall.Size = new System.Drawing.Size(93, 17);
            this.ntdall.TabIndex = 9;
            this.ntdall.Text = "chargement";
            // 
            // ntgall
            // 
            this.ntgall.AutoSize = true;
            this.ntgall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntgall.ForeColor = System.Drawing.Color.Green;
            this.ntgall.Location = new System.Drawing.Point(220, 81);
            this.ntgall.Name = "ntgall";
            this.ntgall.Size = new System.Drawing.Size(93, 17);
            this.ntgall.TabIndex = 8;
            this.ntgall.Text = "chargement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(23, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre des guérisons :";
            // 
            // ntcall
            // 
            this.ntcall.AutoSize = true;
            this.ntcall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntcall.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ntcall.Location = new System.Drawing.Point(220, 49);
            this.ntcall.Name = "ntcall";
            this.ntcall.Size = new System.Drawing.Size(93, 17);
            this.ntcall.TabIndex = 7;
            this.ntcall.Text = "chargement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(23, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre des décédés :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Les statistiques depuis la lancée de l\'application";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(23, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre total de cas :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ntdnow);
            this.panel3.Controls.Add(this.ntgnow);
            this.panel3.Controls.Add(this.ntcnow);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(17, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 175);
            this.panel3.TabIndex = 21;
            // 
            // ntdnow
            // 
            this.ntdnow.AutoSize = true;
            this.ntdnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntdnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ntdnow.Location = new System.Drawing.Point(222, 116);
            this.ntdnow.Name = "ntdnow";
            this.ntdnow.Size = new System.Drawing.Size(93, 17);
            this.ntdnow.TabIndex = 6;
            this.ntdnow.Text = "chargement";
            // 
            // ntgnow
            // 
            this.ntgnow.AutoSize = true;
            this.ntgnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntgnow.ForeColor = System.Drawing.Color.Green;
            this.ntgnow.Location = new System.Drawing.Point(222, 81);
            this.ntgnow.Name = "ntgnow";
            this.ntgnow.Size = new System.Drawing.Size(93, 17);
            this.ntgnow.TabIndex = 5;
            this.ntgnow.Text = "chargement";
            // 
            // ntcnow
            // 
            this.ntcnow.AutoSize = true;
            this.ntcnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntcnow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ntcnow.Location = new System.Drawing.Point(222, 49);
            this.ntcnow.Name = "ntcnow";
            this.ntcnow.Size = new System.Drawing.Size(93, 17);
            this.ntcnow.TabIndex = 4;
            this.ntcnow.Text = "chargement";
            this.ntcnow.Click += new System.EventHandler(this.ntcnow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Les statistiques d\'aujourd\'hui";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(27, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre des guérisons :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(27, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre des décédés :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(27, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre total de cas :";
            // 
            // supprimecitoyen
            // 
            this.supprimecitoyen.Enabled = false;
            this.supprimecitoyen.Location = new System.Drawing.Point(17, 546);
            this.supprimecitoyen.Name = "supprimecitoyen";
            this.supprimecitoyen.Size = new System.Drawing.Size(164, 33);
            this.supprimecitoyen.TabIndex = 22;
            this.supprimecitoyen.Text = "Supprimer Citoyen";
            this.supprimecitoyen.UseVisualStyleBackColor = true;
            this.supprimecitoyen.Click += new System.EventHandler(this.supprimecitoyen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(977, 629);
            this.Controls.Add(this.supprimecitoyen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listedc);
            this.Controls.Add(this.affichevaccin);
            this.Controls.Add(this.rendrevacc);
            this.Controls.Add(this.Historique);
            this.Controls.Add(this.checkstate);
            this.Controls.Add(this.rendresuspect);
            this.Controls.Add(this.misajoursuspect);
            this.Controls.Add(this.mettreajourpatient);
            this.Controls.Add(this.searchcin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbresults);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbresults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dbresults;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button checkstate;
        private System.Windows.Forms.TextBox searchcin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label etat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rendresuspect;
        private System.Windows.Forms.Button Historique;
        private System.Windows.Forms.Button misajoursuspect;
        private System.Windows.Forms.Button mettreajourpatient;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button rendrevacc;
        private System.Windows.Forms.Button affichevaccin;
        private System.Windows.Forms.Button listedc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ntdall;
        private System.Windows.Forms.Label ntgall;
        private System.Windows.Forms.Label ntcall;
        private System.Windows.Forms.Label ntdnow;
        private System.Windows.Forms.Label ntgnow;
        private System.Windows.Forms.Label ntcnow;
        private System.Windows.Forms.Button supprimecitoyen;
    }
}

