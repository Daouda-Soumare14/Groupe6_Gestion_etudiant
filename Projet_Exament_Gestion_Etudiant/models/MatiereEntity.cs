using System.Collections.Generic;

namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class MatiereEntity
    {
        public int Id { get; set; }
        public string NomMatiere { get; set; }

        public virtual ICollection<CourMatiereEntity> CourMatiereEntities { get; set; }
        public virtual ICollection<ProfesseurMatiereEntity> ProfesseurMatiereEntities { get; set; }
        public virtual ICollection<NoteEntity> NoteEntities { get; set; }
    }
}
