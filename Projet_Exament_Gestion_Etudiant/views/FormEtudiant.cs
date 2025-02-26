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
using Projet_Exament_Gestion_Etudiant.views.fomAjoutModif;

namespace Projet_Exament_Gestion_Etudiant.views
{
    public partial class FormEtudiant : Form
    {
        public FormEtudiant()
        {
            InitializeComponent();
            showEtudiant();
        }

        public void showEtudiant()
        {
            using (var db = new GestionEtudiantContext()) // Remplace par ton DbContext
            {
                var listeEtudiants = db.Etudiants
                    .Select(e => new
                    {
                        e.Id,
                        e.Matricule,
                        e.Prenom,
                        e.Nom,
                        e.Adresse,
                        e.Email,
                        e.Telephone,
                        e.Sexe,
                        e.DateNaissance,
                        classe = e.ClasseEntity != null ? e.ClasseEntity.NomClasse : "Non attribuée"
                    })
                    .ToList();

                dataGridView_etudiant.DataSource = listeEtudiants;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SaveForm form = new SaveForm(); // Mode ajout
            form.OnDataUpdated += showEtudiant; // Met à jour la liste après fermeture
            form.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_etudiant.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView_etudiant.SelectedRows[0].Cells["Id"].Value);
                SaveForm form = new SaveForm(id); // Mode modification
                form.OnDataUpdated += showEtudiant; // Met à jour la liste après fermeture
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier !");
            }
        }
    }
}
