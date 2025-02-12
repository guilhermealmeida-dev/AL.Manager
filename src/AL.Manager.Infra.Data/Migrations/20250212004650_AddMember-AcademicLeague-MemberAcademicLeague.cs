using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AL.Manager.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMemberAcademicLeagueMemberAcademicLeague : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicLeague",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicLeague", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcademicLeagueMember",
                columns: table => new
                {
                    AcademicLeaguesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MembersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicLeagueMember", x => new { x.AcademicLeaguesId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_AcademicLeagueMember_AcademicLeague_AcademicLeaguesId",
                        column: x => x.AcademicLeaguesId,
                        principalTable: "AcademicLeague",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicLeagueMember_Member_MembersId",
                        column: x => x.MembersId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberAcademicLeague",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcademicLiagueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AcademicLeagueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAcademicLeague", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberAcademicLeague_AcademicLeague_AcademicLeagueId",
                        column: x => x.AcademicLeagueId,
                        principalTable: "AcademicLeague",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MemberAcademicLeague_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicLeagueMember_MembersId",
                table: "AcademicLeagueMember",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAcademicLeague_AcademicLeagueId",
                table: "MemberAcademicLeague",
                column: "AcademicLeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAcademicLeague_MemberId",
                table: "MemberAcademicLeague",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicLeagueMember");

            migrationBuilder.DropTable(
                name: "MemberAcademicLeague");

            migrationBuilder.DropTable(
                name: "AcademicLeague");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
