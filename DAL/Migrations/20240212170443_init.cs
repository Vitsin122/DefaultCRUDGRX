using Microsoft.EntityFrameworkCore.Migrations;

namespace DefaultCRUDGRX.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status_Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.id);
                    table.UniqueConstraint("AK_Statuses_Status_Name", x => x.Status_Name);
                });

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.id);
                    table.UniqueConstraint("AK_ToDos_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_ToDos_Statuses_Status_ID",
                        column: x => x.Status_ID,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "id", "Status_Name" },
                values: new object[] { 1, "Создана" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "id", "Status_Name" },
                values: new object[] { 2, "В работе" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "id", "Status_Name" },
                values: new object[] { 3, "Завершена" });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_Status_ID",
                table: "ToDos",
                column: "Status_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
