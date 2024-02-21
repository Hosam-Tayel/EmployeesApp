using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeesApp.Migrations
{
    /// <inheritdoc />
    public partial class insertColoumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Employee",
                columns: new[] { "EmployeesId", "DOB", "EmployeeName", "EmployeeNumber", "GrossSalary", "HiringDate", "NetSalary" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5452), "ahmed", "1001", 8000m, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5504), 7000m },
                    { 2, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5568), "hassan", "1002", 9000m, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5571), 1000m },
                    { 3, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5593), "ali", "1003", 11000m, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5595), 7000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
