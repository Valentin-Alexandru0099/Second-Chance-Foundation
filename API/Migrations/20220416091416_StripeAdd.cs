using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class StripeAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f9df7e3-1fe6-433e-ae20-c14f0b7089cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdaac094-90e0-4fce-96db-8c15c6253df3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0860e48e-6b86-4c53-b8ce-bc823f457381", "c7cba22f-6ceb-4594-8b97-df9fd1fd5320", "Admin", "ADMIN" },
                    { "62d9d6d6-628b-42bc-974b-a5d81c6044f8", "626e5b43-0837-4869-aa59-373e4a242edc", "Member", "MEMBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0860e48e-6b86-4c53-b8ce-bc823f457381");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62d9d6d6-628b-42bc-974b-a5d81c6044f8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f9df7e3-1fe6-433e-ae20-c14f0b7089cd", "c1845e74-42f9-492f-9bac-bd8d82bc9f25", "Admin", "ADMIN" },
                    { "cdaac094-90e0-4fce-96db-8c15c6253df3", "d46f1d4b-ce07-4fdf-8ac2-3934e362315b", "Member", "MEMBER" }
                });
        }
    }
}
