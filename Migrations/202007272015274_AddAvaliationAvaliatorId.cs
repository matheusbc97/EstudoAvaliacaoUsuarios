namespace AvaliacaoUsuarios.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddAvaliationAvaliatorId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avaliations", "AvaliatorId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Avaliations", "AvaliatorId");
        }
    }
}
