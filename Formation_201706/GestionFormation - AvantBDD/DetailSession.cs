using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesReutilisables;

namespace GestionFormation {
    public partial class DetailSession : UserControl {

        private Session sessionCourante;

        public Session SessionCourante {
            get => sessionCourante;
            set {
                sessionCourante = value;
                if (sessionCourante != null) {
                    UpdateSession();
                }
            }
        }

        public DetailSession() {
            InitializeComponent();
        }

        public void UpdateSession() {
            if (SessionCourante.Formation != null) {
                titreFormationLbl.Text = SessionCourante.Formation.Titre;
                dureeLbl.Text = String.Format("{0} jours", SessionCourante.Formation.Duree);
                prixUnitaireLbl.Text = String.Format("{0:C2} HT", SessionCourante.Formation.PrixHt);
            } else {
                titreFormationLbl.Text = String.Empty;
                dureeLbl.Text = String.Empty;
                prixUnitaireLbl.Text = String.Empty;
            }
            lieuLbl.Text = SessionCourante.Lieu;
            placesDispoLbl.Text = String.Format("{0}", SessionCourante.NbPlacesMaxi);
            placesRestantesLbl.Text = String.Format("{0}", SessionCourante.NbPlacesMaxi - SessionCourante.NbInscrits);
            if (SessionCourante.Formateur != null) {
                formateurLbl.Text = String.Format("{0} {1}", SessionCourante.Formateur.Nom, SessionCourante.Formateur.Prenom);
            } else {
                formateurLbl.Text = "Aucun formateur affecté";
            }
            montantTotalLbl.Text = String.Format("{0:C2} TTC", SessionCourante.CalculerMontantTtc());
        }
    }
}
