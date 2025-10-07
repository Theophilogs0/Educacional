using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class porfavorfuncione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Departamentos_DepartamentoId",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.RenameIndex(
                name: "IX_Departamentos_InstituicaoId",
                table: "Departamento",
                newName: "IX_Departamento_InstituicaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Departamento_DepartamentoId",
                table: "Curso",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Instituicoes_InstituicaoId",
                table: "Departamento",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "InstituicaoID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Departamento_DepartamentoId",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Instituicoes_InstituicaoId",
                table: "Departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.RenameIndex(
                name: "IX_Departamento_InstituicaoId",
                table: "Departamentos",
                newName: "IX_Departamentos_InstituicaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Departamentos_DepartamentoId",
                table: "Curso",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoId",
                table: "Departamentos",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "InstituicaoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
