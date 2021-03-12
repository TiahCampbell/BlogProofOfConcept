using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class ImagesAndColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Contents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Contents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "Images/Fitness.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "Images/Nutrition.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "Images/Pets.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "Images/Family.jpg");

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Blue" },
                    { 2, "Green" },
                    { 3, "Yellow" },
                    { 4, "Orange" },
                    { 5, "Red" },
                    { 6, "Pink" },
                    { 7, "Purple" }
                });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "Image" },
                values: new object[] { 1, "Images/Strong.jpg" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "Image" },
                values: new object[] { 1, "Images/Nutrition.jpg" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "Image" },
                values: new object[] { 1, "Images/Thief.jpg" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColorId", "Image" },
                values: new object[] { 1, "Images/Crawling.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ColorId",
                table: "Contents",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Color_ColorId",
                table: "Contents",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Color_ColorId",
                table: "Contents");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ColorId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");
        }
    }
}
