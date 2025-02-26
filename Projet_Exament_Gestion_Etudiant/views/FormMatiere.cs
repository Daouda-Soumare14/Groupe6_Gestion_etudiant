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
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
            showMatiere();
        }

        public void showMatiere()
        {
            using (var db = new GestionEtudiantContext())
            {
                var listeMatieres = db.Matieres
                    .Select(m => new
                    {
                        m.Id,
                        m.NomMatiere,
                    }).ToList();

                dataGridView_matiere.DataSource = listeMatieres;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormSaveMatiere form = new FormSaveMatiere();
           // form.OnDataUpdated += showMatiere();
            form.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView_matiere.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView_matiere.SelectedRows[0].Cells["Id"].Value);
                FormSaveMatiere form = new FormSaveMatiere(id);
               // form.OnDataUpdated += showMatiere();
                form.ShowDialog();
            }
        }
    }
}
