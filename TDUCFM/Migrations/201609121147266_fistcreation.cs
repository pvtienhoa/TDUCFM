namespace TDUCFM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fistcreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        DeptCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Long(nullable: false, identity: true),
                        AccountNo = c.String(maxLength: 13),
                        CifNo = c.String(nullable: false, maxLength: 9),
                        Name = c.String(nullable: false, maxLength: 100),
                        CompanyId = c.Long(nullable: false),
                        FolderId = c.Long(nullable: false),
                        DepartmentId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.FileId);
            
            CreateTable(
                "dbo.Folders",
                c => new
                    {
                        FolderId = c.Long(nullable: false, identity: true),
                        FolderCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FolderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserRole = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Folders");
            DropTable("dbo.Files");
            DropTable("dbo.Departments");
            DropTable("dbo.Companies");
        }
    }
}
