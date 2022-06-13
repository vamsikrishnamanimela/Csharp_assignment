namespace MVC_movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false, identity: true),
                        Movie_Name = c.String(),
                        Release_Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movie");
        }
    }
}
