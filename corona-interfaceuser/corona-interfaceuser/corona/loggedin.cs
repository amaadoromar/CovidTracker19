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
    public partial class loggedin : Form
    {
        String codecouleurc;
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand stats = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);
        Persistance pr = new Persistance();
        string now = DateTime.Now.ToString("yyyy-MM-dd");

        public loggedin(String  NomEtPrenom,String CodeCouleur)
        {
            InitializeComponent();
            fullname.Text = NomEtPrenom;
            codecouleurc = CodeCouleur;
            try
            {

                stats.CommandText = "SELECT COUNT(*) FROM Patient WHERE Patient.date='" + now + "'";
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
            Int32 ntcallcount = Convert.ToInt32(ntcall.Text);
            Int32 ntdallcount = Convert.ToInt32(ntdall.Text);
            Int32 ntcnowcount = Convert.ToInt32(ntcnow.Text);
            Int32 ntdnowcount = Convert.ToInt32(ntdnow.Text);

            ntcallcount += ntdallcount;
            ntcnowcount += ntdnowcount;

            ntcall.Text = Convert.ToString(ntcallcount);
            ntcnow.Text = Convert.ToString(ntcnowcount);

        }

        public void codecouleurchange()
        {
            if (codecouleurc == "Green")
            {
                //design rectangle and fill color 
                Graphics g = panel1.CreateGraphics();
                Rectangle r = new Rectangle();
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Green);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 278, 288);
                g.FillRectangle(sb, 1, 1, 278, 288);
                state.Text = "Non Suspect";
            }
            if (codecouleurc  == "Orange")
            {
                //design rectangle and fill color 
                Graphics g = panel1.CreateGraphics();
                Rectangle r = new Rectangle();
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Orange);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 278, 288);
                g.FillRectangle(sb, 1, 1, 278, 288);
                state.Text = "Suspect";
            }
            if (codecouleurc == "Red")
            {
                //design rectangle and fill color 
                Graphics g = panel1.CreateGraphics();
                Rectangle r = new Rectangle();
                Pen p = new Pen(Color.Black);
                SolidBrush sb = new SolidBrush(Color.Red);
                PaintEventArgs ed = new PaintEventArgs(g, r);
                g.DrawRectangle(p, 1, 1, 278, 288);
                g.FillRectangle(sb, 1, 1, 278, 288);
                state.Text = "Patient";
            }
            //   }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            codecouleurchange();
        }

        private void loggedin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
