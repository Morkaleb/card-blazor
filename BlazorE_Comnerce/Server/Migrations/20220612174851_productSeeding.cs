using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorE_Comnerce.Server.Migrations
{
    public partial class productSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Elf Wizard", "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=f8b87807-cac5-4e33-a8ed-a9ced0cd83a1", 0.5m, "Rumor Gatherer" },
                    { 2, "Kamigawa: Neon Dynasty", "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=9033cf27-d9e6-49b8-8ee1-c1f38c9680b9", 7.46m, "Junji, the Midnight Sky" },
                    { 3, "", "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=31b770cc-09e7-4c0b-b2a4-462ab4f7200d", 7.74m, "Expressive Iteration" },
                    { 4, "Streets of New Capenna", "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=ba4fa4c8-f09f-4d97-a7d1-1b93caf7d4f9", 4.45m, "Ziatora, the Incinerator" },
                    { 5, "Kamigawa: Neon Dynasty", "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=a548dcd-c1dd-492d-a69f-c65dfeef0633", 3.01m, "Sokenzan, Crucible of Defiance" },
                    { 6, "Modern Horizons 2 ", "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=676758ee-dac8-4c97-8a62-fff25bcbb6df", 32.65m, "Esper Sentinel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
