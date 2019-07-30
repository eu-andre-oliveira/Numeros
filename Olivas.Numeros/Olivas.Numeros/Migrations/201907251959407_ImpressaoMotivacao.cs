namespace Olivas.Numeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImpressaoMotivacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "NumeroDesafio", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroExpressao", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroImpressao", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroMotivacao", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "Desafio");
            //DropColumn("dbo.Clientes", "Expressão");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Expressão", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Desafio", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "NumeroMotivacao");
            DropColumn("dbo.Clientes", "NumeroImpressao");
            DropColumn("dbo.Clientes", "NumeroExpressao");
            DropColumn("dbo.Clientes", "NumeroDesafio");
        }
    }
}
