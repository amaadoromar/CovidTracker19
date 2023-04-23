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
    public partial class Form3 : Form
    {
        public Citoyen Citoyencourant;
        public Persistance pr = new Persistance();
        public Form3(Citoyen C)
        {
            InitializeComponent();
            Citoyencourant = C;
            bilan(Citoyencourant);

        }
        public void bilan(Citoyen C)
        {
            cinetat.Text = C.Cin;
            npetat.Text = C.NomEtPrenom;
            Adresseetat.Text = C.Adresse;
            ntetat.Text = String.Format("{0}", C.NumeroDeTelephone);
            dtpetat.Value = Convert.ToDateTime(C.DateDeNaissance);
            frequentevrai.Checked = C.Frequente;
            fauxfrequente.Checked = !(C.Frequente);
            encontactvrai.Checked = C.Encontact;
            encontactfaux.Checked = !(C.Encontact);
            checksuspect.Checked = C.IsSuspect();
            checkvaccin.Checked = C.Vaccin;
            Patient.Checked = C.patient;
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
            if ((C.Frequente || C.Encontact) || C.CodeCouleur == "Orange")
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
            if ((C.patient || C.CodeCouleur == "Red"))
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
        }

        private bool validateform()
        {
            //OMAR AMAADOR 
            bool valid = false;
            string CINempty;
            string NOMempty;
            string Adresseempty;
            string numempty;


            if (String.IsNullOrEmpty(cinetat.Text))
            {
                CINempty = "Entrer CIN ! \n";
                valid = false;
            }
            else
            {
                CINempty = "";
                valid = true;
            }
            if (String.IsNullOrEmpty(npetat.Text))
            {
                valid = false;
                NOMempty = "Entrer le nom complet ! \n";

            }
            else
            {
                NOMempty = "";
                valid = true;
            }
            if (String.IsNullOrEmpty(Adresseetat.Text))
            {
                Adresseempty = "Entrer l'adresse ! \n";
                valid = false;
            }
            else
            {
                Adresseempty = "";
                valid = true;
            }
            if ((String.IsNullOrEmpty(ntetat.Text) || !(ntetat.Text.Length == 10)))
            {
                numempty = "Entrer un numéro de téléphone valide ! \n";
                valid = false;
            }
            else
            {
                numempty = "";
                valid = true;
            }

            if (valid == false)
            {
                MessageBox.Show(String.Format("{0}{1}{2}{3}", CINempty, NOMempty, Adresseempty, numempty), "Formulaire invalide");

            }

            return valid;
        }

        private bool validaterow(string cincheck)
        {
            Form1 fr = new Form1();
            fr.showdb();
            int i = 0;
            bool exist = false;
            for (i = 0; i < fr.dbresults.Rows.Count - 1;)
            {
                if (cincheck == fr.dbresults[0, i].Value.ToString())
                {
                    exist = true;
                    break;
                }
                else
                {
                    i++;

                }
            }
            return exist;
        }

        private void cc_Paint(object sender, PaintEventArgs e)
        {
            codecouleurchange(Citoyencourant);
        }

        private void retourner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            retourner_Click(sender, e);
        }

        private void changement_Click(object sender, EventArgs e)
        {
            cinetat.Enabled = false;
            npetat.Enabled = true;
            Adresseetat.Enabled = true;
            ntetat.Enabled = true;
            dtpetat.Enabled = true;
           
            effecuterchangement.Enabled = false;
            annulerchangement.Visible = true;
            sauvegarderchangement.Visible = true;
            

        }
        public void mchecksuspect()
        {
            if (encontactvrai.Checked || frequentevrai.Checked)
                checksuspect.Checked = true;
            else
                checksuspect.Checked = false;
        }
        private void encontactfaux_Click(object sender, EventArgs e)
        {
            encontactvrai.Checked = encontactfaux.Checked;
            encontactfaux.Checked = !(encontactvrai.Checked);
            mchecksuspect();
        }

        private void encontactvrai_Click(object sender, EventArgs e)
        {
            encontactfaux.Checked = encontactvrai.Checked;
            encontactvrai.Checked = !(encontactfaux.Checked);
            mchecksuspect();
        }

        private void fauxfrequente_Click(object sender, EventArgs e)
        {
            frequentevrai.Checked = fauxfrequente.Checked;
            fauxfrequente.Checked = !(frequentevrai.Checked);
            mchecksuspect();
        }

        private void frequentevrai_Click(object sender, EventArgs e)
        {
            fauxfrequente.Checked = frequentevrai.Checked;
            frequentevrai.Checked = !(fauxfrequente.Checked);
            mchecksuspect();
        }

        private void annulerchangement_Click(object sender, EventArgs e)
        {
            bilan(Citoyencourant);
            cinetat.Enabled = false;
            npetat.Enabled = false;
            Adresseetat.Enabled = false;
            ntetat.Enabled = false;
            dtpetat.Enabled = false;
            
            effecuterchangement.Enabled = true;
            effecuterchangement.Visible = true;
            annulerchangement.Visible = false;
            sauvegarderchangement.Visible = false;
        }

        private void sauvegarderchangement_Click(object sender, EventArgs e)
        {
            if(validateform())
            {
                        if (pr.Citoyentosuspect(Citoyencourant))
                        {
                            string message = "Citoyen a  été mis a jour avec succès";
                            string title = "Succès";
                        pr.updatehistorique(Citoyencourant, message);
                        MessageBox.Show(message, title);
                        }
                        else
                        {
                            string message = "Citoyen n'est pas modifié";
                            string title = "Erreur";
                        pr.updatehistorique(Citoyencourant, message);
                        MessageBox.Show(message, title);
                        }
                retourner_Click(sender, e);
            }
            }
        

        private void cinetat_TextChanged(object sender, EventArgs e)
        {
            Citoyencourant.Cin = cinetat.Text;
        }

        private void npetat_TextChanged(object sender, EventArgs e)
        {
            Citoyencourant.NomEtPrenom = npetat.Text;
        }

        private void Adresseetat_TextChanged(object sender, EventArgs e)
        {
            Citoyencourant.Adresse = Adresseetat.Text;
        }

        private void ntetat_TextChanged(object sender, EventArgs e)
        {
            try { Citoyencourant.NumeroDeTelephone = Convert.ToInt32(ntetat.Text); }
            catch (Exception efds) 
            {
                string message = "Entrer un numero valide";
                string title = "";
                MessageBox.Show(message, title);
            }
            
        }

        private void dtpetat_ValueChanged(object sender, EventArgs e)
        {
            Citoyencourant.DateDeNaissance = dtpetat.Value.ToString("yyyy-MM-dd");
        }

        private void checkvaccin_CheckedChanged(object sender, EventArgs e)
        {

            Citoyencourant.Vaccin = checkvaccin.Checked;
        }

        private void Patient_CheckedChanged(object sender, EventArgs e)
        {
            Citoyencourant.patient = Patient.Checked;
            if (Patient.Checked)
            {
                frequentevrai.Enabled = false;
                frequentevrai.Checked = false;
                fauxfrequente.Enabled = false;
                fauxfrequente.Checked = true;
                encontactvrai.Enabled = false;
                encontactvrai.Checked = false;
                encontactfaux.Enabled = false;
                encontactfaux.Checked = true;
                checksuspect.Enabled = false;
                checksuspect.Checked = false;
            }
            else
            {
                frequentevrai.Enabled = true;
                fauxfrequente.Enabled = true;
                encontactvrai.Enabled = true;
                encontactfaux.Enabled = true;
                checksuspect.Enabled = true;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ntetat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
