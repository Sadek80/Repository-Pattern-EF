namespace RepositoryPattern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityConfigurations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CourseTags");
            RenameColumn(table: "dbo.CourseTags", name: "Tag_TagID", newName: "TagId");
            RenameColumn(table: "dbo.CourseTags", name: "Course_CourseID", newName: "CourseId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_Course_CourseID", newName: "IX_CourseId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_Tag_TagID", newName: "IX_TagId");
            DropPrimaryKey("dbo.CourseTags");
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false, maxLength: 255));
            AddPrimaryKey("dbo.CourseTags", new[] { "CourseId", "TagId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CourseTags");
            AlterColumn("dbo.Tags", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
            AddPrimaryKey("dbo.CourseTags", new[] { "Tag_TagID", "Course_CourseID" });
            RenameIndex(table: "dbo.CourseTags", name: "IX_TagId", newName: "IX_Tag_TagID");
            RenameIndex(table: "dbo.CourseTags", name: "IX_CourseId", newName: "IX_Course_CourseID");
            RenameColumn(table: "dbo.CourseTags", name: "CourseId", newName: "Course_CourseID");
            RenameColumn(table: "dbo.CourseTags", name: "TagId", newName: "Tag_TagID");
            RenameTable(name: "dbo.CourseTags", newName: "TagCourses");
        }
    }
}
