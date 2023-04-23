
namespace corona
{
    partial class Form6
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
            this.resultattestcovidfalse = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.resultattestcovidtrue = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Panel();
            this.annulerchangement = new System.Windows.Forms.Button();
            this.sauvegarderchangement = new System.Windows.Forms.Button();
            this.retourner = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.testcovid = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpetat = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.ntetat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adresseetat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.npetat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cinetat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testss = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testss)).BeginInit();
            this.SuspendLayout();
            // 
            // resultattestcovidfalse
            // 
            this.resultattestcovidfalse.AllowDrop = true;
            this.resultattestcovidfalse.AutoCheck = false;
            this.resultattestcovidfalse.AutoSize = true;
            this.resultattestcovidfalse.CausesValidation = false;
            this.resultattestcovidfalse.Enabled = false;
            this.resultattestcovidfalse.Location = new System.Drawing.Point(372, 277);
            this.resultattestcovidfalse.Name = "resultattestcovidfalse";
            this.resultattestcovidfalse.Size = new System.Drawing.Size(17, 16);
            this.resultattestcovidfalse.TabIndex = 94;
            this.resultattestcovidfalse.Tag = "1";
            this.resultattestcovidfalse.UseVisualStyleBackColor = true;
            this.resultattestcovidfalse.Click += new System.EventHandler(this.resultattestcovidfalse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Faux :";
            // 
            // resultattestcovidtrue
            // 
            this.resultattestcovidtrue.AllowDrop = true;
            this.resultattestcovidtrue.AutoCheck = false;
            this.resultattestcovidtrue.AutoSize = true;
            this.resultattestcovidtrue.Enabled = false;
            this.resultattestcovidtrue.Location = new System.Drawing.Point(248, 276);
            this.resultattestcovidtrue.Name = "resultattestcovidtrue";
            this.resultattestcovidtrue.Size = new System.Drawing.Size(17, 16);
            this.resultattestcovidtrue.TabIndex = 92;
            this.resultattestcovidtrue.Tag = "1";
            this.resultattestcovidtrue.UseVisualStyleBackColor = true;
            this.resultattestcovidtrue.Click += new System.EventHandler(this.resultattestcovidtrue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Vrai :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(650, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 81;
            this.label15.Text = "Code Couleur";
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(622, 12);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(149, 137);
            this.cc.TabIndex = 90;
            // 
            // annulerchangement
            // 
            this.annulerchangement.Location = new System.Drawing.Point(537, 387);
            this.annulerchangement.Name = "annulerchangement";
            this.annulerchangement.Size = new System.Drawing.Size(110, 51);
            this.annulerchangement.TabIndex = 89;
            this.annulerchangement.Text = "Annuler changement";
            this.annulerchangement.UseVisualStyleBackColor = true;
            this.annulerchangement.Visible = false;
            // 
            // sauvegarderchangement
            // 
            this.sauvegarderchangement.Location = new System.Drawing.Point(406, 387);
            this.sauvegarderchangement.Name = "sauvegarderchangement";
            this.sauvegarderchangement.Size = new System.Drawing.Size(125, 51);
            this.sauvegarderchangement.TabIndex = 88;
            this.sauvegarderchangement.Text = "Rendre Suspect";
            this.sauvegarderchangement.UseVisualStyleBackColor = true;
            this.sauvegarderchangement.Visible = false;
            this.sauvegarderchangement.Click += new System.EventHandler(this.sauvegarderchangement_Click);
            // 
            // retourner
            // 
            this.retourner.Location = new System.Drawing.Point(653, 387);
            this.retourner.Name = "retourner";
            this.retourner.Size = new System.Drawing.Size(118, 51);
            this.retourner.TabIndex = 87;
            this.retourner.Text = "Retourner à l\'acceuil";
            this.retourner.UseVisualStyleBackColor = true;
            this.retourner.Click += new System.EventHandler(this.retourner_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 17);
            this.label17.TabIndex = 86;
            this.label17.Text = "Resultat Test Covid :";
            // 
            // testcovid
            // 
            this.testcovid.AutoSize = true;
            this.testcovid.Enabled = false;
            this.testcovid.Location = new System.Drawing.Point(204, 250);
            this.testcovid.Name = "testcovid";
            this.testcovid.Size = new System.Drawing.Size(18, 17);
            this.testcovid.TabIndex = 85;
            this.testcovid.UseVisualStyleBackColor = true;
            this.testcovid.Click += new System.EventHandler(this.testcovid_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 17);
            this.label16.TabIndex = 84;
            this.label16.Text = "Test Covid réalisé :";
            // 
            // dtpetat
            // 
            this.dtpetat.Location = new System.Drawing.Point(204, 137);
            this.dtpetat.Name = "dtpetat";
            this.dtpetat.Size = new System.Drawing.Size(224, 22);
            this.dtpetat.TabIndex = 83;
            this.dtpetat.Value = new System.DateTime(2021, 1, 11, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 82;
            this.label14.Text = "Date de Naissance";
            // 
            // ntetat
            // 
            this.ntetat.Enabled = false;
            this.ntetat.Location = new System.Drawing.Point(204, 109);
            this.ntetat.Name = "ntetat";
            this.ntetat.Size = new System.Drawing.Size(224, 22);
            this.ntetat.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Numero de telephone";
            // 
            // Adresseetat
            // 
            this.Adresseetat.Enabled = false;
            this.Adresseetat.Location = new System.Drawing.Point(204, 81);
            this.Adresseetat.Name = "Adresseetat";
            this.Adresseetat.Size = new System.Drawing.Size(224, 22);
            this.Adresseetat.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Adresse";
            // 
            // npetat
            // 
            this.npetat.Enabled = false;
            this.npetat.Location = new System.Drawing.Point(204, 53);
            this.npetat.Name = "npetat";
            this.npetat.Size = new System.Drawing.Size(224, 22);
            this.npetat.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nom et Prenom";
            // 
            // cinetat
            // 
            this.cinetat.Enabled = false;
            this.cinetat.Location = new System.Drawing.Point(204, 25);
            this.cinetat.Name = "cinetat";
            this.cinetat.Size = new System.Drawing.Size(224, 22);
            this.cinetat.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "CIN";
            // 
            // testss
            // 
            this.testss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testss.Location = new System.Drawing.Point(530, 211);
            this.testss.Name = "testss";
            this.testss.RowHeadersWidth = 51;
            this.testss.RowTemplate.Height = 24;
            this.testss.Size = new System.Drawing.Size(240, 150);
            this.testss.TabIndex = 95;
            this.testss.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testss);
            this.Controls.Add(this.resultattestcovidfalse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultattestcovidtrue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.annulerchangement);
            this.Controls.Add(this.sauvegarderchangement);
            this.Controls.Add(this.retourner);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.testcovid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtpetat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ntetat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adresseetat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.npetat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cinetat);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.testss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton resultattestcovidfalse;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton resultattestcovidtrue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Panel cc;
        private System.Windows.Forms.Button annulerchangement;
        private System.Windows.Forms.Button sauvegarderchangement;
        private System.Windows.Forms.Button retourner;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.CheckBox testcovid;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DateTimePicker dtpetat;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox ntetat;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Adresseetat;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox npetat;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox cinetat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView testss;
    }
}