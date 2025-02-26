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
    public partial class FormSaveMatiere : Form
    {
        public event Action OnDataUpdated;
        private int? idMatiere = null;

        public FormSaveMatiere()
        {
            InitializeComponent();
        }
        public FormSaveMatiere(int id )
        {
            InitializeComponent();
            idMatiere = id;
        }

        public void editMatiere()
        {
            using (var db = new GestionEtudiantContext())
            {
                var matiere = db.Matieres.FirstOrDefault(m =>  m.Id == idMatiere);
                if (matiere != null)
                {
                    txt_nom_matier.Text = matiere.NomMatiere;
                }
                    
            }
        }

        private void btn_sauvegarder_Click(object sender, EventArgs e)
        {
            try
            {

                using (var db = new GestionEtudiantContext())
                {
                    MatiereEntity matiere;
                    if (idMatiere.HasValue)
                    {
                        matiere = db.Matieres.FirstOrDefault(m => m.Id == idMatiere);
                        if (matiere == null)
                        {
                            MessageBox.Show("la matiere n'existe pas ");
                            return;
                        }

                    }
                    else
                    {
                        matiere = new MatiereEntity();
                        db.Matieres.Add(matiere);
                    }
                    matiere.NomMatiere = txt_nom_matier.Text;
                    db.SaveChanges();
                    MessageBox.Show("la matiere enrigistre avec success ");

                    OnDataUpdated?.Invoke();

                    this.Close();

                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }
    }
}
