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
    public partial class StagiaireForm : Form {

        public Stagiaire StagiaireSaisi { get; set; }
        public bool EditMode { get; set; } = true;

        public StagiaireForm() {
            InitializeComponent();
        }

        private void validerBtn_Click(object sender, EventArgs e) {
            // Ajout de contrôles de saisie sur les champs Nom et Prénom
            if (String.IsNullOrEmpty(nomTextBox.Text)) {
                errorProvider1.SetError(nomTextBox, "Nom obligatoire");
                return;
            } else {
                errorProvider1.SetError(nomTextBox, String.Empty);
            }
            if (String.IsNullOrEmpty(prenomTextBox.Text)) {
                errorProvider1.SetError(prenomTextBox, "Prénom obligatoire");
                return;
            } else {
                errorProvider1.SetError(prenomTextBox, String.Empty);
            }
            DialogResult = DialogResult.OK;
            if (StagiaireSaisi == null) {
                StagiaireSaisi = new Stagiaire(nomTextBox.Text, prenomTextBox.Text);
            } else {
                StagiaireSaisi.Nom = nomTextBox.Text;
                StagiaireSaisi.Prenom = prenomTextBox.Text;
            }
            StagiaireSaisi.Civilite = (Civilite)civiliteComboBox.SelectedItem;
            StagiaireSaisi.DateNaissance = dateNaissanceTimePicker.Value;
            StagiaireSaisi.Email = emailTextBox.Text;
            StagiaireSaisi.Societe = societeTextBox.Text;
            StagiaireSaisi.Payeur = (Payeur)payeurComboBox.SelectedItem;
            StagiaireSaisi.RegimeAlimentaire = regimeAlimentaireCheckBox.Checked;
            StagiaireSaisi.Remise = (double)remiseNumericUpDown.Value;
            Visible = false;
        }

        private void annulerBtn_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Visible = false;
        }

        private void StagiaireForm_Load(object sender, EventArgs e) {
            foreach (var item in Enum.GetValues(typeof(Civilite))) {
                civiliteComboBox.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Payeur))) {
                payeurComboBox.Items.Add(item);
            }
            dateNaissanceTimePicker.MinDate = DateTime.Now.AddYears(-65);
            dateNaissanceTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            dateNaissanceTimePicker.Value = dateNaissanceTimePicker.MaxDate;
            if (StagiaireSaisi != null) {
                nomTextBox.Text = StagiaireSaisi.Nom;
                prenomTextBox.Text = StagiaireSaisi.Prenom;
                civiliteComboBox.SelectedItem = StagiaireSaisi.Civilite;
                try {
                    dateNaissanceTimePicker.Value = StagiaireSaisi.DateNaissance;
                } catch (ArgumentOutOfRangeException) {
                    dateNaissanceTimePicker.Value = dateNaissanceTimePicker.MaxDate;
                }
                emailTextBox.Text = StagiaireSaisi.Email;
                societeTextBox.Text = StagiaireSaisi.Societe;
                payeurComboBox.SelectedItem = StagiaireSaisi.Payeur;
                regimeAlimentaireCheckBox.Checked = StagiaireSaisi.RegimeAlimentaire;
                remiseNumericUpDown.Value = (decimal)StagiaireSaisi.CalculerRemise();
            }
            detailsBox.Enabled = EditMode;
            validerBtn.Visible = EditMode;
        }
    }
}
