using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corona
{
    public partial class login : Form
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qy.CommandText = "SELECT COUNT(*) FROM Users WHERE Cin='" + username.Text + "' AND Password='" + password.Text + "'";
            qy.Connection = Connection;
            Connection.Open();
           
            DataTable dt = new DataTable();
            MySqlAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                qy.CommandText = "SELECT * FROM Citoyen WHERE Cin='" + username.Text + "'";
                qy.Connection = Connection;
                dt = new DataTable();
                MySqlAdapter.Fill(dt);
                String NomEtPrenom = dt.Rows[0][1].ToString();
                String CodeCouleur = dt.Rows[0][4].ToString();
                qy.CommandText = "SELECT admin from Users WHERE  Cin='" + username.Text + "'";
                qy.Connection = Connection;
                DataTable df = new DataTable();
                MySqlAdapter.Fill(df);
                if(df.Rows[0][0].ToString() == "1")
                {
                    Connection.Close();
                    this.Hide();
                    Form form1 = new Form1();
                    form1.Show();
                }
               else
                {
                    Connection.Close();
                    this.Hide();
                Form loggedin = new loggedin(NomEtPrenom,CodeCouleur);
                loggedin.Show();
                }
            }
            else
            {
                Connection.Close();
            MessageBox.Show("Cin ou Mot de passe invalide");
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form lg = new login();
            Form Form2 = new Form2(lg);
            Form2.Show();
        }
    }
}
