namespace AvaliacaoUsuarios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvaliationUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avaliations", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Avaliations", "UserId");
        }
    }
}
