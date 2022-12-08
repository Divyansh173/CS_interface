using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreProgramFirst.Migrations
{
    public partial class final1migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PateintCount = table.Column<int>(type: "int", nullable: true),
                    RoomCount = table.Column<int>(type: "int", nullable: true),
                    MachineCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "staffs",
                columns: new[] { "Id", "Discriminator", "Name", "PateintCount", "specialization" },
                values: new object[,]
                {
                    { 1, "Doctor", "Divyansh", 10, "Cancer" },
                    { 2, "Doctor", "JayPrateek", 20, "Heart" }
                });

            migrationBuilder.InsertData(
                table: "staffs",
                columns: new[] { "Id", "Discriminator", "Name", "RoomCount", "specialization" },
                values: new object[,]
                {
                    { 3, "Nurse", "Pranjali", 10, "Cancer" },
                    { 4, "Nurse", "divyanshi", 20, "Heart" }
                });

            migrationBuilder.InsertData(
                table: "staffs",
                columns: new[] { "Id", "Discriminator", "MachineCount", "Name", "specialization" },
                values: new object[,]
                {
                    { 5, "Wardboy", 10, "Subhankar", "Cancer" },
                    { 6, "Wardboy", 20, "Ankita", "Heart" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staffs");
        }
    }
}
