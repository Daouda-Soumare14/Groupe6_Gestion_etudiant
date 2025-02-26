using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Projet_Exament_Gestion_Etudiant.views;
using Guna.UI2.WinForms;


namespace Projet_Exament_Gestion_Etudiant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeLoadingCircle();


        }

  
        private Form activeForm = null; // Stocke le formulaire actif
        private Panel loadingPanel;
        private Guna2ProgressIndicator loadingCircle;


        private void InitializeLoadingCircle()
        {
            loadingCircle = new Guna2ProgressIndicator
            {
                Size = new Size(100, 100),
                Location = new Point((this.Width - 100) / 2, (this.Height - 100) / 2),
                CircleSize = 5,  // Taille du cercle
                AnimationSpeed = 80, // Vitesse de rotation
                Visible = false // Caché au début
            };

            this.Controls.Add(loadingCircle);
        }


        private async void OpenChildForm(Form childForm)
        {
            // Afficher l'animation de chargement
            loadingCircle.Visible = true;
            loadingCircle.BringToFront();
            loadingCircle.Start();

            await Task.Delay(500); // Pause pour montrer l'effet de chargement

            if (activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            main_form.Controls.Add(childForm);
            main_form.Tag = childForm;
            childForm.BringToFront();

            // Charger les données en arrière-plan
            await Task.Run(() =>
            {
                if (childForm is FormEtudiant formEtudiant)
                {
                    formEtudiant.showEtudiant();
                }
            });

            childForm.Show();

            // Cacher le cercle de chargement après chargement
            loadingCircle.Visible = false;
            loadingCircle.Stop();
        }


        private void linkLabel_dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm = null;
            }
        }

        private void linkLabel_etudiant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormEtudiant());
        }

        private void linkLabel_classe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormClasse());
        }

        private void linkLabel_professeur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormProfesseur());
        }

        private void linkLabel_utilisateur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormUtilisateur());
        }
    }
}
