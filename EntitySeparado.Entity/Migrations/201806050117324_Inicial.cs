namespace EntitySeparado.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 200),
                        Sexo = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
