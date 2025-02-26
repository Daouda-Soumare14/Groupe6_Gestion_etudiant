namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class CourMatiereEntity
    {
        // Un cours contient plusieurs matières et une matière peut appartenir à plusieurs cours.
        public int Id { get; set; }
        public int IdCours { get; set; }
        public virtual CourEntities CourEntities { get; set; }
        public int IdMatiere { get; set; }
        public virtual MatiereEntity MatiereEntity { get; set; }
    }
}
