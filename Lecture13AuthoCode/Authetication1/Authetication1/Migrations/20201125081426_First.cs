using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Authetication1.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RegisterModels",
                columns: new[] { "Id", "ConPassword", "Name", "Password" },
                values: new object[] { 1, null, "Admin", "password" });

            migrationBuilder.InsertData(
                table: "RegisterModels",
                columns: new[] { "Id", "ConPassword", "Name", "Password" },
                values: new object[] { 2, null, "Shamim", "shamim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterModels");
        }
    }
}
