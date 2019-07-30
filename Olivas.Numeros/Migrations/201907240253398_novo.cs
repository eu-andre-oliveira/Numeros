namespace Olivas.Numeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "DataAtualizacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clientes", "Desafio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Desafio");
            DropColumn("dbo.Clientes", "DataAtualizacao");
        }
    }
}
