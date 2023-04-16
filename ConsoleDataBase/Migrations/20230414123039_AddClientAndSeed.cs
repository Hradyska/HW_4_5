using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleDataBase.Migrations
{
    /// <inheritdoc />
    public partial class AddClientAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "EMail", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "NY", "aurora@gmail.com", "Aurora", "+1-555-33-22" },
                    { 2, "Florida", "oltd@gmail.com", "Ocean LTD", "+1-777-33-22" },
                    { 3, "LA", "artemida@gmail.com", "Artemida", "+1-333-33-11" },
                    { 4, "NY", "unicorn@gmail.com", "Unicorn", "+1-444-33-11" },
                    { 5, "LA", "Pleiades@gmail.com", "Pleiades", "+1-888-33-11" }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "NY", "Main" },
                    { 2, "LA", "Office1" },
                    { 3, "Boston", "Office2" },
                    { 4, "Ostin", "Office3" },
                    { 5, "Portland", "Office4" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "Mr." },
                    { 2, "Ms." },
                    { 3, "Mrs." },
                    { 4, "Sr." },
                    { 5, "Sra." }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1989, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neil", new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armstrong", 1, 4 },
                    { 2, new DateTime(1998, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buzz", new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aldrin", 1, 4 },
                    { 3, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catherine", new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coleman", 2, 3 },
                    { 4, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collins", 1, 1 },
                    { 5, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ellen", new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 100000m, 1, "Project1", new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 200000m, 2, "Project2", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 105000m, 3, "Project3", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 300000m, 4, "Project4", new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 400000m, 5, "Project5", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 1200m, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 1, 2000m, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 2, 2200m, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 2, 3000m, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 3, 3500m, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 4, 3500m, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 4, 3500m, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, 5, 3500m, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, 5, 3500m, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
