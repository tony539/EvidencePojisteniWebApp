using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvidencePojisteniWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClientContractMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfInsuranceContract",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfInsuranceContract",
                table: "Client");
        }
    }
}
