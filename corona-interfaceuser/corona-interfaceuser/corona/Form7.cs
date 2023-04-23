using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corona
{
    public partial class Form7 : Form
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand qyback = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        public Citoyen Citoyensuscourant;
        public Persistance persistance = new Persistance();
        public String oldcolor;

        public Form7(Citoyen C)
        {
            Citoyensuscourant = C;
            InitializeComponent();
            bilan(Citoyensuscourant);
            oldcolor = Citoyensuscourant.CodeCouleur;
        }
        public void bilan(Citoyen C)
        {
            cinetat.Text = C.Cin;
            npetat.Text = C.NomEtPrenom;
            Adresseetat.Text = C.Adresse;
            ntetat.Text = String.Format("{0}", C.NumeroDeTelephone);
            dtpetat.Value = Convert.ToDateTime(C.DateDeNaissance);
            dtpetat.Enabled = false;
            label22.Visible = true;
            label25.Visible = true;
            label21.Visible = true;
            label13.Visible = true;
            label24.Visible = true;
            label23.Visible = true;
            label26.Visible = true;
            label5.Visible = true;
            label5.Enabled = true;
            label6.Visible = true;
            symptomegravetrue.Visible = true;
            symptomegravetrue.Enabled = true;
            symptomegravefalse.Visible = true;
            symptomegravefalse.Enabled = true;
            //label28.Visible = true;

            symptomegravetrue.Visible = true;

            gueristrue.Visible = true;
            guerisfalse.Visible = true;
            etataggravetrue.Visible = true;
            etataggravefalse.Visible = true;

            cinetat.Text = C.Cin;
            npetat.Text = C.NomEtPrenom;
            Adresseetat.Text = C.Adresse;
            ntetat.Text = String.Format("{0}", C.NumeroDeTelephone);
            dtpetat.Value = Convert.ToDateTime(C.DateDeNaissance);
            dtpetat.Enabled = false;
            symptomegravetrue.Enabled = true;



        }

      

        private void etataggravetrue_Click(object sender, EventArgs e)
        {
            etataggravefalse.Checked = etataggravetrue.Checked;
            etataggravetrue.Checked = !(etataggravefalse.Checked);
            annulerchangement.Visible = false;
            if (etataggravetrue.Checked)
                sauvegarderchangement.Visible = true;
            if (!(etataggravetrue.Checked || etataggravefalse.Checked))
                sauvegarderchangement.Visible = false;
        }

        private void etataggravefalse_Click(object sender, EventArgs e)
        {
            etataggravetrue.Checked = etataggravefalse.Checked;
            etataggravefalse.Checked = !(etataggravetrue.Checked);
            annulerchangement.Visible = false;
            if (etataggravetrue.Checked)
                sauvegarderchangement.Visible = true;
            if (!(etataggravetrue.Checked || etataggravefalse.Checked))
                sauvegarderchangement.Visible = false;
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            retourner_Click(sender, e);
        }

        private void retourner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void gueristrue_Click(object sender, EventArgs e)
        {
            guerisfalse.Checked = gueristrue.Checked;
            gueristrue.Checked = !(guerisfalse.Checked);
            annulerchangement.Visible = false;
            if (gueristrue.Checked)
                sauvegarderchangement.Visible = true;
                

            if (!(gueristrue.Checked || guerisfalse.Checked))
                sauvegarderchangement.Visible = false;

            guerison();
        }
        private bool guerison()
        {
            if (gueristrue.Checked && !(guerisfalse.Checked))
            {
                Citoyensuscourant.patient = true;
                Citoyensuscourant.CodeCouleur = "Green";
                sauvegarderchangement.Text = "Rendre Gueris";
                sauvegarderchangement.ForeColor = Color.Green;
                codecouleurchange(Citoyensuscourant);
                return true;
            }
            else 
                Citoyensuscourant.patient = false;
            Citoyensuscourant.CodeCouleur = "Red";
            sauvegarderchangement.Text = "Mettre  a  jour patient";
            sauvegarderchangement.ForeColor = Color.Red;
            codecouleurchange(Citoyensuscourant);
            return false;

        }

        public void codecouleurchange(Citoyen C)
        {
            if (C.CodeCouleur == "Green")
            {
                //design rectangle and fill color 
                Graphics g = cc.CreateGraphics();
                Rectangle r = new Rectangle();
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Green);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 624, 500);
                g.FillRectangle(sb, 1, 1, 624, 500);
            }
            if (C.CodeCouleur == "Orange")
            {
                //design rectangle and fill color 
                Graphics g = cc.CreateGraphics();
                Rectangle r = new Rectangle();
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Orange);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 624, 500);
                g.FillRectangle(sb, 1, 1, 624, 500);
            }
            if ( C.CodeCouleur == "Red")
            {
                //design rectangle and fill color 
                Graphics g = cc.CreateGraphics();
                Rectangle r = new Rectangle();
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Red);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 624, 500);
                g.FillRectangle(sb, 1, 1, 624, 500);
            }
            //   }
        }

        private void guerisfalse_Click(object sender, EventArgs e)
        {
            gueristrue.Checked = guerisfalse.Checked;
            guerisfalse.Checked = !(gueristrue.Checked);
            annulerchangement.Visible = false;
            if (guerisfalse.Checked)
                sauvegarderchangement.Visible = true;
            if (!(gueristrue.Checked || guerisfalse.Checked))
                sauvegarderchangement.Visible = false;

            guerison();
        }

        private void sauvegarderchangement_Click(object sender, EventArgs e)
        {
            if(deces.Checked)
            {
                Patient ef = new Patient();
                ef.Cin = Citoyensuscourant.Cin;
                ef.NomEtPrenom = Citoyensuscourant.NomEtPrenom;
                qy.CommandText = persistance.patdeces(ef).CommandText;
                qy.Connection = Connection;
                Connection.Open();

                try
                {
                    qy.ExecuteNonQuery();
                    string message = "le patient est décédé";
                    string title = "";
                    MessageBox.Show(message, title);
                    Connection.Close();
                    retourner_Click(sender, e);
                }



                catch (Exception aef)
                {
                    string message = "Probleme";
                    string title = "Erreur";
                    MessageBox.Show(message, title);
                    
                    Connection.Close();
                    retourner_Click(sender, e);
                }
                
            }
            else {
            if (gueristrue.Checked)
            {
                Patient ef = new Patient();
                ef.Cin = Citoyensuscourant.Cin;
                ef.gueris = gueristrue.Checked;

                qy.CommandText = persistance.patienttocitoyen(ef).CommandText;
                qy.Connection = Connection;
                Connection.Open();

                try
                {
                    qy.ExecuteNonQuery();
                    string message = "le patient est gueris";
                    string title = "";
                    MessageBox.Show(message, title);
                    persistance.updatehistorique(Citoyensuscourant, message);
                    Connection.Close();
                    retourner_Click(sender, e);
                }



                catch (Exception aef)
                {
                    string message = "Probleme";
                    string title = "Erreur";
                    MessageBox.Show(message, title);
                    Connection.Close();
                        retourner_Click(sender, e);
                    }
                
            }

            else 
            {
                Patient ef = new Patient();
                ef.Cin = Citoyensuscourant.Cin;
                ef.Medicationhopital = symptomegravetrue.Checked;
                ef.Reanimation = etataggravetrue.Checked;
                
                qy.CommandText = persistance.updatepatient(ef).CommandText;
                qy.Connection = Connection;
                Connection.Open();

                try
                {
                    qy.ExecuteNonQuery();

                    if(ef.Medicationhopital)
                    { persistance.updatehistorique(Citoyensuscourant, "Hospitalisé");  }
                    else
                    { persistance.updatehistorique(Citoyensuscourant, "Confiné à la maison"); }
                    if(ef.Reanimation )
                    { persistance.updatehistorique(Citoyensuscourant, "Reanimation necessaire"); }
                    else
                    { persistance.updatehistorique(Citoyensuscourant, "Confiné à l'hopital"); }

                    string message = "etat du Patient est mise a jour";
                    string title = "";
                    
                    MessageBox.Show(message, title);

                    Connection.Close();
                        retourner_Click(sender, e);
                    }



                catch (Exception esf)
                {
                    string message = "Probleme";
                    string title = "Erreur";
                    MessageBox.Show(message, title);
                    Connection.Close();
                        retourner_Click(sender, e);
                    }
                
            }

            }
        }
   
        private void symptomegravetrue_Click(object sender, EventArgs e)
        {

            symptomegravefalse.Checked = symptomegravetrue.Checked;
            symptomegravetrue.Checked = !(symptomegravefalse.Checked);
            annulerchangement.Visible = false;
            if (symptomegravetrue.Checked)
            {
            sauvegarderchangement.Visible = true;
            label21.Enabled = true;
            label13.Enabled = true;
            label23.Enabled = true;
            etataggravetrue.Enabled = true;
            etataggravefalse.Enabled = true;
            gueristrue.Enabled = true;
            guerisfalse.Enabled = true;
            }
            else
            {
                label21.Enabled = true;
                label13.Enabled = true;
                label23.Enabled = true;
                etataggravetrue.Enabled = false;
                etataggravefalse.Enabled = false;
                gueristrue.Enabled = true;
                guerisfalse.Enabled = true;
            }
            if (!(symptomegravetrue.Checked || symptomegravefalse.Checked))
                sauvegarderchangement.Visible = false;

           
          
        }

        private void symptomegravefalse_Click(object sender, EventArgs e)
        {
            symptomegravetrue.Checked = symptomegravefalse.Checked;
            symptomegravefalse.Checked = !(symptomegravetrue.Checked);
            annulerchangement.Visible = false;
            if (symptomegravefalse.Checked)
            {  
                sauvegarderchangement.Visible = true;
            label21.Enabled = true;
            label13.Enabled = true;
            etataggravetrue.Enabled = false;
            etataggravefalse.Enabled = false;
            gueristrue.Enabled = true;
            guerisfalse.Enabled = true;
            }
            if (!(symptomegravetrue.Checked || symptomegravefalse.Checked))
                sauvegarderchangement.Visible = false;

                
           
        }

        private void symptomegravetrue_Click_1(object sender, EventArgs e)
        {
            symptomegravefalse.Checked = symptomegravetrue.Checked;
            symptomegravetrue.Checked = !(symptomegravefalse.Checked);
            annulerchangement.Visible = false;
            if (symptomegravetrue.Checked)
            {
                sauvegarderchangement.Visible = true;
                label21.Enabled = true;
                label13.Enabled = true;
                label23.Enabled = true;
                etataggravetrue.Enabled = true;
                etataggravefalse.Enabled = true;
                gueristrue.Enabled = true;
                guerisfalse.Enabled = true;
            }
            else
            {
                label21.Enabled = true;
                label13.Enabled = true;
                label23.Enabled = true;
                etataggravetrue.Enabled = false;
                etataggravefalse.Enabled = false;
                gueristrue.Enabled = true;
                guerisfalse.Enabled = true;
            }
            if (!(symptomegravetrue.Checked || symptomegravefalse.Checked))
                sauvegarderchangement.Visible = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if(deces.Checked)
            {
                sauvegarderchangement.Visible = true;
                sauvegarderchangement.Text = "Rendre Décédé";
                sauvegarderchangement.ForeColor = Color.Red;
            }
            else
                sauvegarderchangement.Visible = false;
        }
    }
}
