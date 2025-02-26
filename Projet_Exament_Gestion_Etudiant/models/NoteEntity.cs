namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class NoteEntity
    {
        // Un étudiant peut avoir plusieurs notes, mais une note appartient à un seul étudiant.
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public virtual EtudiantEntity EtudiantEntity { get; set; }
        public int IdMatiere { get; set; }
        public virtual MatiereEntity MatiereEntity { get; set; }
        public float NoteValeur { get; set; }
    }
}
