using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StuffData.Migrations
{
    public partial class Initialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelephoneNumber",
                table: "Clients",
                newName: "Telephone");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Clients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeStuffLocationId",
                table: "Clients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentStuffCardId",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RentStuffCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fees = table.Column<decimal>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentStuffCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StuffLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StuffLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalHours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(nullable: true),
                    DayOfWeek = table.Column<int>(nullable: false),
                    OpenTime = table.Column<int>(nullable: false),
                    CloseTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalHours_StuffLocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "StuffLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StuffAssets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    stuffName = table.Column<string>(nullable: false),
                    stuffYear = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    NumberOfItems = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    stuffRef = table.Column<string>(nullable: true),
                    suffBrandModel = table.Column<string>(nullable: true),
                    rentStuffNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StuffAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StuffAssets_StuffLocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "StuffLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StuffAssets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckoutHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StuffAssetId = table.Column<int>(nullable: false),
                    RentStuffCardId = table.Column<int>(nullable: false),
                    CheckedOut = table.Column<DateTime>(nullable: false),
                    CheckedIn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_RentStuffCards_RentStuffCardId",
                        column: x => x.RentStuffCardId,
                        principalTable: "RentStuffCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_StuffAssets_StuffAssetId",
                        column: x => x.StuffAssetId,
                        principalTable: "StuffAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StuffAssetId = table.Column<int>(nullable: false),
                    RentStuffCardId = table.Column<int>(nullable: true),
                    Since = table.Column<DateTime>(nullable: false),
                    Until = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_RentStuffCards_RentStuffCardId",
                        column: x => x.RentStuffCardId,
                        principalTable: "RentStuffCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Checkouts_StuffAssets_StuffAssetId",
                        column: x => x.StuffAssetId,
                        principalTable: "StuffAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Holds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StuffAssetId = table.Column<int>(nullable: true),
                    RentStuffCardId = table.Column<int>(nullable: true),
                    HoldPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holds_RentStuffCards_RentStuffCardId",
                        column: x => x.RentStuffCardId,
                        principalTable: "RentStuffCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holds_StuffAssets_StuffAssetId",
                        column: x => x.StuffAssetId,
                        principalTable: "StuffAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_HomeStuffLocationId",
                table: "Clients",
                column: "HomeStuffLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RentStuffCardId",
                table: "Clients",
                column: "RentStuffCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_RentStuffCardId",
                table: "CheckoutHistories",
                column: "RentStuffCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_StuffAssetId",
                table: "CheckoutHistories",
                column: "StuffAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_RentStuffCardId",
                table: "Checkouts",
                column: "RentStuffCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_StuffAssetId",
                table: "Checkouts",
                column: "StuffAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_RentStuffCardId",
                table: "Holds",
                column: "RentStuffCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_StuffAssetId",
                table: "Holds",
                column: "StuffAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalHours_LocationId",
                table: "LocalHours",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StuffAssets_LocationId",
                table: "StuffAssets",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StuffAssets_StatusId",
                table: "StuffAssets",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_StuffLocations_HomeStuffLocationId",
                table: "Clients",
                column: "HomeStuffLocationId",
                principalTable: "StuffLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_RentStuffCards_RentStuffCardId",
                table: "Clients",
                column: "RentStuffCardId",
                principalTable: "RentStuffCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_StuffLocations_HomeStuffLocationId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_RentStuffCards_RentStuffCardId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "CheckoutHistories");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Holds");

            migrationBuilder.DropTable(
                name: "LocalHours");

            migrationBuilder.DropTable(
                name: "RentStuffCards");

            migrationBuilder.DropTable(
                name: "StuffAssets");

            migrationBuilder.DropTable(
                name: "StuffLocations");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Clients_HomeStuffLocationId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RentStuffCardId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "HomeStuffLocationId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RentStuffCardId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Clients",
                newName: "TelephoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
