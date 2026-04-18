using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 10, 10, 11, 54, 433, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 11, 10, 11, 54, 440, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 12, 10, 11, 54, 441, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 9, 16, 11, 54, 441, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "AppointmentDate",
                value: new DateTime(2026, 4, 16, 10, 11, 54, 441, DateTimeKind.Local).AddTicks(88));
        }
    }
}
