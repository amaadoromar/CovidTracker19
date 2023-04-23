using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace corona
{
    public class Persistance
    {
        static string sql = @"server=IP;user id=user;Password=pass;database=db";
        static MySqlConnection Connection = new MySqlConnection(sql);
        static MySqlCommand qy = new MySqlCommand();
        static MySqlCommand qy2 = new MySqlCommand();
        static MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter(qy);



        public bool testquery(MySqlCommand query)
        {

            
            query.Connection = Connection;
            // qy.ExecuteNonQuery();
            bool q = false;
            try
            {
                query.ExecuteNonQuery();
                    Connection.Close();
                return q;
            }
            
            catch (Exception e)
            {
                Connection.Close();
                return q;
            }

        }


        public bool Addcitoyen(Citoyen C,String password) 
        {
            bool q = false;
            qy.CommandText = @"INSERT INTO Citoyen (Cin,NomEtPrenom,DateDeNaissance,NumeroDeTelephone,Adresse) VALUES ('" + C.Cin + "','" + C.NomEtPrenom
                              + "','" + C.DateDeNaissance + "','" + C.NumeroDeTelephone + "','" + C.Adresse + "');INSERT INTO Users(Cin,Password,NomEtPrenom) VALUES ('"+C.Cin+"','"+password+"','"+C.NomEtPrenom+"')";
            
            qy.Connection = Connection;
            Connection.Open();
            // qy.ExecuteNonQuery();

            try
            {
                String now = DateTime.Now.ToString("yyyy-MM-dd");
                qy.ExecuteNonQuery();
                    Connection.Close();
                qy2.CommandText = @"INSERT INTO historique (Cin,Event,Date) VALUES ('" + C.Cin + "','Citoyen Ajouté','" +now+ "')";

                qy2.Connection = Connection;
                Connection.Open();
                // qy.ExecuteNonQuery();

                try
                {
                    qy2.ExecuteNonQuery();
                    Connection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Connection.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                Connection.Close();
                 return false;
            }
           




        }
        public MySqlCommand patdeces(Patient S)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            qy.CommandText = @"DELETE FROM Users WHERE Cin  = '" + S.Cin + "' ; DELETE FROM Patient WHERE Cin  = '" + S.Cin + "';DELETE FROM Citoyen WHERE Cin  = '" + S.Cin + "' ; DELETE FROM Patient WHERE Cin  = '" + S.Cin + "'; DELETE FROM historique WHERE Cin  = '" + S.Cin + "'; INSERT INTO deces(Cin,NomEtPrenom,datedeces) VALUES ('"+ S.Cin +"', '"+ S.NomEtPrenom +"','"+now+"')";

            return qy;
        }

        public MySqlCommand showdeces()
        {

            qy.CommandText = @"SELECT * FROM deces";
            return qy;
        }
        public bool suspectupdate(Citoyen C, Suspect S)
        {

            qy.CommandText = @"UPDATE Citoyen SET NumeroDeTelephone ='" + C.NumeroDeTelephone + "',DateDeNaissance ='" + C.DateDeNaissance + "',Adresse ='" + C.Adresse + "',NomEtPrenom ='" + C.NomEtPrenom + "',Vaccin ='" + (Convert.ToByte(S.Vaccin)) + "',CodeCouleur ='" + S.CodeCouleur + "', Encontact = '" + (Convert.ToByte(S.Encontact)) + "', Frequente = '" + Convert.ToByte(S.Frequente) + "', testcorona = '" + Convert.ToByte(S.testcorona) + "' WHERE Cin= '" + S.Cin + "'";
            Connection.Open();
            qy.Connection = Connection;
            // qy.ExecuteNonQuery();

            try { qy.ExecuteNonQuery(); Connection.Close(); return true; }
            catch (Exception edd) { Connection.Close(); return false; }

        }

        public bool Citoyentosuspect(Citoyen S)
        {

            qy.CommandText = @"INSERT INTO Suspect(Cin) VALUES ('" + S.Cin + "');UPDATE Citoyen SET CodeCouleur ='" + S.CodeCouleur + "', Encontact = '" +(Convert.ToByte(S.Encontact))+ "', Frequente = '"+ Convert.ToByte(S.Frequente) +"', symptomatic = '"+ Convert.ToByte(S.symptomatic) + "', Frequente = '" + Convert.ToByte(S.Frequente) + "' , testcorona = '" + Convert.ToByte(S.testcorona) + "' WHERE Cin= '" + S.Cin + "'"; 
            Connection.Open();
            qy.Connection = Connection;
            // qy.ExecuteNonQuery();

            try { qy.ExecuteNonQuery(); Connection.Close(); return true; }
            catch (Exception edd) { Connection.Close(); return false; }
        }

        public MySqlCommand suspecttopatient(Citoyen S)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            qy.CommandText = @"DELETE FROM Suspect WHERE Cin  = '" + S.Cin + "' ;INSERT INTO Patient(Cin,Date) VALUES ('"+S.Cin+"','"+now+"');UPDATE Citoyen SET CodeCouleur ='" + S.CodeCouleur + "', Encontact = '" + (Convert.ToByte(S.Encontact)) + "', Frequente = '" + Convert.ToByte(S.Frequente) + "', symptomatic = '" + Convert.ToByte(S.symptomatic) + "', Frequente = '" + Convert.ToByte(S.Frequente) + "' , testcorona = '" + Convert.ToByte(S.testcorona) + "' WHERE Cin= '" + S.Cin + "'";
            return qy;

        }

        public MySqlCommand suspecttocitoyen(Citoyen S)
        {

            qy.CommandText = @"DELETE FROM Suspect WHERE Cin  = '"+S.Cin +"' ;UPDATE Citoyen SET CodeCouleur ='Green', Encontact = '0', Frequente = '0', symptomatic = '0', Frequente = '0' , testcorona = '" + Convert.ToByte(S.testcorona) + "' WHERE Cin= '" + S.Cin + "'";
            return qy;
        }

        public MySqlCommand patienttocitoyen(Patient S)
        {

            qy.CommandText = @"DELETE FROM Patient WHERE Cin  = '" + S.Cin + "' ;UPDATE Citoyen SET CodeCouleur ='Green', Encontact = '0', Frequente = '0', symptomatic = '0', Frequente = '0' , testcorona = '" + Convert.ToByte(S.testcorona) + "' WHERE Cin= '" + S.Cin + "'";
            return qy;
        }

        public MySqlCommand checkcodecouleurchanges(String Cin)
        {

            qy.CommandText = @"SELECT CodeCouleur from Citoyen WHERE  Citoyen.Cin = '"+Cin+"' ";
            return qy;
        }

        public MySqlCommand showvaccinated()
        {
            qy.CommandText = @"SELECT * FROM Citoyen WHERE Citoyen.Vaccin = '1' ";
            return qy;
        }
        public MySqlCommand showhistorique(Citoyen C)
        {
            qy.CommandText = @"SELECT * FROM historique WHERE historique.Cin = '"+C.Cin+"' ";
            return qy;

        }

        public MySqlCommand vaccinatecitoyen(Citoyen C)
        {
            qy.CommandText = @"UPDATE Citoyen SET Vaccin ='1' WHERE Cin= '" + C.Cin + "'";
            return qy;

        }
        public bool updatehistorique(Citoyen C,String Event)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            qy.CommandText = @"INSERT INTO historique (Cin,Event,Date) VALUES ('"+C.Cin+"' , '"+Event+"'  , '"+now+"')";
            qy.Connection = Connection;
            Connection.Open();
            


            try { qy.ExecuteNonQuery(); Connection.Close();  return true; }
            catch (Exception edd) { Connection.Close(); return false; }

        }

        public MySqlCommand updatepatient(Patient  C)
        {
            qy.CommandText = @"UPDATE Patient SET Cin ='" + C.Cin + "',symptomegrave ='" + Convert.ToByte(C.Medicationhopital) + "',etataggrave ='" + Convert.ToByte(C.Reanimation) +"' WHERE Cin= '" + C.Cin + "'";
            return qy;

        }

        public bool Citoyentopatient(Citoyen S)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            qy.CommandText = @"INSERT INTO Patient(Cin,date) VALUES ('" + S.Cin + "','"+now+"');UPDATE Citoyen SET CodeCouleur ='" + S.CodeCouleur + "', Encontact = '" + (Convert.ToByte(S.Encontact)) + "', Frequente = '" + Convert.ToByte(S.Frequente) + "', symptomatic = '" + Convert.ToByte(S.symptomatic) + "', Frequente = '" + Convert.ToByte(S.Frequente) + "' WHERE Cin= '" + S.Cin + "'";
            Connection.Open();
            qy.Connection = Connection;
            // qy.ExecuteNonQuery();

            try { qy.ExecuteNonQuery(); Connection.Close();  return true; }
            catch (Exception edd) { Connection.Close();  return false; }

        }

    }
}
