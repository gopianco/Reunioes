using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reunioes.Repositorio.Migrations
{
    public partial class PopulacoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sala 01" });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sala 02" });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Sala 03" });

            migrationBuilder.InsertData(
                table: "Reunioes",
                columns: new[] { "ReuniaoId", "DataHoraFim", "DataHoraInicio", "SalaId", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 9, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 9, 16, 20, 0, 0, DateTimeKind.Unspecified), 1, "Reunião Diretoria Financeira" },
                    { 3, new DateTime(2020, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Reunião Diretoria Financeira" },
                    { 4, new DateTime(2020, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, "Reunião Diretoria Financeira" },
                    { 2, new DateTime(2020, 7, 9, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 9, 16, 20, 0, 0, DateTimeKind.Unspecified), 2, "Reunião Diretoria Financeira" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reunioes",
                keyColumn: "ReuniaoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reunioes",
                keyColumn: "ReuniaoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reunioes",
                keyColumn: "ReuniaoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reunioes",
                keyColumn: "ReuniaoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
