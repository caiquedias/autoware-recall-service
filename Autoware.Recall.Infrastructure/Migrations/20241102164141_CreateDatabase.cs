using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoware.Recall.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region Create Tables
            migrationBuilder.CreateTable(
                name: "Chassi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoChassi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChassiRecall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecallId = table.Column<int>(type: "int", nullable: false),
                    ChassiId = table.Column<int>(type: "int", nullable: false),
                    DataExecucao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Concessionaria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChassiRecall", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChassiRecall_Chassi_ChassiId",
                        column: x => x.ChassiId,
                        principalTable: "Chassi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChassiRecall_Recall_RecallId",
                        column: x => x.RecallId,
                        principalTable: "Recall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChassiRecall_ChassiId",
                table: "ChassiRecall",
                column: "ChassiId");

            migrationBuilder.CreateIndex(
                name: "IX_ChassiRecall_RecallId",
                table: "ChassiRecall",
                column: "RecallId");
            #endregion Create Tables

            #region Create Chassi Default Data
            migrationBuilder.InsertData(
                table: "Chassi",
                columns: ["Id", "CodigoChassi"],
                values: [1, "YV1SZ58D911234567"]
            );

            migrationBuilder.InsertData(
                table: "Chassi",
                columns: ["Id", "CodigoChassi"],
                values: [2, "1HGCM82633A123456"]
            );

            migrationBuilder.InsertData(
                table: "Chassi",
                columns: ["Id", "CodigoChassi"],
                values: [3, "JH4KA8270PC000001"]
            );
            #endregion Create Chassi Default Data

            #region Create Recall Default Data
            migrationBuilder.InsertData(
                table: "Recall",
                columns: ["Id", "Titulo", "Descricao", "DataPublicacao"],
                values: [1, "TROCA DISCO FREIO", "Poderá resultar em ruídos anormais e deficiência na frenagem.", "2023-10-29T00:00:00"]
            );

            migrationBuilder.InsertData(
                table: "Recall",
                columns: ["Id", "Titulo", "Descricao", "DataPublicacao"],
                values: [2, "ATUALIZAÇÃO DE SOFTWARE", "Poderá resultar em funcionamento incorreto do monitoramento dos sensores.", "2019-04-01T00:00:00"]
            );

            migrationBuilder.InsertData(
                table: "Recall",
                columns: ["Id", "Titulo", "Descricao", "DataPublicacao"],
                values: [3, "INSPEÇÃO SISTEMA DE PARTIDA", "Poderá resultar em funcionamento incorreto na partida do veículo.", "2021-01-30T00:00:00"]
            );

            migrationBuilder.InsertData(
                table: "Recall",
                columns: ["Id", "Titulo", "Descricao", "DataPublicacao"],
                values: [4, "CORROSÃO CABO DO ACELERADOR", "Poderá resultar em quebra no cabo, impedindo a acelaração do veículo.", "2020-03-15T00:00:00"]
            );

            migrationBuilder.InsertData(
                table: "Recall",
                columns: ["Id", "Titulo", "Descricao", "DataPublicacao"],
                values: [5, "SUBSTITUIÇÃO SENSOR DO VELOCÍMETRO", "Poderá resultar em registro incorreto da quilometragem.", "2014-07-10T00:00:00"]
            );
            #endregion Create Recall Default Data

            #region Create ChassiRecall Default Data

            #region chassi-YV1SZ58D911234567
            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [1, 1, 1, null, null]
            );

            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [2, 3, 1, null, null]
            );

            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [3, 2, 1, null, null]
            );
            #endregion chassi-YV1SZ58D911234567

            #region chassi-1HGCM82633A123456
            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [4, 2, 2, "2020-03-25T00:00:00", "Velocity Auto Group"]
            );

            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [5, 5, 2, "2016-10-07T00:00:00", "Velocity Auto Group"]
            );
            #endregion chassi-1HGCM82633A123456

            #region chassi-JH4KA8270PC000001
            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [6, 1, 3, null, null]
            );

            migrationBuilder.InsertData(
                table: "ChassiRecall",
                columns: ["Id", "RecallId", "ChassiId", "DataExecucao", "Concessionaria"],
                values: [7, 4, 3, "2024-05-01T00:00:00", "Horizon Motors"]
            );
            #endregion chassi-JH4KA8270PC000001

            #endregion Create ChassiRecall Default Data
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChassiRecall");

            migrationBuilder.DropTable(
                name: "Chassi");

            migrationBuilder.DropTable(
                name: "Recall");
        }
    }
}
