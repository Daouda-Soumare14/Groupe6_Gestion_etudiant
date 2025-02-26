using System.Collections.Generic;

namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class ProfesseurEntity
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<ProfesseurMatiereEntity> ProfesseurMatiereEntities { get; set; }
    }
}
