using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_agecat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeCategoryID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AgeCategories",
                columns: table => new
                {
                    AgeCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeCategoryNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeCategories", x => x.AgeCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AgeCategoryID",
                table: "Contacts",
                column: "AgeCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AgeCategories_AgeCategoryID",
                table: "Contacts",
                column: "AgeCategoryID",
                principalTable: "AgeCategories",
                principalColumn: "AgeCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AgeCategories_AgeCategoryID",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "AgeCategories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AgeCategoryID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AgeCategoryID",
                table: "Contacts");
        }
    }
}
