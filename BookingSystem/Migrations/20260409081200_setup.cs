using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "AppointmentDate", "CustomerName", "Phone", "Service" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 10, 10, 11, 54, 433, DateTimeKind.Local).AddTicks(8796), "Ahmed Hassan", "01012345678", "Haircut" },
                    { 2, new DateTime(2026, 4, 11, 10, 11, 54, 440, DateTimeKind.Local).AddTicks(9943), "Sara Ali", "01198765432", "Massage" },
                    { 3, new DateTime(2026, 4, 12, 10, 11, 54, 441, DateTimeKind.Local).AddTicks(42), "Mohamed Tarek", "01234567890", "Dental Checkup" },
                    { 4, new DateTime(2026, 4, 9, 16, 11, 54, 441, DateTimeKind.Local).AddTicks(51), "Nour Ibrahim", "01555555555", "Facial" },
                    { 5, new DateTime(2026, 4, 16, 10, 11, 54, 441, DateTimeKind.Local).AddTicks(88), "Omar Khaled", "01099998888", "Gym Session" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
