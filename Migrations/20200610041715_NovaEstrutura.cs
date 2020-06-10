using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteCrud.Migrations
{
    public partial class NovaEstrutura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_EnderecoId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Fornecedor");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Fornecedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Fornecedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Fornecedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Fornecedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Fornecedor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Fornecedor");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Fornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Cidade = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Estado = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Numero = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PontoReferencia = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Rua = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_EnderecoId",
                table: "Fornecedor",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
