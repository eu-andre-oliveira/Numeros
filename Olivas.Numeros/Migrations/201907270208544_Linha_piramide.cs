namespace Olivas.Numeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Linha_piramide : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "PrimeiraLinhaPiramide", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "PrimeiraLinhaPiramide");
        }
    }
}
