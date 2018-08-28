namespace aspmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMovieGenreModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.String());
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
