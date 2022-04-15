using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Organizations_OrganizationId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b572cd2-bb07-44d5-8857-a38469ee466a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee76f4e7-0b55-4e11-83d9-6385c425bf89");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Jobs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45358e8a-7820-48f0-a689-1ba406c5844b", "1773bd14-c225-48a9-a4d7-62ef0e13a4e5", "Member", "MEMBER" },
                    { "b6001d35-3f59-4743-a24a-3cd362643066", "e163abb5-0d66-4123-a883-0a914ea37093", "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Organizations_OrganizationId",
                table: "Jobs",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Organizations_OrganizationId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45358e8a-7820-48f0-a689-1ba406c5844b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6001d35-3f59-4743-a24a-3cd362643066");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Jobs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b572cd2-bb07-44d5-8857-a38469ee466a", "b7ac871f-4c22-4069-aee7-30267bc23243", "Member", "MEMBER" },
                    { "ee76f4e7-0b55-4e11-83d9-6385c425bf89", "44313fa1-8ec2-4d90-ab6b-808197d9ea5b", "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Organizations_OrganizationId",
                table: "Jobs",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id");
        }
    }
}
