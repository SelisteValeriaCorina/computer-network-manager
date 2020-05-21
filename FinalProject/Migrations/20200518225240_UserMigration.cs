using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class UserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Right",
                columns: table => new
                {
                    RightName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Right", x => x.RightName);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    AgeRestricted = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RightName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Group_Right_RightName",
                        column: x => x.RightName,
                        principalTable: "Right",
                        principalColumn: "RightName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "utilizatori",
                columns: table => new
                {
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    groupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utilizatori", x => x.LastName);
                    table.ForeignKey(
                        name: "FK_utilizatori_Group_groupName",
                        column: x => x.groupName,
                        principalTable: "Group",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_RightName",
                table: "Group",
                column: "RightName");

            migrationBuilder.CreateIndex(
                name: "IX_utilizatori_groupName",
                table: "utilizatori",
                column: "groupName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "utilizatori");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Right");
        }
    }
}
