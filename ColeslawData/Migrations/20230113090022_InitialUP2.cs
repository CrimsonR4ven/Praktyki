using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColeslawData.Migrations
{
    /// <inheritdoc />
    public partial class InitialUP2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_WarehouseId",
                table: "BusinessPartners");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "BusinessPartners",
                newName: "BusinessPartner");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessPartners_WarehouseId",
                table: "BusinessPartners",
                newName: "IX_BusinessPartners_BusinessPartner");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_BusinessPartner",
                table: "BusinessPartners",
                column: "BusinessPartner",
                principalTable: "BusinessPartnerTypes",
                principalColumn: "BusinessPartnerTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_BusinessPartner",
                table: "BusinessPartners");

            migrationBuilder.RenameColumn(
                name: "BusinessPartner",
                table: "BusinessPartners",
                newName: "WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessPartners_BusinessPartner",
                table: "BusinessPartners",
                newName: "IX_BusinessPartners_WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPartners_BusinessPartnerTypes_WarehouseId",
                table: "BusinessPartners",
                column: "WarehouseId",
                principalTable: "BusinessPartnerTypes",
                principalColumn: "BusinessPartnerTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
