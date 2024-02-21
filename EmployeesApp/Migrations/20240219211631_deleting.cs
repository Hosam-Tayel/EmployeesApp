using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeesApp.Migrations
{
    /// <inheritdoc />
    public partial class deleting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Employee",
                columns: new[] { "EmployeesId", "DOB", "EmployeeName", "EmployeeNumber", "GrossSalary", "HiringDate", "NetSalary" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 19, 23, 15, 20, 473, DateTimeKind.Local).AddTicks(1979), "ahmed", "1001", 8000m, new DateTime(2024, 2, 19, 23, 15, 20, 473, DateTimeKind.Local).AddTicks(2032), 7000m },
                    { 2, new DateTime(2024, 2, 19, 23, 15, 20, 473, DateTimeKind.Local).AddTicks(2143), "hassan", "1002", 9000m, new DateTime(2024, 2, 19, 23, 15, 20, 473, DateTimeKind.Local).AddTicks(2146), 1000m },
                    { 3, new DateTime(2024, 2, 19, 23, 15, 20, 473, DateTimeKind.Local).AddTicks(2170), "ali", "1003", 11000m, new DateTime(2024, 2, 19, 23, 15, 20, 473, DateTimeKind.Local).AddTicks(2172), 12000m }
                });
        }
    }
}
