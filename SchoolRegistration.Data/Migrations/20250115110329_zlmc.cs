using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolRegistration.Data.Migrations
{
    /// <inheritdoc />
    public partial class zlmc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolBasicInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UDISECode = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    SchoolNameEnglish = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SchoolNameHindi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    YearOfEstablishment = table.Column<int>(type: "int", nullable: false),
                    Recognition = table.Column<DateOnly>(type: "date", nullable: false),
                    SchoolBoard = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolBasicInformation", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolBasicInformation");
        }
    }
}
