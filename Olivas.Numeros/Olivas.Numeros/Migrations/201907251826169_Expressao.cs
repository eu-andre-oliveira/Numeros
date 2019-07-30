namespace Olivas.Numeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expressao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Expressao", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Expressao");
        }
    }
}
