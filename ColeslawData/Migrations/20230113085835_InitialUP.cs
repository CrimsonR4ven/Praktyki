using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeslawData.Migrations
{
    /// <inheritdoc />
    public partial class InitialUP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_FK_BusinessPartner_WarehouseId",
                table: "BusinessPartners");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocTypes_FK_Document_DocTypeId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Gpus_FK_Document_GpuId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Warehouses_FK_Document_WarehouseId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_GpuStatuses_Gpus_FK_GpuStatus_GpuId",
                table: "GpuStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_GpuStatuses_Warehouses_FK_GpuStatus_WarehouseId",
                table: "GpuStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GpuStatuses_FK_GpuStatus_GpuId",
                table: "GpuStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GpuStatuses_FK_GpuStatus_WarehouseId",
                table: "GpuStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Documents_FK_Document_DocTypeId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_FK_Document_GpuId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_FK_Document_WarehouseId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "FK_GpuStatus_GpuId",
                table: "GpuStatuses");

            migrationBuilder.DropColumn(
                name: "FK_GpuStatus_WarehouseId",
                table: "GpuStatuses");

            migrationBuilder.DropColumn(
                name: "FK_Document_DocTypeId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "FK_Document_GpuId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "FK_Document_WarehouseId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "FK_BusinessPartner_WarehouseId",
                table: "BusinessPartners",
                newName: "WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessPartners_FK_BusinessPartner_WarehouseId",
                table: "BusinessPartners",
                newName: "IX_BusinessPartners_WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_GpuStatuses_GpuId",
                table: "GpuStatuses",
                column: "GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_GpuStatuses_WarehouseId",
                table: "GpuStatuses",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocTypeId",
                table: "Documents",
                column: "DocTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_GpuId",
                table: "Documents",
                column: "GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_WarehouseId",
                table: "Documents",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_WarehouseId",
                table: "BusinessPartners",
                column: "WarehouseId",
                principalTable: "BusinessPartnerTypes",
                principalColumn: "BusinessPartnerTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocTypes_DocTypeId",
                table: "Documents",
                column: "DocTypeId",
                principalTable: "DocTypes",
                principalColumn: "DocTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Gpus_GpuId",
                table: "Documents",
                column: "GpuId",
                principalTable: "Gpus",
                principalColumn: "GpuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Warehouses_WarehouseId",
                table: "Documents",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GpuStatuses_Gpus_GpuId",
                table: "GpuStatuses",
                column: "GpuId",
                principalTable: "Gpus",
                principalColumn: "GpuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GpuStatuses_Warehouses_WarehouseId",
                table: "GpuStatuses",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_WarehouseId",
                table: "BusinessPartners");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocTypes_DocTypeId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Gpus_GpuId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Warehouses_WarehouseId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_GpuStatuses_Gpus_GpuId",
                table: "GpuStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_GpuStatuses_Warehouses_WarehouseId",
                table: "GpuStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GpuStatuses_GpuId",
                table: "GpuStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GpuStatuses_WarehouseId",
                table: "GpuStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Documents_DocTypeId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_GpuId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_WarehouseId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "BusinessPartners",
                newName: "FK_BusinessPartner_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessPartners_WarehouseId",
                table: "BusinessPartners",
                newName: "IX_BusinessPartners_FK_BusinessPartner_WarehouseId");

            migrationBuilder.AddColumn<int>(
                name: "FK_GpuStatus_GpuId",
                table: "GpuStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_GpuStatus_WarehouseId",
                table: "GpuStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_Document_DocTypeId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_Document_GpuId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_Document_WarehouseId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GpuStatuses_FK_GpuStatus_GpuId",
                table: "GpuStatuses",
                column: "FK_GpuStatus_GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_GpuStatuses_FK_GpuStatus_WarehouseId",
                table: "GpuStatuses",
                column: "FK_GpuStatus_WarehouseId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_FK_BusinessPartner_WarehouseId",
                table: "BusinessPartners",
                column: "FK_BusinessPartner_WarehouseId",
                principalTable: "BusinessPartnerTypes",
                principalColumn: "BusinessPartnerTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocTypes_FK_Document_DocTypeId",
                table: "Documents",
                column: "FK_Document_DocTypeId",
                principalTable: "DocTypes",
                principalColumn: "DocTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Gpus_FK_Document_GpuId",
                table: "Documents",
                column: "FK_Document_GpuId",
                principalTable: "Gpus",
                principalColumn: "GpuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Warehouses_FK_Document_WarehouseId",
                table: "Documents",
                column: "FK_Document_WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GpuStatuses_Gpus_FK_GpuStatus_GpuId",
                table: "GpuStatuses",
                column: "FK_GpuStatus_GpuId",
                principalTable: "Gpus",
                principalColumn: "GpuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GpuStatuses_Warehouses_FK_GpuStatus_WarehouseId",
                table: "GpuStatuses",
                column: "FK_GpuStatus_WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
