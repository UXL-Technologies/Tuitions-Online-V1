using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuitionsOnline.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefenceForcesRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HowCanWeHelpYou = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeachersFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentialCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentialPinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graduate = table.Column<bool>(type: "bit", nullable: false),
                    GraduateField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostGraduate = table.Column<bool>(type: "bit", nullable: false),
                    PostGraduateField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctorate = table.Column<bool>(type: "bit", nullable: false),
                    DoctrateField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceInYears = table.Column<int>(type: "int", nullable: false),
                    RatePerClassInRupees = table.Column<int>(type: "int", nullable: false),
                    SubjectYouWishToTeach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrefferedLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlternativeLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadYourIdentificationDocument = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UploadYourIdentificationDocumentBloburl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
