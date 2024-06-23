using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelMonolitic.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piso",
                columns: table => new
                {
                    IdPiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalidaConfirmacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrecioInicial = table.Column<int>(type: "int", nullable: false),
                    Adelanto = table.Column<int>(type: "int", nullable: false),
                    PrecioRestante = table.Column<int>(type: "int", nullable: false),
                    TotalPagado = table.Column<int>(type: "int", nullable: false),
                    CostoPenalidad = table.Column<int>(type: "int", nullable: false),
                    CreationUser = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usermod = table.Column<int>(type: "int", nullable: true),
                    UserDeleted = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piso", x => x.IdPiso);
                });

            migrationBuilder.CreateTable(
                name: "RECEPCION",
                columns: table => new
                {
                    IdRecepcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdHabitacion = table.Column<int>(type: "int", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalidaConfirmacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrecioInicial = table.Column<int>(type: "int", nullable: false),
                    Adelanto = table.Column<int>(type: "int", nullable: false),
                    PrecioRestante = table.Column<int>(type: "int", nullable: false),
                    TotalPagado = table.Column<int>(type: "int", nullable: false),
                    CostoPenalidad = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationUser = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usermod = table.Column<int>(type: "int", nullable: true),
                    UserDeleted = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEPCION", x => x.IdRecepcion);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piso");

            migrationBuilder.DropTable(
                name: "RECEPCION");
        }
    }
}
