using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteCrud.Migrations
{
    public partial class EntidadesForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Fornecedor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Fornecedor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
