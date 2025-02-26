namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class ClasseCourEntity
    {
        // Une classe peut suivre plusieurs cours et un cours peut être suivi par plusieurs classes.
        public int Id { get; set; }
        public int IdClasse { get; set; }
        public virtual ClasseEntity ClasseEntity { get; set; }
        public int IdCours { get; set; }
        public virtual CourEntities CourEntities { get; set; }
    }
}
