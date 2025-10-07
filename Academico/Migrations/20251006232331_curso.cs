using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class curso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departamentos_Instituicoes_InstituicaoId",
                table: "departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departamentos",
                table: "departamentos");

            migrationBuilder.RenameTable(
                name: "departamentos",
                newName: "Departamentos");

            migrationBuilder.RenameIndex(
                name: "IX_departamentos_InstituicaoId",
                table: "Departamentos",
                newName: "IX_Departamentos_InstituicaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Cursoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Cursoid);
                    table.ForeignKey(
                        name: "FK_Curso_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_DepartamentoId",
                table: "Curso",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoId",
                table: "Departamentos",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "InstituicaoID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "departamentos");

            migrationBuilder.RenameIndex(
                name: "IX_Departamentos_InstituicaoId",
                table: "departamentos",
                newName: "IX_departamentos_InstituicaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departamentos",
                table: "departamentos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departamentos_Instituicoes_InstituicaoId",
                table: "departamentos",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "InstituicaoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
