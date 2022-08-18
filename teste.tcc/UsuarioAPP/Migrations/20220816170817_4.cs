using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuarioAPP.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "UsuarioAssistido",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "UsuarioAssistido");

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
    }
}
