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
    public partial class Form4 : Form
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand qyback = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        public Citoyen Citoyensuscourant;
        public Persistance persistance = new Persistance();
        string CodeCouleurInitial;
        public Form4(Citoyen C)
        {
            InitializeComponent();
            Citoyensuscourant = C;
            bilan(Citoyensuscourant);

            
        }

        public void bilan(Citoyen C)
        {
            if(C.patient)
            {
                cinetat.Text = C.Cin;
                npetat.Text = C.NomEtPrenom;
                Adresseetat.Text = C.Adresse;
                ntetat.Text = String.Format("{0}", C.NumeroDeTelephone);
                dtpetat.Value = Convert.ToDateTime(C.DateDeNaissance);
                dtpetat.Enabled = false;
                testcovid.Enabled = false;
                resultattestcovidtrue.Enabled = false;
                resultattestcovidfalse.Enabled = false;
                label17.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label22.Visible = true;
                label25.Visible = true;
                label21.Visible = true;
                label13.Visible = true;
                label24.Visible = true;
                label23.Visible = true;
                label16.Visible = false;
                testcovid.Visible = false;
                gueristrue.Visible = true;
                guerisfalse.Visible = true;
                etataggravetrue.Visible = true;
                etataggravefalse.Visible = true;
                resultattestcovidtrue.Visible = true;
                resultattestcovidfalse.Visible = true;
            }
            /*if (C.IsSuspect())
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
                    resultattestcovid.Enabled = true;
                } 
            }*/
            else { 
            cinetat.Text = C.Cin;
            npetat.Text = C.NomEtPrenom;
            Adresseetat.Text = C.Adresse;
            ntetat.Text = String.Format("{0}", C.NumeroDeTelephone);
            dtpetat.Value = Convert.ToDateTime(C.DateDeNaissance);
            asymptomaticfalse.Checked = !(C.symptomatic);
            asymptomatictrue.Enabled = C.symptomatic;
            frequentevrai.Checked = C.Frequente;
            fauxfrequente.Checked = !(C.Frequente);
            encontactvrai.Checked = C.Encontact;
            encontactfaux.Checked = !(C.Encontact);
            testcovid.Checked = C.testcorona;
            resultattestcovid.Checked = C.patient;
            if (testcovid.Checked)
            {
                asymptomaticfalse.Enabled = false;
                asymptomatictrue.Enabled = false;
                frequentevrai.Enabled = false;
                fauxfrequente.Enabled = false;
                encontactvrai.Enabled = false;
                encontactfaux.Enabled = false;
            }
            else
            {
                asymptomaticfalse.Enabled = true;
                asymptomatictrue.Enabled = true;
                frequentevrai.Enabled = true;
                fauxfrequente.Enabled = true;
                encontactvrai.Enabled = true;
                encontactfaux.Enabled = true;
            }
            }

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

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private bool testcoronarequis()
        {
            bool s = false;
            if (asymptomatictrue.Checked || frequentevrai.Checked || encontactvrai.Checked)
            { s = true; }

            return s;


        }
        private bool enableupdate()
        {
            bool s = false;
            if (!(asymptomatictrue.Checked || frequentevrai.Checked || encontactvrai.Checked))
            { s = true; }

            return s;


        }
        private void asymptomatictrue_Click(object sender, EventArgs e)
        {
            asymptomaticfalse.Checked = asymptomatictrue.Checked;
            asymptomatictrue.Checked = !(asymptomaticfalse.Checked);
            testcovid.Enabled = testcoronarequis();
            annulerchangement.Visible = true;
            if (asymptomatictrue.Checked)
                sauvegarderchangement.Visible = true;
            if (enableupdate())
                sauvegarderchangement.Visible = false;
        }

        private void asymptomaticfalse_Click(object sender, EventArgs e)
        {
            asymptomatictrue.Checked = asymptomaticfalse.Checked;
            asymptomaticfalse.Checked = !(asymptomatictrue.Checked);
            testcovid.Enabled = testcoronarequis();
            annulerchangement.Visible = true;
            if (asymptomatictrue.Checked)
                sauvegarderchangement.Visible = true;
            if (enableupdate())
                sauvegarderchangement.Visible = false;
        }

        private void encontactvrai_Click(object sender, EventArgs e)
        {
            encontactfaux.Checked = encontactvrai.Checked;
            encontactvrai.Checked = !(encontactfaux.Checked);
            testcovid.Enabled = testcoronarequis();
            annulerchangement.Visible = true;
            if (encontactvrai.Checked)
                sauvegarderchangement.Visible = true;
            if (enableupdate())
                sauvegarderchangement.Visible = false;
        }

        private void encontactfaux_Click(object sender, EventArgs e)
        {
            encontactvrai.Checked = encontactfaux.Checked;
            encontactfaux.Checked = !(encontactvrai.Checked);
            testcovid.Enabled = testcoronarequis();
            annulerchangement.Visible = true;
            if (encontactvrai.Checked)
                sauvegarderchangement.Visible = true;
            if (enableupdate())
                sauvegarderchangement.Visible = false;
        }

        private void frequentevrai_Click(object sender, EventArgs e)
        {
            fauxfrequente.Checked = frequentevrai.Checked;
            frequentevrai.Checked = !(fauxfrequente.Checked);
            testcovid.Enabled = testcoronarequis();
            annulerchangement.Visible = true;
            if (frequentevrai.Checked)
                sauvegarderchangement.Visible = true;
            if (enableupdate())
                sauvegarderchangement.Visible = false;
        }

        private void fauxfrequente_Click(object sender, EventArgs e)
        {
            frequentevrai.Checked = fauxfrequente.Checked;
            fauxfrequente.Checked = !(frequentevrai.Checked);
            testcovid.Enabled = testcoronarequis();
            annulerchangement.Visible = true;
            if (frequentevrai.Checked)
                sauvegarderchangement.Visible = true;
            if (enableupdate())
                sauvegarderchangement.Visible = false;
        }

        private void retourner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void Form4_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            retourner_Click(sender, e);
        }

        private void annulerchangement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form4 = new Form4(Citoyensuscourant);
            Form4.Show();
        }

        private void testcovid_Click(object sender, EventArgs e)
        {
            if(Citoyensuscourant.IsSuspect())
            {
                
                if (testcovid.Checked)
                {
                    resultattestcovidtrue.Enabled = true;
                    resultattestcovidfalse.Enabled = true;
                    if(resultattestcovidtrue.Checked || resultattestcovidfalse.Checked)
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
            else {
            if (testcovid.Checked)
            { 
                resultattestcovidtrue.Enabled = true;
                resultattestcovidfalse.Enabled = true;
            }
            else
            { 
                resultattestcovidtrue.Enabled = false;
                resultattestcovidfalse.Enabled = false;
            }
            }
        }

        private void resultattestcovid_Click(object sender, EventArgs e)
        {
            if (testcovid.Checked)
            {
                Citoyensuscourant.patient = true;
                sauvegarderchangement.Text = "Rendre Patient";
                sauvegarderchangement.ForeColor = Color.Red;
            }
            else
            {
                Citoyensuscourant.patient = false;
                sauvegarderchangement.Text = "Rendre Suspect";
                sauvegarderchangement.ForeColor = Color.Black;
            }
        }

        private void cc_Paint(object sender, PaintEventArgs e)
        {
            codecouleurchange(Citoyensuscourant);
        }

        private void sauvegarderchangement_Click(object sender, EventArgs e)
        {
            if (Citoyensuscourant.IsSuspect())
            {
                if (Citoyensuscourant.patient)
                {
                    qy.CommandText = persistance.checkcodecouleurchanges(Citoyensuscourant.Cin).CommandText;
                    qy.Connection = Connection;
                    Connection.Open();

                    try
                    {
                        qy.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        MySqlAdapter.Fill(data);
                        testss.DataSource = data;
                        if (!(Citoyensuscourant.CodeCouleur == testss[0, 0].Value.ToString()))
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
                    catch (Exception ef)
                    {
                        string message = "Probleme";
                        string title = "Erreur";
                        MessageBox.Show(message, title);
                        Connection.Close();
                    }
                    retourner_Click(sender, e);
                }
                else if (!(Citoyensuscourant.patient || Citoyensuscourant.IsSuspect()))
                {

                    qy.CommandText = persistance.checkcodecouleurchanges(Citoyensuscourant.Cin).CommandText;
                    qy.Connection = Connection;
                    Connection.Open();
                    try
                    {
                        qy.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        MySqlAdapter.Fill(data);
                        testss.DataSource = data;
                        if (!(Citoyensuscourant.CodeCouleur == testss[0, 0].Value.ToString()))
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
                    catch (Exception ef)
                    {
                        string message = "Probleme";
                        string title = "Erreur";
                        MessageBox.Show(message, title);
                        Connection.Close();
                    }
                    this.Hide();
                    Form Form1 = new Form1();
                    Form1.Show();
                }
                retourner_Click(sender, e);
            }
           else 
            { 
            Citoyensuscourant.symptomatic = asymptomatictrue.Checked;
            Citoyensuscourant.Encontact = encontactvrai.Checked;
            Citoyensuscourant.Frequente = frequentevrai.Checked;
            if(testcoronarequis())
            {
                Citoyensuscourant.CodeCouleur = "Orange";
                    }
            if(testcovid.Checked)
            {
                if(resultattestcovidtrue.Checked)
                    Citoyensuscourant.CodeCouleur = "Red";
            }
            codecouleurchange(Citoyensuscourant);

            if (!(Citoyensuscourant.patient))
            {

                Suspect S = new Suspect(Citoyensuscourant.Cin);

                qy.CommandText = persistance.checkcodecouleurchanges(Citoyensuscourant.Cin).CommandText;
                qy.Connection = Connection;
                Connection.Open();

                try
                {
                    qy.ExecuteNonQuery();
                    DataTable data = new DataTable();
                    MySqlAdapter.Fill(data);
                    testss.DataSource = data;
                    persistance.Citoyentosuspect(Citoyensuscourant);
                    if (!(Citoyensuscourant.CodeCouleur == testss[0, 0].Value.ToString()))
                    {
                        string message = "Ce Citoyen est Suspect , le formulaire sera fermé pour effectuer le changement";
                        string title = "";
                        persistance.updatehistorique(Citoyensuscourant, "Ce Citoyen est Suspect");
                        MessageBox.Show(message, title);
                        Connection.Close();
                    }

                 
                }
                catch (Exception edd)
                {
                    string message = "Echec de connexion";
                    string title = "Erreur";
                    MessageBox.Show(message, title);
                    Connection.Close();
                }


            }
                retourner_Click(sender, e);
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
    }
}
