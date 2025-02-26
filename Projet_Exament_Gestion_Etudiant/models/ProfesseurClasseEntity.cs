namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class ProfesseurClasseEntity
    {
        // Un professeur peut enseigner dans plusieurs classes et une classe peut avoir plusieurs professeurs.
        public int Id { get; set; }
        public int IdProfesseur { get; set; }
        public virtual ProfesseurEntity ProfesseurEntity { get; set; }
        public int IdClasse { get; set; }
        public virtual ClasseEntity ClasseEntity { get; set; }
    }
}
