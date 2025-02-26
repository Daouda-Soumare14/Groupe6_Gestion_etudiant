namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class ProfesseurMatiereEntity
    {
        // Un professeur peut enseigner plusieurs matières et une matière peut être enseignée par plusieurs professeurs.
        public int Id { get; set; }
        public int IdProfesseur { get; set; }
        public virtual ProfesseurEntity ProfesseurEntity { get; set; }
        public int IdMatiere { get; set; }
        public virtual MatiereEntity MatiereEntity { get; set; }
    }
}
