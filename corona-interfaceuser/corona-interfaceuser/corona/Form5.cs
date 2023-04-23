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
    public partial class Form5 : Form
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand qyback = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        public Citoyen C;
        public Form5(Citoyen chistorique)
        {
            
            InitializeComponent();
            C = chistorique;
            showhis(chistorique);

        }

        public void showhis(Citoyen C)
        {
            Persistance pr = new Persistance();
            String now = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            qy.CommandText = pr.showhistorique(C).CommandText;
            qy.Connection = Connection;
            Connection.Open();



            try { 
                qy.ExecuteNonQuery();
                Connection.Close();

            }

            catch (Exception edd) {
                string message = "Echec de connexion";
                string title = "Erreur";
                MessageBox.Show(message, title);
                Connection.Close();
            }

            DataTable data = new DataTable();
            MySqlAdapter.Fill(data);
            datahistorique.DataSource = data;
        }

            private void Form5_Load(object sender, EventArgs e)
            {

            }

        private void fermerform5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            fermerform5_Click(sender, e);
        }
    }
    }

