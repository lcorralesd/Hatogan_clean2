using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hatogan.IA.Gateways.EFCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Since = table.Column<int>(type: "int", nullable: false),
                    Until = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EarTag = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Iron = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    BirthWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "date", nullable: false),
                    IncomeWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DamId = table.Column<int>(type: "int", nullable: true),
                    SireId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Animals_DamId",
                        column: x => x.DamId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_Animals_SireId",
                        column: x => x.SireId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Farms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "Farms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, -5, 0, 0, 0)), "-No Asignado-", null, null },
                    { 29, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, -5, 0, 0, 0)), "Velasquez", null, null },
                    { 28, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3144), new TimeSpan(0, -5, 0, 0, 0)), "Simmental", null, null },
                    { 27, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3143), new TimeSpan(0, -5, 0, 0, 0)), "Sanmartinero", null, null },
                    { 26, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, -5, 0, 0, 0)), "Romosinuano", null, null },
                    { 25, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, -5, 0, 0, 0)), "Pardo", null, null },
                    { 24, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3140), new TimeSpan(0, -5, 0, 0, 0)), "Normando", null, null },
                    { 23, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, -5, 0, 0, 0)), "Nelore", null, null },
                    { 22, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3138), new TimeSpan(0, -5, 0, 0, 0)), "Lucerna", null, null },
                    { 21, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, -5, 0, 0, 0)), "Limousin", null, null },
                    { 19, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, -5, 0, 0, 0)), "Indubrasil", null, null },
                    { 18, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3134), new TimeSpan(0, -5, 0, 0, 0)), "Holstein", null, null },
                    { 17, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3133), new TimeSpan(0, -5, 0, 0, 0)), "Harton del valle", null, null },
                    { 16, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, -5, 0, 0, 0)), "Gyr", null, null },
                    { 20, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, -5, 0, 0, 0)), "Jersey", null, null },
                    { 14, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, -5, 0, 0, 0)), "Criollo", null, null },
                    { 2, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3120), new TimeSpan(0, -5, 0, 0, 0)), "Angus", null, null },
                    { 3, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, -5, 0, 0, 0)), "Angus Negro", null, null },
                    { 15, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, -5, 0, 0, 0)), "Guzerat", null, null },
                    { 5, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, -5, 0, 0, 0)), "Ayrshire", null, null },
                    { 6, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, -5, 0, 0, 0)), "Bom", null, null },
                    { 7, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, -5, 0, 0, 0)), "Brahman", null, null },
                    { 4, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, -5, 0, 0, 0)), "Angus Rojo", null, null },
                    { 9, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, -5, 0, 0, 0)), "Casanareño", null, null },
                    { 10, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, -5, 0, 0, 0)), "Cebu", null, null },
                    { 11, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, -5, 0, 0, 0)), "Charolais", null, null },
                    { 12, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, -5, 0, 0, 0)), "Chino Santandereano", null, null },
                    { 13, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, -5, 0, 0, 0)), "Costeño con Cuernos", null, null },
                    { 8, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, -5, 0, 0, 0)), "Brangus", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Since", "Until" },
                values: new object[,]
                {
                    { 9, "Toros", 1080, 3600 },
                    { 1, "Crias", 0, 240 },
                    { 2, "Novillas Destete", 240, 365 },
                    { 3, "Mautes Destete", 240, 365 },
                    { 4, "Novillas de Levante", 365, 600 },
                    { 5, "Maute de Levante", 365, 600 },
                    { 6, "Novillas de Vientre", 600, 1080 },
                    { 7, "Maute de Vientre", 600, 1080 },
                    { 8, "Vacas", 1080, 3600 }
                });

            migrationBuilder.InsertData(
                table: "Farms",
                columns: new[] { "Id", "Address", "Code", "CreatedBy", "CreatedOn", "Name", "Phone", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, "Santa Rosa de Lima, paralelo 38", "ARZ", "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3946), new TimeSpan(0, -5, 0, 0, 0)), "Hacienda Arizona Y Villa Monica", "3000000000", null, null });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AdmissionDate", "BirthDate", "BirthWeight", "BreedId", "CategoryId", "Code", "Color", "CreatedBy", "CreatedOn", "DamId", "EarTag", "FarmId", "ImageUrl", "IncomeWeight", "Iron", "Name", "Remark", "Sex", "SireId", "Status", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1, 8, "Mad/Desc", null, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, -5, 0, 0, 0)), null, null, 1, null, 0m, null, "Madre Desconocida", null, "Hembra", null, "Activo", null, null });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AdmissionDate", "BirthDate", "BirthWeight", "BreedId", "CategoryId", "Code", "Color", "CreatedBy", "CreatedOn", "DamId", "EarTag", "FarmId", "ImageUrl", "IncomeWeight", "Iron", "Name", "Remark", "Sex", "SireId", "Status", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1, 9, "Padr/Desc", null, "system", new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, -5, 0, 0, 0)), null, null, 1, null, 0m, null, "Padre Desconocido", null, "Macho", null, "Activo", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_BreedId",
                table: "Animals",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Code",
                table: "Animals",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_DamId",
                table: "Animals",
                column: "DamId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FarmId",
                table: "Animals",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_SireId",
                table: "Animals",
                column: "SireId");

            migrationBuilder.CreateIndex(
                name: "IX_Breeds_Name",
                table: "Breeds",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Farms_Code",
                table: "Farms",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Breeds");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Farms");
        }
    }
}
