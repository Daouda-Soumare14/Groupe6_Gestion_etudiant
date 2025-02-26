using System.Data.Entity;
using Projet_Exament_Gestion_Etudiant.models;

namespace Projet_Exament_Gestion_Etudiant.context
{
    internal class GestionEtudiantContext : DbContext
    {
        public GestionEtudiantContext() : base("gestion_etudiant") { }

        public DbSet<EtudiantEntity> Etudiants { get; set; }
        public DbSet<ClasseEntity> Classes { get; set; }
        public DbSet<CourEntities> Cours { get; set; }
        public DbSet<ProfesseurEntity> Professeurs { get; set; }
        public DbSet<NoteEntity> Notes { get; set; }
        public DbSet<MatiereEntity> Matieres { get; set; }
        public DbSet<ClasseCourEntity> ClasseCours { get; set; }
        public DbSet<CourMatiereEntity> CoursMatieres { get; set; }
        public DbSet<ProfesseurClasseEntity> ProfesseurClasses { get; set; }
        public DbSet<ProfesseurMatiereEntity> ProfesseurMatieres { get; set; }
        public DbSet<UtilisateurEntity> Utilisateurs { get; set; }
        public DbSet<OTPCodesEntity> OTPCodes { get; set; }
    }
}
