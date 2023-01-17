namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            RenameTable(name: "dbo.Profesors", newName: "Docente");
            RenameColumn(table: "dbo.Docente", name: "ProfesorId", newName: "Id");
            AlterColumn("dbo.Alumno", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Docente", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Docente", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Docente", "Apellido", c => c.String());
            AlterColumn("dbo.Docente", "Nombre", c => c.String());
            AlterColumn("dbo.Alumno", "Apellido", c => c.String());
            AlterColumn("dbo.Alumno", "Nombre", c => c.String());
            RenameColumn(table: "dbo.Docente", name: "Id", newName: "ProfesorId");
            RenameTable(name: "dbo.Docente", newName: "Profesors");
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
