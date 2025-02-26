using System.Collections.Generic;

namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class ClasseEntity
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public virtual ICollection<EtudiantEntity> EtudiantEntities { get; set; }
        public virtual ICollection<ClasseCourEntity> ClasseCourEntities { get; set; }

    }
}
