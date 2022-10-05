using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Note.DAL.Migrations
{
    public partial class firstMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_Notice",
                columns: table => new
                {
                    NoticeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTitle = table.Column<string>(nullable: false),
                    NoticeContents = table.Column<string>(nullable: false),
                    NoticeTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Notice", x => x.NoticeNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_Notice");
        }
    }
}
