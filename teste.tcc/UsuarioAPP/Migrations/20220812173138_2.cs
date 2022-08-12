using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuarioAPP.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Usuario");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "ce6f2051-b461-453d-a091-731e6601098e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "608089e6-45bc-44c6-8a2a-55509be72d85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "cba2a17b-06ba-4d2a-9643-f3c5f4b18344");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb685408-241c-4a6a-a459-ef6f78adb15e", "AQAAAAEAACcQAAAAEGwqycDBNYd+1GhFpQ/FrC/YfGGIWsgOooud9YbEn5U6K7AS1hT26hMWHgXeuzvmHQ==", "c8d71739-038b-47d0-bdbf-8b11b074138b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9996,
                column: "ConcurrencyStamp",
                value: "4a1d306d-3221-4b2d-80e5-3af973881ceb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997,
                column: "ConcurrencyStamp",
                value: "063dab63-306f-43dd-abfd-3b49d2d0615e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "b120e8ba-6fe2-4bf7-9634-f3c2d1917f37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3be30a0f-1e1b-4626-b6d3-8b2fa7e17817", "AQAAAAEAACcQAAAAEG3Rgm1OQqWbvg8pLVHGjEDMIpGrN/shsGzh+cu/qFMMRaYXI4FpjXGH+EDUUphtog==", "9726947e-33c1-4f4d-aaff-a2012a465b84" });
        }
    }
}
