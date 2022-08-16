using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace UsuarioAPP.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioAssistido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Cpf = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    Endereco = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAssistido", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "22994ed0-72ea-403e-a51c-26f6b1f6ebc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "34264f18-fafd-49fe-80d8-4b4ef29cccbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "a8d3401e-b5ad-4cf8-b2d0-3066995c8b6b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2891a630-b8ae-418a-a69a-2ba073af81a9", "AQAAAAEAACcQAAAAELR8fK63CfGuVr+hMmhe0UzxqLO6Op1VrZkZks3vyv5b0UExQE7X0lFB4vUilu+4Gg==", "18f47e7f-6b90-4d08-803a-46d5d70ec716" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioAssistido");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "5eed37b2-65f7-4460-8c80-fff26022845b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "1358efae-a655-46c5-8f9c-b6bb4276dbda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "7fa90dcb-e8d9-4150-b27d-e0ab059610ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b18150a8-2ae8-4d3e-9059-9f79662488b1", "AQAAAAEAACcQAAAAEEa+zvHrOJwmMsZtxyc2h0TqhIK7dVoH3o8/+77PI95j3C01WxsCdoE59vcAOPa0cA==", "741e4701-edaa-4d82-885d-39d2b86149af" });
        }
    }
}
