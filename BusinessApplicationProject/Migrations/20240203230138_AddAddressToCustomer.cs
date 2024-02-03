using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApplicationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerAddressId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerAddressId",
                table: "Customers",
                column: "CustomerAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_CustomerAddressId",
                table: "Customers",
                column: "CustomerAddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_CustomerAddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerAddressId",
                table: "Customers");
        }
    }
}
