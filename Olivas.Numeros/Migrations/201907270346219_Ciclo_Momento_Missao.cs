namespace Olivas.Numeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ciclo_Momento_Missao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "NumeroDestino", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Numero1Ciclo", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Numero2Ciclo", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Numero3Ciclo", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroMomento1", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroMomento2", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroMomento3", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroMomento4", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "NumeroMissao", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "NumeroDesafio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "NumeroDesafio", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "NumeroMissao");
            DropColumn("dbo.Clientes", "NumeroMomento4");
            DropColumn("dbo.Clientes", "NumeroMomento3");
            DropColumn("dbo.Clientes", "NumeroMomento2");
            DropColumn("dbo.Clientes", "NumeroMomento1");
            DropColumn("dbo.Clientes", "Numero3Ciclo");
            DropColumn("dbo.Clientes", "Numero2Ciclo");
            DropColumn("dbo.Clientes", "Numero1Ciclo");
            DropColumn("dbo.Clientes", "NumeroDestino");
        }
    }
}
