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
using Projet_Exament_Gestion_Etudiant.views.ajoutModif;

namespace Projet_Exament_Gestion_Etudiant.views
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
            showClasse();
        }

        public void showClasse()
        {
            using (var db = new GestionEtudiantContext())
            {
                var listeClasses = db.Classes
                    .Select(e => new
                    {
                       e.Id,
                       e.NomClasse,
                    }).ToList();

                dataGridView_classe.DataSource = listeClasses;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormSaveClasse form = new FormSaveClasse();
            form.OnDataUpdated += showClasse;
            form.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_classe.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView_classe.SelectedRows[0].Cells["Id"].Value);
                FormSaveClasse form = new FormSaveClasse(id);
                form.OnDataUpdated += showClasse;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier !");
            }
        }
    }
}
