using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewLearning.Migrations
{
    public partial class UserInterveiwPrep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "Email", "Password", "UserName" },
                values: new object[] { 1, "soni@abhi.com", "monusoni", "SoniSingh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
