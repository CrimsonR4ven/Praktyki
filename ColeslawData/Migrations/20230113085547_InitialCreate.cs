using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeslawData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessPartnerTypes",
                columns: table => new
                {
                    BusinessPartnerTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPartnerTypes", x => x.BusinessPartnerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DocTypes",
                columns: table => new
                {
                    DocTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTypes", x => x.DocTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    GpuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.GpuId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "BusinessPartners",
                columns: table => new
                {
                    BusinessPartnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessPartnerTypeId = table.Column<int>(type: "int", nullable: false),
                    FKBusinessPartnerWarehouseId = table.Column<int>(name: "FK_BusinessPartner_WarehouseId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPartners", x => x.BusinessPartnerId);
                    table.ForeignKey(
                        name: "FK_BusinessPartners_BusinessPartnerTypes_FK_BusinessPartner_WarehouseId",
                        column: x => x.FKBusinessPartnerWarehouseId,
                        principalTable: "BusinessPartnerTypes",
                        principalColumn: "BusinessPartnerTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GpuStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    GpuId = table.Column<int>(type: "int", nullable: false),
                    FKGpuStatusWarehouseId = table.Column<int>(name: "FK_GpuStatus_WarehouseId", type: "int", nullable: false),
                    FKGpuStatusGpuId = table.Column<int>(name: "FK_GpuStatus_GpuId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpuStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GpuStatuses_Gpus_FK_GpuStatus_GpuId",
                        column: x => x.FKGpuStatusGpuId,
                        principalTable: "Gpus",
                        principalColumn: "GpuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GpuStatuses_Warehouses_FK_GpuStatus_WarehouseId",
                        column: x => x.FKGpuStatusWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    BusinessPartnerId = table.Column<int>(type: "int", nullable: false),
                    GpuId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    DocTypeId = table.Column<int>(type: "int", nullable: false),
                    FKDocumentBusinessPartnerId = table.Column<int>(name: "FK_Document_BusinessPartnerId", type: "int", nullable: false),
                    FKDocumentGpuId = table.Column<int>(name: "FK_Document_GpuId", type: "int", nullable: false),
                    FKDocumentWarehouseId = table.Column<int>(name: "FK_Document_WarehouseId", type: "int", nullable: false),
                    FKDocumentDocTypeId = table.Column<int>(name: "FK_Document_DocTypeId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_BusinessPartners_FK_Document_BusinessPartnerId",
                        column: x => x.FKDocumentBusinessPartnerId,
                        principalTable: "BusinessPartners",
                        principalColumn: "BusinessPartnerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_DocTypes_FK_Document_DocTypeId",
                        column: x => x.FKDocumentDocTypeId,
                        principalTable: "DocTypes",
                        principalColumn: "DocTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Gpus_FK_Document_GpuId",
                        column: x => x.FKDocumentGpuId,
                        principalTable: "Gpus",
                        principalColumn: "GpuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Warehouses_FK_Document_WarehouseId",
                        column: x => x.FKDocumentWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPartners_FK_BusinessPartner_WarehouseId",
                table: "BusinessPartners",
                column: "FK_BusinessPartner_WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPartners_Name",
                table: "BusinessPartners",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPartnerTypes_Name",
                table: "BusinessPartnerTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_DocTypes_Name",
                table: "DocTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_FK_Document_BusinessPartnerId",
                table: "Documents",
                column: "FK_Document_BusinessPartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_FK_Document_DocTypeId",
                table: "Documents",
                column: "FK_Document_DocTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_FK_Document_GpuId",
                table: "Documents",
                column: "FK_Document_GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_FK_Document_WarehouseId",
                table: "Documents",
                column: "FK_Document_WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Gpus_Make_Model",
                table: "Gpus",
                columns: new[] { "Make", "Model" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GpuStatuses_FK_GpuStatus_GpuId",
                table: "GpuStatuses",
                column: "FK_GpuStatus_GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_GpuStatuses_FK_GpuStatus_WarehouseId",
                table: "GpuStatuses",
                column: "FK_GpuStatus_WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_City",
                table: "Warehouses",
                column: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "GpuStatuses");

            migrationBuilder.DropTable(
                name: "BusinessPartners");

            migrationBuilder.DropTable(
                name: "DocTypes");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "BusinessPartnerTypes");
        }
    }
}
