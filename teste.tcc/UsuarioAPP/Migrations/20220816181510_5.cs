using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace UsuarioAPP.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    DataInicio = table.Column<string>(type: "text", nullable: true),
                    DataFinal = table.Column<string>(type: "text", nullable: true),
                    ResponsavelId = table.Column<int>(type: "int", nullable: false),
                    IdosoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "4b953e0c-f5ab-474e-ba64-8b6af98ea74b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "b85a30c9-3841-4e6d-a9a8-eaaa9d128f8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "a476db93-1416-43a0-9176-f2fa8ac284c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "126bac06-a5b1-4e14-85da-9d29181e6e86", "AQAAAAEAACcQAAAAELz65rEuBNHRj8/wudKhBUOECzXwKaeFXnH9RYaKFDH6TQBBUZ5ZswATwRMMkCAPAg==", "9fdb9b2a-8f81-4706-89a9-1634dc54b12e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "243a1007-c41e-4536-8f44-e2a9a96e8f9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "ba87e536-1192-4683-8352-3e0063b8fdf9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "b29e559c-bfa9-452f-b82f-ea18ec0912ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58b261ab-1741-40f3-9917-4670deceb4a1", "AQAAAAEAACcQAAAAEGVxWg0haejZjUm7hTi8dUjvEAheSjzDjhitjKMAdWsmqsUdQgppXcRXxLwJ/O0xYg==", "e4db26ea-0e30-44eb-b404-50521dcbf91d" });
        }
    }
}
