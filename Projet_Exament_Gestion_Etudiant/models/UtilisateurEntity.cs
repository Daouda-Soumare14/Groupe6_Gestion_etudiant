namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class UtilisateurEntity
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; } // "Administrateur", "DE", "Agent", "Professeur"
        public string Telephone { get; set; }
    }
}
