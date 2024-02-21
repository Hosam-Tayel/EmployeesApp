using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesApp.Migrations
{
    /// <inheritdoc />
    public partial class insert4Coloumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 1,
                columns: new[] { "DOB", "HiringDate" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 2,
                columns: new[] { "DOB", "HiringDate" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 3,
                columns: new[] { "DOB", "EmployeeName", "GrossSalary", "HiringDate", "NetSalary" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4154), "ibrahim", 9000m, new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4155), 1000m });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Employee",
                columns: new[] { "EmployeesId", "DOB", "EmployeeName", "EmployeeNumber", "GrossSalary", "HiringDate", "NetSalary" },
                values: new object[] { 4, new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4159), "yasser", "1004", 9000m, new DateTime(2024, 2, 19, 23, 22, 8, 388, DateTimeKind.Local).AddTicks(4160), 1000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 1,
                columns: new[] { "DOB", "HiringDate" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 2,
                columns: new[] { "DOB", "HiringDate" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "EmployeesId",
                keyValue: 3,
                columns: new[] { "DOB", "EmployeeName", "GrossSalary", "HiringDate", "NetSalary" },
                values: new object[] { new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5593), "ali", 11000m, new DateTime(2024, 2, 19, 23, 18, 59, 55, DateTimeKind.Local).AddTicks(5595), 7000m });
        }
    }
}
