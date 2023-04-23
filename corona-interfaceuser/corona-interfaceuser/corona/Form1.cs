using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace corona 
{
    public partial class Form1 : Form 
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand qyback = new MySqlCommand();
        static MySqlCommand stats = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        Persistance pr = new Persistance();
        public Citoyen Citcheck;
        public Citoyen citvac;
        public bool showingdeces;
        string now = DateTime.Now.ToString("yyyy-MM-dd");
        public Form1()
        {
           
            
            InitializeComponent();
            try
            {

                stats.CommandText = "SELECT COUNT(*) FROM Patient WHERE Patient.date='"+now+"'";
                stats.Connection = Connection;
                Connection.Open();
                Int32 count = Convert.ToInt32(stats.ExecuteScalar());
                ntcnow.Text = count.ToString();
                Connection.Close();
            }
            catch (Exception e)
            {
                ntcnow.Text = "0";
                Connection.Close();
            }
            try
            {
                stats.CommandText = "SELECT DISTINCT COUNT(*) FROM historique WHERE event='le patient est gueris' and date='" + now + "' ";
                stats.Connection = Connection;
                Connection.Open();
                Int32 count = Convert.ToInt32(stats.ExecuteScalar());
                ntgnow.Text = count.ToString();
                Connection.Close();
            }
            catch (Exception e)
            {
                ntgnow.Text = "0";
                Connection.Close();
            }
            try
            {
                stats.CommandText = "SELECT COUNT(*) FROM deces WHERE datedeces='" + now + "'";
                stats.Connection = Connection;
                Connection.Open();
                Int32 count = Convert.ToInt32(stats.ExecuteScalar());
                ntdnow.Text = count.ToString();
                Connection.Close();
            }
            catch (Exception e)
            {
                ntdnow.Text = "0";
                Connection.Close();
            }
            try
            {
                stats.CommandText = "SELECT COUNT(*) FROM Patient";
                stats.Connection = Connection;
                Connection.Open();
                Int32 count = Convert.ToInt32(stats.ExecuteScalar());
                ntcall.Text = count.ToString();
                Connection.Close();
            }
            catch
            {
                ntcall.Text = "0";
                Connection.Close();
            }
            try
            {
                stats.CommandText = "SELECT DISTINCT COUNT(*) FROM historique WHERE event='le patient est gueris' ";
                stats.Connection = Connection;
                Connection.Open();
                Int32 count = Convert.ToInt32(stats.ExecuteScalar());
                ntgall.Text = count.ToString();
                Connection.Close();
            }
            catch
            {
                ntgall.Text = "0";
                Connection.Close();
            }
            try
            {
                stats.CommandText = "SELECT COUNT(*) FROM deces";
                stats.Connection = Connection;
                Connection.Open();
                Int32 count = Convert.ToInt32(stats.ExecuteScalar());
                ntdall.Text = count.ToString();
                Connection.Close();
            }
            catch
            {
                ntdall.Text = "0";
                Connection.Close();
            }
            Int32  ntcallcount = Convert.ToInt32(ntcall.Text);
            Int32 ntdallcount = Convert.ToInt32(ntdall.Text);
            Int32 ntcnowcount = Convert.ToInt32(ntcnow.Text);
            Int32 ntdnowcount = Convert.ToInt32(ntdnow.Text);

            ntcallcount += ntdallcount;
            ntcnowcount += ntdnowcount;

            ntcall.Text = Convert.ToString(ntcallcount);
            ntcnow.Text = Convert.ToString(ntcnowcount);

        }

        public void showdb()
        {
            Persistance pr = new Persistance();
            qy.CommandText = "SELECT * from Citoyen";
            pr.testquery(qy);
            Connection.Open();
            try { 
                DataTable data = new DataTable();
                MySqlAdapter.Fill(data);
                dbresults.DataSource = data;
               
                Connection.Close();
            }
            catch (Exception e)
            {
                string message = "Probleme de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }
        }
        public void showdb_suspect()
        {
            Persistance pr = new Persistance();
            qy.CommandText = "SELECT * from Citoyen WHERE  Citoyen.CodeCouleur = 'Orange' ";
            pr.testquery(qy);
            try {
                DataTable data = new DataTable();
                MySqlAdapter.Fill(data);
                dbresults.DataSource = data;
                Connection.Close();
            }
            
            catch (Exception e)
            {
                string message = "Probleme de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }

        }

        public void showdb_patient()
        {
            Persistance pr = new Persistance();
            qy.CommandText = "SELECT * from Citoyen,Patient WHERE  Citoyen.Cin = Patient.Cin ";
            pr.testquery(qy);
            try
            {
                DataTable data = new DataTable();
                MySqlAdapter.Fill(data);
                dbresults.DataSource = data;
                Connection.Close();
            }

            catch (Exception e)
            {
                string message = "Probleme de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }

        }

        public void showdb_deces()
        {

            Persistance pr = new Persistance();
            qy.CommandText = pr.showdeces().CommandText;
            pr.testquery(qy);
            try
            {
                
                DataTable data = new DataTable();
                MySqlAdapter.Fill(data);
                dbresults.DataSource = data;
                dbresults.ReadOnly = true;
                Connection.Close();
            }

            catch (Exception e)
            {
                string message = "Probleme de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showingdeces = false;

            showdb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showingdeces = false;

            showdb_suspect();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fr1 = new Form1();
            Form Form2 = new Form2(fr1);
            Form2.Show();

        }

        private void checkstate_Click(object sender, EventArgs e)
        {
            showingdeces = false;

            this.Hide();
            Form checkstate = new Form3(Citcheck);
            checkstate.Show();
        }

        private void searchcin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchcin.Text))
            {
                (dbresults.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dbresults.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cin='{0}'", searchcin.Text);
            }
        }

        private void dbresults_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //change button  state to enabled
            misajoursuspect.Enabled = false;
            rendresuspect.Enabled = false;
            mettreajourpatient.Enabled = false;
            checkstate.Enabled = true;
            Historique.Enabled = true;
            rendrevacc.Enabled = false;

            if (showingdeces)
            {
                rendrevacc.Enabled = false;
                checkstate.Enabled = false;
                rendresuspect.Enabled = false;
                checkstate.Enabled = false;
                Historique.Enabled = false;
                //design rectangle and fill color 
                Graphics g = panel1.CreateGraphics();
                Rectangle r = new Rectangle();
                label2.Text = "Mort";
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Black);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 170, 157);
                g.FillRectangle(sb, 1, 1, 170, 157);
            }

            else
            {
           try
            {
                String Cin = dbresults.Rows[e.RowIndex].Cells[0].Value.ToString();
                String NomEtPrenom = dbresults.Rows[e.RowIndex].Cells[1].Value.ToString();
                String DateDeNaissance = dbresults.Rows[e.RowIndex].Cells[2].Value.ToString();
                int NumeroDeTelephone = Convert.ToInt32(dbresults.Rows[e.RowIndex].Cells[3].Value.ToString());
                String Adresse = dbresults.Rows[e.RowIndex].Cells[5].Value.ToString();
                String CodeCouleur = dbresults.Rows[e.RowIndex].Cells[4].Value.ToString();
                bool Vaccin = Convert.ToBoolean(dbresults.Rows[e.RowIndex].Cells[6].Value.ToString());
                bool Frequente = Convert.ToBoolean(dbresults.Rows[e.RowIndex].Cells[7].Value.ToString());
                bool EnContact = Convert.ToBoolean(dbresults.Rows[e.RowIndex].Cells[8].Value.ToString());
                bool patient = Convert.ToBoolean(dbresults.Rows[e.RowIndex].Cells[9].Value.ToString());
                bool testcorona = Convert.ToBoolean(dbresults.Rows[e.RowIndex].Cells[10].Value.ToString());
                bool symptomatic = Convert.ToBoolean(dbresults.Rows[e.RowIndex].Cells[11].Value.ToString());



                    if (!(Vaccin))
                {
                    citvac = new Citoyen(Cin, NomEtPrenom, DateDeNaissance, NumeroDeTelephone, CodeCouleur, Adresse, Vaccin, Frequente, EnContact, patient, testcorona, symptomatic);
                    rendrevacc.Enabled = true;

                    }
                if (CodeCouleur == "Green")
                {
                    checkstate.Enabled = true;
                    rendresuspect.Enabled = true;
                    Citcheck = new Citoyen(Cin, NomEtPrenom, DateDeNaissance, NumeroDeTelephone, CodeCouleur, Adresse, Vaccin, Frequente, EnContact, patient, testcorona, symptomatic);
                        supprimecitoyen.Enabled = true;
                    }
                else if (CodeCouleur == "Orange")
                {
                        misajoursuspect.Enabled = true;

                }
                else if(CodeCouleur == "Red")
                {
                    mettreajourpatient.Enabled = true;
                }
                Citcheck = new Citoyen(Cin, NomEtPrenom, DateDeNaissance, NumeroDeTelephone, CodeCouleur, Adresse, Vaccin, Frequente, EnContact, patient, testcorona, symptomatic);


                //Frequente = Convert.ToInt32(dbresults.Rows[e.RowIndex].Cells[7].Value.ToString());
                if (dbresults.Rows[e.RowIndex].Cells[4].Value.ToString() == "Green")
                {
                    //design rectangle and fill color 
                    Graphics g = panel1.CreateGraphics();
                    Rectangle r = new Rectangle();
                    label2.Text = "Non Suspect";
                    Pen p = new Pen(Color.Black);
                    SolidBrush sb = new SolidBrush(Color.Green);
                    PaintEventArgs ed = new PaintEventArgs(g, r);
                    g.DrawRectangle(p, 1, 1, 170, 157);
                    g.FillRectangle(sb, 1, 1, 170, 157);
                }
                if (dbresults.Rows[e.RowIndex].Cells[4].Value.ToString() == "Orange")
                {
                    //design rectangle and fill color 
                    Graphics g = panel1.CreateGraphics();
                    Rectangle r = new Rectangle();
                    label2.Text = "Suspect";
                    Pen p = new Pen(Color.Black);
                    SolidBrush sb = new SolidBrush(Color.Orange);
                    PaintEventArgs ed = new PaintEventArgs(g, r);
                    g.DrawRectangle(p, 1, 1, 170, 157);
                    g.FillRectangle(sb, 1, 1, 170, 157);
                }
                if ((dbresults.Rows[e.RowIndex].Cells[4].Value.ToString() == "Red"))
                {
                    //design rectangle and fill color 
                    Graphics g = panel1.CreateGraphics();
                    Rectangle r = new Rectangle();
                    label2.Text = "Patient";
                    Pen p = new Pen(Color.Black);
                    SolidBrush sb = new SolidBrush(Color.Red);
                    PaintEventArgs ed = new PaintEventArgs(g, r);
                    g.DrawRectangle(p, 1, 1, 170, 157);
                    g.FillRectangle(sb, 1, 1, 170, 157);
                }

            }
            catch (Exception ed)
            {
                    checkstate.Enabled = false;
                    Historique.Enabled = false;
                    supprimecitoyen.Enabled = false;
                    string message = "Selectionnez un citoyen";
                string title = "Erreur";
                MessageBox.Show(message, title);
            }
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void rendresuspect_Click(object sender, EventArgs e)
        {
            showingdeces = false;
            this.Hide();
            Form rendresuspect = new Form4(Citcheck);
            rendresuspect.Show();
        }

        private void Historique_Click(object sender, EventArgs e)
        {
            showingdeces = false;
            this.Hide();
            Form historiquenow = new Form5(Citcheck);
            historiquenow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showingdeces = false;
            this.Hide();
            Form updatesuspect = new Form6(Citcheck);
            updatesuspect.Show();
        }

        private void mettreajourpatient_Click(object sender, EventArgs e)
        {
            showingdeces = false;
            this.Hide();
            Form updatepatient = new Form7(Citcheck);
            updatepatient.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showingdeces = false;
            showdb_patient();
        }

        private void rendrevacc_Click(object sender, EventArgs e)
        {
            showingdeces = false;
            qy = pr.vaccinatecitoyen(citvac);
            qy.Connection = Connection;
            Connection.Open();



            try { 
                qy.ExecuteNonQuery();
                Connection.Close();
                string message = "Citoyen vacciné";
                string title = "Succès";
                pr.updatehistorique(citvac, "Citoyen vacciné");
                MessageBox.Show(message, title);
            }
            catch (Exception edd) 
            { Connection.Close();
                string message = "Citoyen non vacciné";
                string title = "Erreur";
                MessageBox.Show(message, title);
                
            
            }
            
            
        }

        private void affichevaccin_Click(object sender, EventArgs e)
        {
            showingdeces = false;
            qy.CommandText = "SELECT * from Citoyen WHERE  Citoyen.Vaccin = '1'";
            qy.Connection = Connection;
            Connection.Open();

            try
            {
                qy.ExecuteNonQuery();
                DataTable data = new DataTable();
                MySqlAdapter.Fill(data);
                dbresults.DataSource = data;
                Connection.Close();
            }

            catch (Exception ec)
            {
                string message = "Probleme de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }

        }

        private void listedc_Click(object sender, EventArgs e)
        {
            showingdeces = true;
            showdb_deces();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ntcnow_Click(object sender, EventArgs e)
        {

        }

        private void supprimecitoyen_Click(object sender, EventArgs e)
        {
            qy.CommandText = "DELETE FROM Users WHERE Cin='" + Citcheck.Cin + "';DELETE FROM Citoyen WHERE Cin='" + Citcheck.Cin+ "';DELETE FROM historique WHERE Cin='" + Citcheck.Cin + "'";
            qy.Connection = Connection;
            Connection.Open();

            try
            {
                qy.ExecuteNonQuery();
                string message = "Citoyen supprimé";
                string title = "Succes";
                MessageBox.Show(message, title);
                Connection.Close();
            }

            catch (Exception ec)
            {
                string message = "Probleme de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }
            showdb();
        }
    }
}
