using System;
using System.Data.Entity.Migrations;
namespace _HOL3.Migrations



{


    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
            "dbo.Users",

            c => new
            {

                UserName = c.String(nullable: false, maxLength: 128),
                Password = c.String(),
            })
                    .PrimaryKey(t => t.UserName);

        }

        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}

            