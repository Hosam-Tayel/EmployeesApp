using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesApp.Migrations
{
    /// <inheritdoc />
    public partial class insertData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Employee",
                columns: new[] { "EmployeesId", "DOB", "EmployeeName", "EmployeeNumber", "GrossSalary", "HiringDate", "NetSalary" },
                values: new object[] { 1, new DateTime(2024, 2, 19, 23, 12, 55, 930, DateTimeKind.Local).AddTicks(7410), "ahmed", "1001", 8000m, new DateTime(2024, 2, 19, 23, 12, 55, 930, DateTimeKind.Local).AddTicks(7466), 7000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 1);
        }
    }
}
