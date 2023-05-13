using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScladCRUD.Migrations
{
    public partial class catalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "articul",
                table: "catalog1");

            migrationBuilder.DropColumn(
                name: "product_name",
                table: "catalog1");

            migrationBuilder.DropColumn(
                name: "product_pic",
                table: "catalog1");

            migrationBuilder.AlterColumn<int>(
                name: "margin",
                table: "product1",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(2,2)",
                oldPrecision: 2,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "cost",
                table: "product1",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9,2)",
                oldPrecision: 9,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "catalog1",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9,2)",
                oldPrecision: 9,
                oldScale: 2);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "catalog1",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "catalog1");

            migrationBuilder.AlterColumn<decimal>(
                name: "margin",
                table: "product1",
                type: "numeric(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "cost",
                table: "product1",
                type: "numeric(9,2)",
                precision: 9,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "catalog1",
                type: "numeric(9,2)",
                precision: 9,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "articul",
                table: "catalog1",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_name",
                table: "catalog1",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_pic",
                table: "catalog1",
                type: "character varying(900)",
                maxLength: 900,
                nullable: true);
        }
    }
}
