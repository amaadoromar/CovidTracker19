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
    public partial class Form2 : Form
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand stats = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        Persistance pr = new Persistance();
        String passworduser;
        Form trigger;

        public Form2(Form name)
        {
            trigger = name;
            InitializeComponent();

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
                trigger.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Numerodetelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool validateform()
        {
            //OMAR AMAADOR 
            bool valid = false;
            string CINempty;
            string NOMempty;
            string Adresseempty;
            string numempty;


            if (String.IsNullOrEmpty(Cin.Text))
            {
                CINempty = "Entrer CIN ! \n";
                valid = false;
            }
            else
            {
                CINempty = "";
                valid = true;
            }
            if (String.IsNullOrEmpty(NometPrenom.Text))
            {
                valid = false;
                NOMempty = "Entrer le nom complet ! \n";
                
            }
            else
            {
                NOMempty = "";
                valid = true;
            }
            if (String.IsNullOrEmpty(Adresse.Text))
            {
                Adresseempty = "Entrer l'adresse ! \n";
                valid = false;
            }
            else
            {
                Adresseempty = "";
                valid = true;
            }
            if ((String.IsNullOrEmpty(Numerodetelephone.Text) || !(Numerodetelephone.Text.Length == 10))  )
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
                MessageBox.Show(String.Format("{0}{1}{2}{3}", CINempty, NOMempty, Adresseempty,numempty), "Formulaire invalide");

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

        private bool validaterowdeces(string cincheck)
        {
            showdbdeces();
            int i = 0;
            bool exist = false;
            for (i = 0; i < dbresults.Rows.Count - 1;)
            {
                if (cincheck == dbresults[0, i].Value.ToString())
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


        public void showdbdeces()
            {
                Persistance pr = new Persistance();
                qy.CommandText = "SELECT * from deces";
                pr.testquery(qy);
                Connection.Open();
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


        private void add_Click(object sender, EventArgs e)
        {
            string dateStr = Datedenaissance.Value.ToString("yyyy-MM-dd");
            
            if (validateform())
            {
                if (!(validaterow(Cin.Text) && validaterowdeces(Cin.Text)))
                {
                    Citoyen C = new Citoyen(Cin.Text, NometPrenom.Text, dateStr, Convert.ToInt32(Numerodetelephone.Text), Adresse.Text);
                    passworduser = password.Text; 
                    if (pr.Addcitoyen(C,passworduser))
                    {
                        string message = "Citoyen est ajouté avec succès";
                        string title = "Succès";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        string message = "Citoyen n'est pas ajouté";
                        string title = "Erreur";
                        MessageBox.Show(message, title);
                    }
                }
                else
                {
                    MessageBox.Show("CIN déjà utilisé");
                }
                Return_Click(sender, e);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Return_Click(sender, e);
        }
    }
}
