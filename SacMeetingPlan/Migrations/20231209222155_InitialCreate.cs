using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacMeetingPlan.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PresidingLeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OpeningHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeakersTopics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SpeakerTopic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MeetingPlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakersTopics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SpeakersTopics_MeetingPlan_MeetingPlanId",
                        column: x => x.MeetingPlanId,
                        principalTable: "MeetingPlan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpeakersTopics_MeetingPlanId",
                table: "SpeakersTopics",
                column: "MeetingPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpeakersTopics");

            migrationBuilder.DropTable(
                name: "MeetingPlan");
        }
    }
}
