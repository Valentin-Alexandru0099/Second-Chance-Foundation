using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class PostPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b30ddcae-5891-47aa-a422-4b25dc732fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1db409a-8eb9-4539-85a0-cf8bc26913e0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a3e1a2bf-61dc-42f6-bbed-c48269d92c86", "b0c6c3bf-eedb-46e9-917b-73b5a38dfc38", "Member", "MEMBER" },
                    { "ec1b4e20-4f03-4746-b3c1-35427a6635ce", "8bfad3ea-544b-4ff8-a7de-5d42a1683bc0", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3e1a2bf-61dc-42f6-bbed-c48269d92c86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec1b4e20-4f03-4746-b3c1-35427a6635ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b30ddcae-5891-47aa-a422-4b25dc732fe0", "1a94c663-6932-43bb-8a2e-1dc617f1357f", "Member", "MEMBER" },
                    { "e1db409a-8eb9-4539-85a0-cf8bc26913e0", "a24a70cc-4fd1-4c6b-936a-9502512219e3", "Admin", "ADMIN" }
                });
        }
    }
}
