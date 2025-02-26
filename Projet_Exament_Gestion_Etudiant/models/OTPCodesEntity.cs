using System;

namespace Projet_Exament_Gestion_Etudiant.models
{
    internal class OTPCodesEntity
    {
        // Un utilisateur peut recevoir plusieurs codes OTP pour la connexion sécurisée.
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        public virtual UtilisateurEntity UtilisateurEntity { get; set; }
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }
    }
}
