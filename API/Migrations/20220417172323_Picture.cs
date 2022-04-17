using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0860e48e-6b86-4c53-b8ce-bc823f457381");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62d9d6d6-628b-42bc-974b-a5d81c6044f8");

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
                    { "b30ddcae-5891-47aa-a422-4b25dc732fe0", "1a94c663-6932-43bb-8a2e-1dc617f1357f", "Member", "MEMBER" },
                    { "e1db409a-8eb9-4539-85a0-cf8bc26913e0", "a24a70cc-4fd1-4c6b-936a-9502512219e3", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b30ddcae-5891-47aa-a422-4b25dc732fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1db409a-8eb9-4539-85a0-cf8bc26913e0");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0860e48e-6b86-4c53-b8ce-bc823f457381", "c7cba22f-6ceb-4594-8b97-df9fd1fd5320", "Admin", "ADMIN" },
                    { "62d9d6d6-628b-42bc-974b-a5d81c6044f8", "626e5b43-0837-4869-aa59-373e4a242edc", "Member", "MEMBER" }
                });
        }
    }
}
