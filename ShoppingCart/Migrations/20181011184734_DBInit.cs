using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 8.8m, new DateTime(2018, 10, 11, 12, 47, 33, 691, DateTimeKind.Local), 9999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 39.9m, new DateTime(2018, 10, 11, 12, 47, 33, 694, DateTimeKind.Local), 9999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 29.1m, new DateTime(2018, 10, 11, 12, 47, 33, 694, DateTimeKind.Local), 9999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 69.5m, new DateTime(2018, 10, 11, 12, 47, 33, 694, DateTimeKind.Local), 9999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DefaultImageURL", "Price", "PublishDate", "Quantity" },
                values: new object[] { "https://multimedia.bbycastatic.ca/multimedia/products/500x500/800/80045/80045388.jpg", 3.6m, new DateTime(2018, 10, 11, 12, 47, 33, 694, DateTimeKind.Local), 9999 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DefaultImageURL", "Description", "Name", "Price", "PublishDate", "Quantity", "Status" },
                values: new object[] { 6, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZjddkFDYLLkbQrWbssugMePbBo7A_x7FuFXtaO778e_Bj5qOn", "A strip of cloth, paper, or plastic with an adhesive surface, used for sealing, binding, or attaching items together", "Tape", 5.9m, new DateTime(2018, 10, 11, 12, 47, 33, 694, DateTimeKind.Local), 9999, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 8m, new DateTime(2018, 10, 8, 4, 52, 36, 728, DateTimeKind.Local), 99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 39m, new DateTime(2018, 10, 8, 4, 52, 36, 729, DateTimeKind.Local), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 29m, new DateTime(2018, 10, 8, 4, 52, 36, 729, DateTimeKind.Local), 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "PublishDate", "Quantity" },
                values: new object[] { 69m, new DateTime(2018, 10, 8, 4, 52, 36, 729, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DefaultImageURL", "Price", "PublishDate", "Quantity" },
                values: new object[] { "http://www.2358jm.com/UpLoad/20170511100218484.JPG", 12m, new DateTime(2018, 10, 8, 4, 52, 36, 729, DateTimeKind.Local), 1 });
        }
    }
}
