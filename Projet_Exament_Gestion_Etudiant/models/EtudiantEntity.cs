using System;
using System.Collections.Generic;

namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class EtudiantEntity
    {
        // Un étudiant appartient à UNE classe, mais une classe contient plusieurs étudiants.
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; } // 'M' ou 'F'
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        // Propriete de navigation
        public int IdClasse { get; set; }
        public virtual ClasseEntity ClasseEntity { get; set; }

        // un etudiant peut avoir plusieur notes
        public virtual ICollection<NoteEntity> NoteEntities { get; set; }
    }
}
