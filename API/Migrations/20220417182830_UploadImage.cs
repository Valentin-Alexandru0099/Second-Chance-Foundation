using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class UploadImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3e1a2bf-61dc-42f6-bbed-c48269d92c86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec1b4e20-4f03-4746-b3c1-35427a6635ce");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7260bea0-3d1e-42c0-958b-72a6cce67138", "6dca0a2e-b689-4890-877b-6ea82f34d503", "Member", "MEMBER" },
                    { "be089a57-9d60-425f-a34b-51aea0c1c48a", "204466b6-a129-409b-a9e0-19201f7e2fad", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7260bea0-3d1e-42c0-958b-72a6cce67138");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be089a57-9d60-425f-a34b-51aea0c1c48a");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a3e1a2bf-61dc-42f6-bbed-c48269d92c86", "b0c6c3bf-eedb-46e9-917b-73b5a38dfc38", "Member", "MEMBER" },
                    { "ec1b4e20-4f03-4746-b3c1-35427a6635ce", "8bfad3ea-544b-4ff8-a7de-5d42a1683bc0", "Admin", "ADMIN" }
                });
        }
    }
}
