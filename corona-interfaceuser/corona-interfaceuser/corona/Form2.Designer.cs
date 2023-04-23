
namespace corona
{
    partial class Form2
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
            this.Return = new System.Windows.Forms.Button();
            this.Cin = new System.Windows.Forms.TextBox();
            this.NometPrenom = new System.Windows.Forms.TextBox();
            this.Numerodetelephone = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Datedenaissance = new System.Windows.Forms.DateTimePicker();
            this.add = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.Label();
            this.dbresults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbresults)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(581, 390);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(207, 48);
            this.Return.TabIndex = 0;
            this.Return.Text = "Retourner à la page d\'acceuil";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Cin
            // 
            this.Cin.Location = new System.Drawing.Point(249, 82);
            this.Cin.MaxLength = 8;
            this.Cin.Name = "Cin";
            this.Cin.Size = new System.Drawing.Size(215, 22);
            this.Cin.TabIndex = 1;
            this.Cin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NometPrenom
            // 
            this.NometPrenom.Location = new System.Drawing.Point(249, 126);
            this.NometPrenom.Name = "NometPrenom";
            this.NometPrenom.Size = new System.Drawing.Size(215, 22);
            this.NometPrenom.TabIndex = 2;
            this.NometPrenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Numerodetelephone
            // 
            this.Numerodetelephone.Location = new System.Drawing.Point(249, 177);
            this.Numerodetelephone.MaxLength = 10;
            this.Numerodetelephone.Name = "Numerodetelephone";
            this.Numerodetelephone.Size = new System.Drawing.Size(215, 22);
            this.Numerodetelephone.TabIndex = 3;
            this.Numerodetelephone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Numerodetelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerodetelephone_KeyPress);
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(249, 271);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(215, 22);
            this.Adresse.TabIndex = 5;
            this.Adresse.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom et Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numéro de telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adresse";
            // 
            // Datedenaissance
            // 
            this.Datedenaissance.Location = new System.Drawing.Point(249, 223);
            this.Datedenaissance.MaxDate = new System.DateTime(2020, 12, 29, 0, 0, 0, 0);
            this.Datedenaissance.Name = "Datedenaissance";
            this.Datedenaissance.Size = new System.Drawing.Size(215, 22);
            this.Datedenaissance.TabIndex = 11;
            this.Datedenaissance.Value = new System.DateTime(2020, 12, 29, 0, 0, 0, 0);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(634, 170);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 53);
            this.add.TabIndex = 12;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(249, 318);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(215, 22);
            this.password.TabIndex = 13;
            // 
            // passwordtext
            // 
            this.passwordtext.AutoSize = true;
            this.passwordtext.Location = new System.Drawing.Point(68, 318);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(93, 17);
            this.passwordtext.TabIndex = 14;
            this.passwordtext.Text = "Mot de passe";
            // 
            // dbresults
            // 
            this.dbresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbresults.Location = new System.Drawing.Point(597, 58);
            this.dbresults.Name = "dbresults";
            this.dbresults.RowHeadersWidth = 51;
            this.dbresults.RowTemplate.Height = 24;
            this.dbresults.Size = new System.Drawing.Size(240, 150);
            this.dbresults.TabIndex = 15;
            this.dbresults.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbresults);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Datedenaissance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Numerodetelephone);
            this.Controls.Add(this.NometPrenom);
            this.Controls.Add(this.Cin);
            this.Controls.Add(this.Return);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbresults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox Cin;
        private System.Windows.Forms.TextBox NometPrenom;
        private System.Windows.Forms.TextBox Numerodetelephone;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Datedenaissance;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordtext;
        private System.Windows.Forms.DataGridView dbresults;
    }
}