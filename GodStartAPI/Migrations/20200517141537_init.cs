using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GodStartAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    selected = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_StoreUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "StoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRessource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    selected = table.Column<bool>(nullable: false),
                    StoreUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRessource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryRessource_StoreUser_StoreUserId",
                        column: x => x.StoreUserId,
                        principalTable: "StoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    selected = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostNumbers_StoreUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "StoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobRessource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    selected = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    PostNumberId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    Categoryselected = table.Column<bool>(nullable: false),
                    PostNumberNumber = table.Column<int>(nullable: false),
                    PostNumberselected = table.Column<bool>(nullable: false),
                    StoreUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRessource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobRessource_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRessource_PostNumbers_PostNumberId",
                        column: x => x.PostNumberId,
                        principalTable: "PostNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobRessource_StoreUser_StoreUserId",
                        column: x => x.StoreUserId,
                        principalTable: "StoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    selected = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    PostNumberId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true),
                    CategoryRessourceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_CategoryRessource_CategoryRessourceId",
                        column: x => x.CategoryRessourceId,
                        principalTable: "CategoryRessource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jobs_PostNumbers_PostNumberId",
                        column: x => x.PostNumberId,
                        principalTable: "PostNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_StoreUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "StoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PostNumberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_PostNumbers_PostNumberId",
                        column: x => x.PostNumberId,
                        principalTable: "PostNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId1 = table.Column<int>(nullable: true),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tag_JobRessource_JobId1",
                        column: x => x.JobId1,
                        principalTable: "JobRessource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "UserId", "UserId1", "selected" },
                values: new object[] { 1, "IT", 0, null, false });

            migrationBuilder.InsertData(
                table: "PostNumbers",
                columns: new[] { "Id", "Number", "UserId", "UserId1", "selected" },
                values: new object[] { 1, 2500, 0, null, false });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CategoryId", "CategoryRessourceId", "CreationDate", "ExpirationDate", "ImageUrl", "PostNumberId", "SubTitle", "Text", "Title", "UserId", "UserId1", "selected" },
                values: new object[] { 1, 1, null, new DateTime(2020, 5, 17, 16, 15, 37, 441, DateTimeKind.Local).AddTicks(5958), new DateTime(2020, 6, 16, 16, 15, 37, 441, DateTimeKind.Local).AddTicks(5958), "", 1, "", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dignissim cras tincidunt lobortis feugiat vivamus. Tellus at urna condimentum.", "JobTitle 1", 0, null, false });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CategoryId", "CategoryRessourceId", "CreationDate", "ExpirationDate", "ImageUrl", "PostNumberId", "SubTitle", "Text", "Title", "UserId", "UserId1", "selected" },
                values: new object[] { 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dignissim cras tincidunt lobortis feugiat vivamus. Tellus at urna condimentum.", "JobTitle 2", 0, null, false });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Name", "PostNumberId" },
                values: new object[] { 1, "Valby", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId1",
                table: "Categories",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRessource_StoreUserId",
                table: "CategoryRessource",
                column: "StoreUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRessource_CategoryId",
                table: "JobRessource",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRessource_PostNumberId",
                table: "JobRessource",
                column: "PostNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_JobRessource_StoreUserId",
                table: "JobRessource",
                column: "StoreUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CategoryId",
                table: "Jobs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CategoryRessourceId",
                table: "Jobs",
                column: "CategoryRessourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PostNumberId",
                table: "Jobs",
                column: "PostNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId1",
                table: "Jobs",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Location_PostNumberId",
                table: "Location",
                column: "PostNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PostNumbers_UserId1",
                table: "PostNumbers",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_JobId",
                table: "Tag",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_JobId1",
                table: "Tag",
                column: "JobId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "JobRessource");

            migrationBuilder.DropTable(
                name: "CategoryRessource");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PostNumbers");

            migrationBuilder.DropTable(
                name: "StoreUser");
        }
    }
}
