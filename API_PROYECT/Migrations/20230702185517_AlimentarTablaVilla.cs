using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIPROYECT.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa", new DateTime(2023, 7, 2, 12, 55, 16, 948, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 7, 2, 12, 55, 16, 948, DateTimeKind.Local).AddTicks(7914), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa", new DateTime(2023, 7, 2, 12, 55, 16, 948, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 7, 2, 12, 55, 16, 948, DateTimeKind.Local).AddTicks(7944), "", 80, "Villa vista a la playa", 4, 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
