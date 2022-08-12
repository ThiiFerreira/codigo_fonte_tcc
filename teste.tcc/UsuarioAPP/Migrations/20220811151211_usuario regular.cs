using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuarioAPP.Migrations
{
    public partial class usuarioregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "d8ea390b-7aef-40d3-acc0-6a8665a3c574");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 9997, "dd9fd79c-0c8b-4dfc-9a0d-005a6aa71b94", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b676ea-2487-4c9d-b465-0b7aa5434383", "AQAAAAEAACcQAAAAEL3GGEKUvin1zGhNnlRVOltdb+xSyGZdboRV/Vw3hsylGyFnS/TyIeHZdtsdtzTb2g==", "d804d878-7bac-482a-8364-0f9fb1fc002f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "27901fc2-46fc-4ba9-adf3-b13ad0b3248e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "110ca172-ae53-4f78-b1ff-5b0234efed05", "AQAAAAEAACcQAAAAEPH6yeYJe0MBqn8Q6h6TKP3p6coQTVLbkAhcq75UrNMqySTRA4fTGDw/qgTaw5gHgw==", "ed1dd348-3120-47c1-b640-edf673a6ca05" });
        }
    }
}
