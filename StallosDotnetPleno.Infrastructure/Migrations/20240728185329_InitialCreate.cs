using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StallosDotnetPleno.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ENDERECO",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LOGRADOURO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NUMERO = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    BAIRRO = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    CIDADE = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PESSOA",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DOCUMENTO = table.Column<string>(type: "varchar(31)", unicode: false, maxLength: 31, nullable: false),
                    ID_TIPO_PESSOA = table.Column<byte>(type: "tinyint", nullable: false),
                    TipoPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PESSOA", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_TB_PESSOA_DOCUMENTO",
                table: "TB_PESSOA",
                column: "DOCUMENTO",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ENDERECO");

            migrationBuilder.DropTable(
                name: "TB_PESSOA");
        }
    }
}
