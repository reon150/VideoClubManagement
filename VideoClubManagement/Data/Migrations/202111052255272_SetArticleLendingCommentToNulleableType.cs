namespace VideoClubManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetArticleLendingCommentToNulleableType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ArticleLendings", "Comment", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ArticleLendings", "Comment", c => c.String(nullable: false, maxLength: 1000));
        }
    }
}
