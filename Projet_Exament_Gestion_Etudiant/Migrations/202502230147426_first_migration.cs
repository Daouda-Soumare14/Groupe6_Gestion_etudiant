namespace Projet_Exament_Gestion_Etudiant.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class first_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClasseCourEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IdClasse = c.Int(nullable: false),
                    IdCours = c.Int(nullable: false),
                    ClasseEntity_Id = c.Int(),
                    CourEntities_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClasseEntities", t => t.ClasseEntity_Id)
                .ForeignKey("dbo.CourEntities", t => t.CourEntities_Id)
                .Index(t => t.ClasseEntity_Id)
                .Index(t => t.CourEntities_Id);

            CreateTable(
                "dbo.ClasseEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NomClasse = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.EtudiantEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Matricule = c.String(),
                    Nom = c.String(),
                    Prenom = c.String(),
                    DateNaissance = c.DateTime(nullable: false),
                    Sexe = c.String(),
                    Adresse = c.String(),
                    Telephone = c.String(),
                    Email = c.String(),
                    IdClasse = c.Int(nullable: false),
                    ClasseEntity_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClasseEntities", t => t.ClasseEntity_Id)
                .Index(t => t.ClasseEntity_Id);

            CreateTable(
                "dbo.NoteEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IdEtudiant = c.Int(nullable: false),
                    IdMatiere = c.Int(nullable: false),
                    NoteValeur = c.Single(nullable: false),
                    EtudiantEntity_Id = c.Int(),
                    MatiereEntity_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EtudiantEntities", t => t.EtudiantEntity_Id)
                .ForeignKey("dbo.MatiereEntities", t => t.MatiereEntity_Id)
                .Index(t => t.EtudiantEntity_Id)
                .Index(t => t.MatiereEntity_Id);

            CreateTable(
                "dbo.MatiereEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NomMatiere = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.CourMatiereEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IdCours = c.Int(nullable: false),
                    IdMatiere = c.Int(nullable: false),
                    CourEntities_Id = c.Int(),
                    MatiereEntity_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourEntities", t => t.CourEntities_Id)
                .ForeignKey("dbo.MatiereEntities", t => t.MatiereEntity_Id)
                .Index(t => t.CourEntities_Id)
                .Index(t => t.MatiereEntity_Id);

            CreateTable(
                "dbo.CourEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NomCours = c.String(),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ProfesseurMatiereEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IdProfesseur = c.Int(nullable: false),
                    IdMatiere = c.Int(nullable: false),
                    MatiereEntity_Id = c.Int(),
                    ProfesseurEntity_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MatiereEntities", t => t.MatiereEntity_Id)
                .ForeignKey("dbo.ProfesseurEntities", t => t.ProfesseurEntity_Id)
                .Index(t => t.MatiereEntity_Id)
                .Index(t => t.ProfesseurEntity_Id);

            CreateTable(
                "dbo.ProfesseurEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nom = c.String(),
                    Prenom = c.String(),
                    Email = c.String(),
                    Telephone = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.OTPCodesEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IdUtilisateur = c.Int(nullable: false),
                    Code = c.String(),
                    DateExpiration = c.DateTime(nullable: false),
                    UtilisateurEntity_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UtilisateurEntities", t => t.UtilisateurEntity_Id)
                .Index(t => t.UtilisateurEntity_Id);

            CreateTable(
                "dbo.UtilisateurEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NomUtilisateur = c.String(),
                    MotDePasse = c.String(),
                    Role = c.String(),
                    Telephone = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ProfesseurClasseEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IdProfesseur = c.Int(nullable: false),
                    IdClasse = c.Int(nullable: false),
                    ClasseEntity_Id = c.Int(),
                    ProfesseurEntity_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClasseEntities", t => t.ClasseEntity_Id)
                .ForeignKey("dbo.ProfesseurEntities", t => t.ProfesseurEntity_Id)
                .Index(t => t.ClasseEntity_Id)
                .Index(t => t.ProfesseurEntity_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.ProfesseurClasseEntities", "ProfesseurEntity_Id", "dbo.ProfesseurEntities");
            DropForeignKey("dbo.ProfesseurClasseEntities", "ClasseEntity_Id", "dbo.ClasseEntities");
            DropForeignKey("dbo.OTPCodesEntities", "UtilisateurEntity_Id", "dbo.UtilisateurEntities");
            DropForeignKey("dbo.ProfesseurMatiereEntities", "ProfesseurEntity_Id", "dbo.ProfesseurEntities");
            DropForeignKey("dbo.ProfesseurMatiereEntities", "MatiereEntity_Id", "dbo.MatiereEntities");
            DropForeignKey("dbo.NoteEntities", "MatiereEntity_Id", "dbo.MatiereEntities");
            DropForeignKey("dbo.CourMatiereEntities", "MatiereEntity_Id", "dbo.MatiereEntities");
            DropForeignKey("dbo.CourMatiereEntities", "CourEntities_Id", "dbo.CourEntities");
            DropForeignKey("dbo.ClasseCourEntities", "CourEntities_Id", "dbo.CourEntities");
            DropForeignKey("dbo.NoteEntities", "EtudiantEntity_Id", "dbo.EtudiantEntities");
            DropForeignKey("dbo.EtudiantEntities", "ClasseEntity_Id", "dbo.ClasseEntities");
            DropForeignKey("dbo.ClasseCourEntities", "ClasseEntity_Id", "dbo.ClasseEntities");
            DropIndex("dbo.ProfesseurClasseEntities", new[] { "ProfesseurEntity_Id" });
            DropIndex("dbo.ProfesseurClasseEntities", new[] { "ClasseEntity_Id" });
            DropIndex("dbo.OTPCodesEntities", new[] { "UtilisateurEntity_Id" });
            DropIndex("dbo.ProfesseurMatiereEntities", new[] { "ProfesseurEntity_Id" });
            DropIndex("dbo.ProfesseurMatiereEntities", new[] { "MatiereEntity_Id" });
            DropIndex("dbo.CourMatiereEntities", new[] { "MatiereEntity_Id" });
            DropIndex("dbo.CourMatiereEntities", new[] { "CourEntities_Id" });
            DropIndex("dbo.NoteEntities", new[] { "MatiereEntity_Id" });
            DropIndex("dbo.NoteEntities", new[] { "EtudiantEntity_Id" });
            DropIndex("dbo.EtudiantEntities", new[] { "ClasseEntity_Id" });
            DropIndex("dbo.ClasseCourEntities", new[] { "CourEntities_Id" });
            DropIndex("dbo.ClasseCourEntities", new[] { "ClasseEntity_Id" });
            DropTable("dbo.ProfesseurClasseEntities");
            DropTable("dbo.UtilisateurEntities");
            DropTable("dbo.OTPCodesEntities");
            DropTable("dbo.ProfesseurEntities");
            DropTable("dbo.ProfesseurMatiereEntities");
            DropTable("dbo.CourEntities");
            DropTable("dbo.CourMatiereEntities");
            DropTable("dbo.MatiereEntities");
            DropTable("dbo.NoteEntities");
            DropTable("dbo.EtudiantEntities");
            DropTable("dbo.ClasseEntities");
            DropTable("dbo.ClasseCourEntities");
        }
    }
}
