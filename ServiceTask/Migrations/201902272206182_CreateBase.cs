namespace ServiceTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descricao = c.String(),
                        Criacao = c.DateTime(nullable: false),
                        Edicao = c.DateTime(nullable: false),
                        Remocao = c.DateTime(nullable: false),
                        Conclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
