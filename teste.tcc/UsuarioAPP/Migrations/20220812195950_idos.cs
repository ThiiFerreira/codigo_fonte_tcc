using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuarioAPP.Migrations
{
    public partial class idos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
