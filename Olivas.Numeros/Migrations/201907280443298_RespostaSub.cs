namespace Olivas.Numeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RespostaSub : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "NumeroRespostaSubconsciente", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "NumeroRespostaSubconsciente");
        }
    }
}
