using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.DynamicTable.Migrations
{
    public partial class Init_DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DynamicTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    TableName = table.Column<string>(maxLength: 255, nullable: true),
                    TableProperty = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicTables", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DynamicTables",
                columns: new[] { "Id", "Name", "TableName", "TableProperty" },
                values: new object[] { 1, "Table customer", "Customers", "[{\"Name\":\"Id\",\"Type\":1,\"IsIndentity\":true,\"MaxLenght\":0},{\"Name\":\"Name\",\"Type\":2,\"IsIndentity\":false,\"MaxLenght\":255},{\"Name\":\"Birthday\",\"Type\":3,\"IsIndentity\":false,\"MaxLenght\":0}]" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynamicTables");
        }
    }
}
