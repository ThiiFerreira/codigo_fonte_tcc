using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class atualizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataInicio",
                table: "Tarefa",
                newName: "DataDeExecucao");

            migrationBuilder.RenameColumn(
                name: "DataFinal",
                table: "Tarefa",
                newName: "DataDeCriacao");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "0ab28e62-0529-4aab-a3a1-4e83b71562f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "cf35ae9d-4782-4999-83ec-c212802ce301");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "f2b8a431-5b03-4786-bdc8-c64d8dd8dff5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1754e33f-6922-408e-aa68-60fbf6781651", "AQAAAAEAACcQAAAAEPL+MfdpIoslrQoa5WsM6L3fsCFt6h0cg3pmM9t6F71OBzhfO3DcR4UcaabM5MUNLA==", "48592bf7-d7ac-401c-980d-9dcc629c201b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDeExecucao",
                table: "Tarefa",
                newName: "DataInicio");

            migrationBuilder.RenameColumn(
                name: "DataDeCriacao",
                table: "Tarefa",
                newName: "DataFinal");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "a47a6928-d7d9-4f46-b348-4802a680a08d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "272fe04a-6e89-4b86-8983-5e9c25fb6acd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "dfd475d2-52e9-429c-8891-e2e484a4e621");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdda6760-9ef6-4cce-a263-7abd0772b35f", "AQAAAAEAACcQAAAAEFRmKs4/KsDzOSrbUHXCehARv1x5JgW6lcws1oEpZiiV0ymDKM/1K16SBr1QHaUy5g==", "94a14ace-911f-4cf6-8c14-a2e55798a4c5" });
        }
    }
}
