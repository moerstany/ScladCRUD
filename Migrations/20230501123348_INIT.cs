using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ScladCRUD.Migrations
{
    public partial class INIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:btree_gin", ",,")
                .Annotation("Npgsql:PostgresExtension:btree_gist", ",,")
                .Annotation("Npgsql:PostgresExtension:citext", ",,")
                .Annotation("Npgsql:PostgresExtension:cube", ",,")
                .Annotation("Npgsql:PostgresExtension:dblink", ",,")
                .Annotation("Npgsql:PostgresExtension:dict_int", ",,")
                .Annotation("Npgsql:PostgresExtension:dict_xsyn", ",,")
                .Annotation("Npgsql:PostgresExtension:earthdistance", ",,")
                .Annotation("Npgsql:PostgresExtension:fuzzystrmatch", ",,")
                .Annotation("Npgsql:PostgresExtension:hstore", ",,")
                .Annotation("Npgsql:PostgresExtension:intarray", ",,")
                .Annotation("Npgsql:PostgresExtension:ltree", ",,")
                .Annotation("Npgsql:PostgresExtension:pg_stat_statements", ",,")
                .Annotation("Npgsql:PostgresExtension:pg_trgm", ",,")
                .Annotation("Npgsql:PostgresExtension:pgcrypto", ",,")
                .Annotation("Npgsql:PostgresExtension:pgrowlocks", ",,")
                .Annotation("Npgsql:PostgresExtension:pgstattuple", ",,")
                .Annotation("Npgsql:PostgresExtension:tablefunc", ",,")
                .Annotation("Npgsql:PostgresExtension:unaccent", ",,")
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .Annotation("Npgsql:PostgresExtension:xml2", ",,");

            migrationBuilder.CreateTable(
                name: "client1",
                columns: table => new
                {
                    id_client = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    client_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    post = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    tel = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    parol = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    avatar = table.Column<string>(type: "character varying(900)", maxLength: 900, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("client1_pkey", x => x.id_client);
                });

            migrationBuilder.CreateTable(
                name: "manager1",
                columns: table => new
                {
                    id_manager = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    manager_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    post = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    tel = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    parol = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    avatar = table.Column<string>(type: "character varying(900)", maxLength: 900, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("manager1_pkey", x => x.id_manager);
                });

            migrationBuilder.CreateTable(
                name: "product1",
                columns: table => new
                {
                    id_product = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    product_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    articul = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    cost = table.Column<decimal>(type: "numeric(9,2)", precision: 9, scale: 2, nullable: false),
                    product_pic = table.Column<string>(type: "character varying(900)", maxLength: 900, nullable: true),
                    margin = table.Column<decimal>(type: "numeric(2,2)", precision: 2, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("product1_pkey", x => x.id_product);
                });

            migrationBuilder.CreateTable(
                name: "catalog1",
                columns: table => new
                {
                    id_catalog = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_product = table.Column<int>(type: "integer", nullable: true),
                    product_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    articul = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "numeric(9,2)", precision: 9, scale: 2, nullable: false),
                    product_pic = table.Column<string>(type: "character varying(900)", maxLength: 900, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("catalog1_pkey", x => x.id_catalog);
                    table.ForeignKey(
                        name: "catalog1_id_product_fkey",
                        column: x => x.id_product,
                        principalTable: "product1",
                        principalColumn: "id_product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order1",
                columns: table => new
                {
                    id_order = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_product = table.Column<int>(type: "integer", nullable: true),
                    id_client = table.Column<int>(type: "integer", nullable: true),
                    client_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    product_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    articul = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    qantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order1_pkey", x => x.id_order);
                    table.ForeignKey(
                        name: "order1_id_client_fkey",
                        column: x => x.id_client,
                        principalTable: "client1",
                        principalColumn: "id_client",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "order1_id_product_fkey",
                        column: x => x.id_product,
                        principalTable: "product1",
                        principalColumn: "id_product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_catalog1_id_product",
                table: "catalog1",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_order1_id_client",
                table: "order1",
                column: "id_client");

            migrationBuilder.CreateIndex(
                name: "IX_order1_id_product",
                table: "order1",
                column: "id_product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalog1");

            migrationBuilder.DropTable(
                name: "manager1");

            migrationBuilder.DropTable(
                name: "order1");

            migrationBuilder.DropTable(
                name: "client1");

            migrationBuilder.DropTable(
                name: "product1");
        }
    }
}
