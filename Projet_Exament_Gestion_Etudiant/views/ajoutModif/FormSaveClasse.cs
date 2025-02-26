using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Exament_Gestion_Etudiant.context;
using Projet_Exament_Gestion_Etudiant.models;

namespace Projet_Exament_Gestion_Etudiant.views.ajoutModif
{
    public partial class FormSaveClasse : Form
    {
        public event Action OnDataUpdated;
        private int? idClasse = null;
        public FormSaveClasse()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormSaveClasse(int id)
        {
            InitializeComponent();
            idClasse = id;
            this.StartPosition = FormStartPosition.CenterScreen;
            editClasse();
        }

        private void editClasse()
        {
            using (var db = new GestionEtudiantContext())
            {
                var classe = db.Classes.FirstOrDefault(c => c.Id == idClasse);
                if (classe != null)
                {
                    txt_nom_classe.Text = classe.NomClasse;
                }
            }
        }

        private void btn_sauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new GestionEtudiantContext())
                {
                    ClasseEntity classe;

                    if (idClasse.HasValue)
                    {
                        classe = db.Classes.FirstOrDefault(c => c.Id == idClasse);
                        if (classe == null)
                        {
                            MessageBox.Show("La Classe n'existe pas");
                            return;
                        }
                    }
                    else
                    {
                        classe = new ClasseEntity();
                        db.Classes.Add(classe);
                    }

                    classe.NomClasse = txt_nom_classe.Text;

                    db.SaveChanges();

                    MessageBox.Show("Classe ajouter avec succes");

                    OnDataUpdated?.Invoke();

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
