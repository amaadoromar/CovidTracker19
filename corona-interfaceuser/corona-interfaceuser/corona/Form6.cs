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
    public partial class Form6 : Form
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand qyback = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        public Citoyen Citoyensuscourant;
        public Persistance persistance = new Persistance();
        public String oldcolor;

        public Form6(Citoyen C)
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
            testcovid.Enabled = true;

            if (testcovid.Checked)
            {
                resultattestcovidtrue.Enabled = false;
                resultattestcovidfalse.Enabled = false;
                resultattestcovidfalse.Checked = true;
            }


        }

        private void testcovid_Click(object sender, EventArgs e)
        {
            if (testcovid.Checked)
            {
                resultattestcovidtrue.Enabled = true;
                resultattestcovidfalse.Enabled = true;
                if (resultattestcovidtrue.Checked || resultattestcovidfalse.Checked)
                {
                    annulerchangement.Visible = false;
                    sauvegarderchangement.Visible = true;
                }
            }
            else
            {
                Citoyensuscourant.CodeCouleur = "Orange";
                resultattestcovidtrue.Enabled = false;
                resultattestcovidfalse.Enabled = false;
                resultattestcovidtrue.Checked = false;
                resultattestcovidfalse.Checked = false;
                sauvegarderchangement.Visible = false;
                annulerchangement.Visible = false;
                codecouleurchange(Citoyensuscourant);
            }
        }

        private bool resultatdepistage()
        {
            if (resultattestcovidtrue.Checked && !(resultattestcovidfalse.Checked))
            {
                Citoyensuscourant.patient = true;
                Citoyensuscourant.CodeCouleur = "Red";
                sauvegarderchangement.Text = "Rendre Patient";
                sauvegarderchangement.ForeColor = Color.Red;
                codecouleurchange(Citoyensuscourant);
                return true;
            }
            else
                Citoyensuscourant.patient = false;
            Citoyensuscourant.CodeCouleur = "Green";
            sauvegarderchangement.Text = "Rendre Non Suspect";
            sauvegarderchangement.ForeColor = Color.Green;
            codecouleurchange(Citoyensuscourant);
            return false;

        }

        public void codecouleurchange(Citoyen C)
        {
            /*if (C.IsSuspect())
            {
                if(resultattestcovidtrue.Checked)
                {
                    C.CodeCouleur = "Red";
                        }
                else
                {
                    C.CodeCouleur = "Green";
                }
            }*/
            //else { 
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
            //   }
        }

        private void resultattestcovidtrue_Click(object sender, EventArgs e)
        {
            resultattestcovidfalse.Checked = resultattestcovidtrue.Checked;
            resultattestcovidtrue.Checked = !(resultattestcovidfalse.Checked);
            annulerchangement.Visible = false;
            if (resultattestcovidtrue.Checked)
                sauvegarderchangement.Visible = true;
            if (!(resultattestcovidtrue.Checked || resultattestcovidfalse.Checked))
                sauvegarderchangement.Visible = false;
            resultatdepistage();
        }

        private void resultattestcovidfalse_Click(object sender, EventArgs e)
        {
            resultattestcovidtrue.Checked = resultattestcovidfalse.Checked;
            resultattestcovidfalse.Checked = !(resultattestcovidtrue.Checked);
            annulerchangement.Visible = false;
            if (resultattestcovidfalse.Checked)
                sauvegarderchangement.Visible = true;
            if (!(resultattestcovidtrue.Checked || resultattestcovidfalse.Checked))
                sauvegarderchangement.Visible = false;
            resultatdepistage();
        }

        private void sauvegarderchangement_Click(object sender, EventArgs e)
        {
            if (Citoyensuscourant.patient)
            {
                if (!(Citoyensuscourant.CodeCouleur == oldcolor))
                {
                    qy.CommandText = persistance.suspecttopatient(Citoyensuscourant).CommandText;
                    qy.Connection = Connection;
                    Connection.Open();

                    try
                    {
                        qy.ExecuteNonQuery();
                        string message = "Ce Citoyen a testé positif";
                        string title = "";
                        persistance.updatehistorique(Citoyensuscourant, message);
                        MessageBox.Show(message, title);
                        Connection.Close();
                    }



                    catch (Exception ef)
                    {
                        string message = "Probleme";
                        string title = "Erreur";
                        MessageBox.Show(message, title);
                        Connection.Close();
                    }
                }

            }
            else
            {
                if (!(Citoyensuscourant.CodeCouleur == oldcolor))
                {
                    qy.CommandText = persistance.suspecttocitoyen(Citoyensuscourant).CommandText;
                    qy.Connection = Connection;
                    Connection.Open();

                    try
                    {
                        qy.ExecuteNonQuery();
                        string message = "Ce Citoyen a testé négatif";
                        string title = "";
                        persistance.updatehistorique(Citoyensuscourant, message);
                        MessageBox.Show(message, title);
                        Connection.Close();

                    }
                    catch (Exception ef)
                    {
                        string message = "Probleme";
                        string title = "Erreur";
                        MessageBox.Show(message, title);
                        Connection.Close();
                    }
                }

            }
            retourner_Click(sender, e);
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            retourner_Click(sender, e);
        }

        private void retourner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }
    }
}


    
