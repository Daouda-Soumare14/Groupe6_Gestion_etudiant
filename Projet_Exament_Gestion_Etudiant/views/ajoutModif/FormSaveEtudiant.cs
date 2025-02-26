using System;
using System.Linq;
using System.Windows.Forms;
using Projet_Exament_Gestion_Etudiant.context;
using Projet_Exament_Gestion_Etudiant.models;

namespace Projet_Exament_Gestion_Etudiant.views.fomAjoutModif
{
    public partial class SaveForm : Form
    {
        private int? etudiantId = null; // ID de l'étudiant (null = ajout)
        public event Action OnDataUpdated; // Événement pour signaler la mise à jour


        // 🔹 Constructeur pour l'ajout
        public SaveForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            comboBox_Classe();
        }

        // 🔹 Constructeur pour la modification
        public SaveForm(int id)
        {
            InitializeComponent();
            etudiantId = id;
            editEtudiant(); // Charger les infos si modification
            this.StartPosition= FormStartPosition.CenterScreen;

            comboBox_Classe();
        }

        private void comboBox_Classe()
        {
            using (var db = new GestionEtudiantContext())
            {
                comboBox_classe.DataSource = db.Classes.ToList();
                comboBox_classe.DisplayMember = "NomClasse";
                comboBox_classe.ValueMember = "Id";
            }
        }

        private void editEtudiant()
        {
            using (var db = new GestionEtudiantContext())
            {
                var etudiant = db.Etudiants.FirstOrDefault(e => e.Id == etudiantId);

                if (etudiant != null)
                {
                    txt_matricule.Text = etudiant.Matricule;
                    txt_prenom.Text = etudiant.Prenom;
                    txt_nom.Text = etudiant.Nom;
                    txt_adresse.Text = etudiant.Adresse;
                    txt_email.Text = etudiant.Email;
                    txt_telephone.Text = etudiant.Telephone;
                    radioButton_homme.Checked = (etudiant.Sexe == "Homme");
                    radioButton_femme.Checked = (etudiant.Sexe == "Femme");
                    dateTime_datenaiss.Value = etudiant.DateNaissance;
                    comboBox_classe.SelectedValue = etudiant.IdClasse;
                }
            }
        }

        private void btn_sauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new GestionEtudiantContext())
                {
                    EtudiantEntity etudiant;

                    if (etudiantId.HasValue) // Mode modification
                    {
                        etudiant = db.Etudiants.FirstOrDefault(c => c.Id == etudiantId);
                        if (etudiant == null)
                        {
                            MessageBox.Show("L'étudiant n'existe pas !");
                            return;
                        }
                    }
                    else // Mode ajout
                    {
                        etudiant = new EtudiantEntity();
                        db.Etudiants.Add(etudiant);
                    }

                    // Remplir les champs
                    etudiant.Matricule = txt_matricule.Text;
                    etudiant.Prenom = txt_prenom.Text;
                    etudiant.Nom = txt_nom.Text;
                    etudiant.Adresse = txt_adresse.Text;
                    etudiant.Email = txt_email.Text;
                    etudiant.Telephone = txt_telephone.Text;
                    etudiant.Sexe = radioButton_homme.Checked ? "Homme" : "Femme";
                    etudiant.DateNaissance = dateTime_datenaiss.Value;

                    if (comboBox_classe.SelectedValue != null)
                    {
                        etudiant.IdClasse = Convert.ToInt32(comboBox_classe.SelectedValue);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Étudiant enregistré avec succès !");

                    OnDataUpdated?.Invoke(); // 🔹 Notifier FormEtudiant de la mise à jour

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }
    }
}
