using ClassesReutilisables;
using ClassesReutilisables.Human;
using GestionFormation.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionFormation.DataSet1;

namespace GestionFormation.Bdd {
    class StagiaireDao {
        private StagiaireTableAdapter adapter;

        public StagiaireDao(StagiaireTableAdapter adapter) {
            this.adapter = adapter;
        }

        public List<Stagiaire> FindBySessionId(int sessionId) {

            List<Stagiaire> resultat = new List<Stagiaire>();
            //dataSet.Stagiaire.Select("SessionId = " + sessionId);
            var dataTable = adapter.GetDataBySessionId(sessionId);
            foreach (StagiaireRow stagiaireRow in dataTable.ToList()) {
                Stagiaire s = new Stagiaire(stagiaireRow.Nom, stagiaireRow.Prenom);
                s.Id = stagiaireRow.Id;
                s.Civilite = (Civilite)Enum.Parse(typeof(Civilite), stagiaireRow.Civilite);
                s.DateNaissance = stagiaireRow.DateNaissance;
                s.Email = stagiaireRow.Email;
                s.Societe = stagiaireRow.Societe;
                s.RegimeAlimentaire = stagiaireRow.RegimeAlimentaire;
                s.Payeur = (Payeur)Enum.Parse(typeof(Payeur), stagiaireRow.Payeur);
                resultat.Add(s);
            }
            return resultat;
        }

        public void Delete(Stagiaire s) {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

            cnx.Open();

            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "DELETE from Stagiaire where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", s.Id);
            cmd.ExecuteNonQuery();

            cnx.Close();
        }

        public void Create(Stagiaire s, DataSet1 ds) {
            var stagiaireRow = ds.Stagiaire.NewStagiaireRow();

            stagiaireRow.Nom = s.Nom;
            stagiaireRow.Prenom = s.Prenom;
            stagiaireRow.Civilite = String.Format("{0}", s.Civilite);
            stagiaireRow.DateNaissance = s.DateNaissance;
            stagiaireRow.Email = s.Email;
            stagiaireRow.Societe = s.Societe;
            stagiaireRow.RegimeAlimentaire = s.RegimeAlimentaire;
            stagiaireRow.Payeur = String.Format("{0}", s.Payeur);

            ds.Stagiaire.Rows.Add(stagiaireRow);
            adapter.Update(stagiaireRow);
            ds.AcceptChanges();
        }

        public void Update(Stagiaire s, DataSet1 ds) {
            DataRow[] savedStagiaires = ds.Stagiaire.Select("Id = " + s.Id);
            var stagiaireRow = savedStagiaires[0] as StagiaireRow;

            stagiaireRow.Nom = s.Nom;
            stagiaireRow.Prenom = s.Prenom;
            stagiaireRow.Civilite = String.Format("{0}", s.Civilite);
            stagiaireRow.DateNaissance = s.DateNaissance;
            stagiaireRow.Email = s.Email;
            stagiaireRow.Societe = s.Societe;
            stagiaireRow.RegimeAlimentaire = s.RegimeAlimentaire;
            stagiaireRow.Payeur = String.Format("{0}", s.Payeur);

            adapter.Update(stagiaireRow);
            ds.AcceptChanges();
        }
    }
}
