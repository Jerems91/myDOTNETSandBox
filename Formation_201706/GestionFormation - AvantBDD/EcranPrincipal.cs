using ClassesReutilisables;
using ClassesReutilisables.Human;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFormation {
    public partial class EcranPrincipal : Form {
        public EcranPrincipal() {
            InitializeComponent();
        }

        private void aproposdeToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void EcranPrincipal_Load(object sender, EventArgs e) {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.DataTable1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Stagiaire'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.stagiaireTableAdapter.Fill(this.dataSet1.Stagiaire);
            Stagiaire s1 = new Stagiaire("DESSAINT", "Jérémy", Civilite.Monsieur);
            s1.Societe = "Groupama";
            s1.Payeur = Payeur.PoleEmploi;

            Stagiaire s2 = new Stagiaire("FERERRA", "Hélène", Civilite.Madame);
            //s2.Societe = "Taxis G7";
            s2.Societe = "Groupama";
            s2.Payeur = Payeur.Societe;

            Stagiaire s3 = new Stagiaire("GABLIER", "Sophie", Civilite.Madame);
            //s3.Societe = "SOTEMPO";
            s3.Societe = "Groupama";
            s3.Payeur = Payeur.Individuel;

            Formation cSharp = new Formation("C# - Initiation et approfondissement");
            cSharp.Duree = 5;
            cSharp.PrixHt = 2475;
            Session session1 = new Session(new DateTime(2017, 6, 19), "Paris", cSharp, 6);
            session1.Inscrire(s1);
            session1.Inscrire(s2);
            // session1.Inscrire(s3);
            session1.Formateur = new Formateur("MARRON", "Benjamin");

            InitWith(session1);
        }

        private ListViewItem CreateItemFrom(Stagiaire s) {
            ListViewItem item = new ListViewItem();
            item.Text = String.Format("{0} {1}", s.Nom, s.Prenom);
            item.ImageIndex = (s.Civilite == Civilite.Madame) ? 0 : 1;
            item.SubItems.Add(s.Societe);
            item.SubItems.Add(s.Payeur.ToString());
            item.Tag = s; // Stockage du stagiaire dans la propriété Tag
            return item;
        }

        private void InitWith(Session session) {
            detailSession1.SessionCourante = session;
            stagiairesListView.Items.Clear();
            foreach (var s in session.Stagiaires) {
                stagiairesListView.Items.Add(CreateItemFrom(s));
            }
            ajoutBtn.Enabled = !session.IsFull;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBox1.SelectedItem) {
                case "Détails":
                    stagiairesListView.View = View.Details;
                    break;
                case "Large":
                    stagiairesListView.View = View.LargeIcon;
                    break;
                case "Small":
                    stagiairesListView.View = View.SmallIcon;
                    break;
                default:
                    stagiairesListView.View = View.Details;
                    break;
            }
        }

        private void ajoutBtn_Click(object sender, EventArgs e) {
            StagiaireForm form = new StagiaireForm();
            DialogResult dlgResult = form.ShowDialog();
            if (dlgResult == DialogResult.OK) {
                detailSession1.SessionCourante.Inscrire(form.StagiaireSaisi);
                InitWith(detailSession1.SessionCourante);
            }
        }

        private void stagiairesListView_SelectedIndexChanged(object sender, EventArgs e) {
            detailBtn.Enabled = !(stagiairesListView.SelectedItems.Count == 0);
            modificationBtn.Enabled = !(stagiairesListView.SelectedItems.Count == 0);
            suppressionBtn.Enabled = !(stagiairesListView.SelectedItems.Count == 0);
        }

        private void suppressionBtn_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in stagiairesListView.SelectedItems) {
                Stagiaire stagiaireSelected = item.Tag as Stagiaire;
                string libelle = String.Format("Etes-vous certain de vouloir supprimer {0} ?", stagiaireSelected);
                DialogResult result = MessageBox.Show(libelle, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes) {
                    detailSession1.SessionCourante.Stagiaires.Remove(stagiaireSelected);
                }
            }
            InitWith(detailSession1.SessionCourante);
        }

        private void modificationBtn_Click(object sender, EventArgs e) {
            Stagiaire stagiaireSelected = stagiairesListView.SelectedItems[0].Tag as Stagiaire;
            StagiaireForm form = new StagiaireForm();
            form.StagiaireSaisi = stagiaireSelected;
            DialogResult dlgResult = form.ShowDialog();
            if (dlgResult == DialogResult.OK) {
                InitWith(detailSession1.SessionCourante);
            }
        }

        private void detailBtn_Click(object sender, EventArgs e) {
            Stagiaire stagiaireSelected = stagiairesListView.SelectedItems[0].Tag as Stagiaire;
            StagiaireForm form = new StagiaireForm();
            form.StagiaireSaisi = stagiaireSelected;
            form.EditMode = false;
            form.Show();
        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e) {
            Utils.Save(detailSession1.SessionCourante.Stagiaires);
        }

        private void enregistrersousToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                Utils.Save(detailSession1.SessionCourante.Stagiaires, saveFileDialog1.OpenFile());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            this.dataTable1TableAdapter.FillBy(this.dataSet1.DataTable1,"%" + textBox1.Text + "%");
        }
    }
}
