using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCV.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    WorkPosition = table.Column<string>(maxLength: 200, nullable: true),
                    Phone = table.Column<string>(maxLength: 75, nullable: true),
                    Website = table.Column<string>(maxLength: 150, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 250, nullable: true),
                    DateBirdth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Url = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contacts_Users_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    EducationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationID);
                    table.ForeignKey(
                        name: "FK_Educations_Users_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    ExperienceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceID);
                    table.ForeignKey(
                        name: "FK_Experiences_Users_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_Skills_Users_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationsStates",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    End = table.Column<DateTime>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    EducationStatesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationsStates", x => x.EducationStatesID);
                    table.ForeignKey(
                        name: "FK_EducationsStates_Educations_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Educations",
                        principalColumn: "EducationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperiencesStates",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    End = table.Column<DateTime>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    ExperienceStateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperiencesStates", x => x.ExperienceStateID);
                    table.ForeignKey(
                        name: "FK_ExperiencesStates_Experiences_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillsStates",
                columns: table => new
                {
                    BaseID = table.Column<int>(nullable: false),
                    SkillStateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Percent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsStates", x => x.SkillStateID);
                    table.ForeignKey(
                        name: "FK_SkillsStates_Skills_BaseID",
                        column: x => x.BaseID,
                        principalTable: "Skills",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BaseID",
                table: "Contacts",
                column: "BaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_BaseID",
                table: "Educations",
                column: "BaseID");

            migrationBuilder.CreateIndex(
                name: "IX_EducationsStates_BaseID",
                table: "EducationsStates",
                column: "BaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_BaseID",
                table: "Experiences",
                column: "BaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ExperiencesStates_BaseID",
                table: "ExperiencesStates",
                column: "BaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_BaseID",
                table: "Skills",
                column: "BaseID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStates_BaseID",
                table: "SkillsStates",
                column: "BaseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EducationsStates");

            migrationBuilder.DropTable(
                name: "ExperiencesStates");

            migrationBuilder.DropTable(
                name: "SkillsStates");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
