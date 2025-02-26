using System.Collections.Generic;

namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class CourEntities
    {
        public int Id { get; set; }
        public string NomCours { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ClasseCourEntity> ClasseCourEntities { get; set; }
        public virtual ICollection<CourMatiereEntity> CourMatiereEntities { get; set; }
    }
}
