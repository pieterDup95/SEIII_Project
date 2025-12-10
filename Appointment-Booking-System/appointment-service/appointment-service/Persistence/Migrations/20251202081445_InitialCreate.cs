using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appointment_service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "appointment_service");

            migrationBuilder.CreateTable(
                name: "appointment_request",
                schema: "appointment_service",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    reference_number = table.Column<string>(type: "text", nullable: false),
                    branch_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    time = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_request", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "branch",
                schema: "appointment_service",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    branch_name = table.Column<string>(type: "text", nullable: false),
                    branch_code = table.Column<int>(type: "integer", nullable: false),
                    provice = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    suburb = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    contact_number = table.Column<string>(type: "text", nullable: false),
                    slot_per_hour = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_branch", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_info",
                schema: "appointment_service",
                columns: table => new
                {
                    appointment_request_id = table.Column<Guid>(type: "uuid", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    id_number = table.Column<string>(type: "text", nullable: false),
                    contact_number = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_customer_info", x => x.appointment_request_id);
                    table.ForeignKey(
                        name: "fk_customer_info_appointment_request_appointment_request_id",
                        column: x => x.appointment_request_id,
                        principalSchema: "appointment_service",
                        principalTable: "appointment_request",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "operational_hours",
                schema: "appointment_service",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    branch_id = table.Column<Guid>(type: "uuid", nullable: false),
                    day_of_week = table.Column<int>(type: "integer", nullable: false),
                    open_time = table.Column<TimeSpan>(type: "interval", nullable: false),
                    close_time = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_operational_hours", x => x.id);
                    table.ForeignKey(
                        name: "fk_operational_hours_branch_branch_id",
                        column: x => x.branch_id,
                        principalSchema: "appointment_service",
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_operational_hours_branch_id",
                schema: "appointment_service",
                table: "operational_hours",
                column: "branch_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_info",
                schema: "appointment_service");

            migrationBuilder.DropTable(
                name: "operational_hours",
                schema: "appointment_service");

            migrationBuilder.DropTable(
                name: "appointment_request",
                schema: "appointment_service");

            migrationBuilder.DropTable(
                name: "branch",
                schema: "appointment_service");
        }
    }
}
