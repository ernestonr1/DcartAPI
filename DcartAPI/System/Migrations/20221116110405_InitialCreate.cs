using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DcartAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PosterImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUppdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    QuantityInCart = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PosterImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUppdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuantityInCart = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_CartId",
                        column: x => x.CartId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    PosterImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "DateAdded", "DateUpdated", "Name", "PosterImageUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6104), null, "Electronics", "Images/Categories/electronics.jpg" },
                    { 2, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6106), null, "Furnitures", "Images/Categories/furniture.jpg" },
                    { 3, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6108), null, "Toys", "Images/Categories/toys.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "DateAdded", "DateUpdated", "MainCategoryId", "Name", "PosterImageUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6219), null, 1, "Computers", "/Images/SubCategories/computers.png" },
                    { 2, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6221), null, 1, "Tvs", "/Images/SubCategories/tv.png" },
                    { 3, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6223), null, 2, "Chairs", "/Images/SubCategories/chair.png" },
                    { 4, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6225), null, 2, "Tables", "/Images/SubCategories/table.png" },
                    { 5, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6226), null, 3, "Action Figures", "/Images/SubCategories/toys.png" },
                    { 6, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6228), null, 3, "Dolls", "/Images/SubCategories/dolls.png" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateAdded", "DateUpdated", "IsFeatured", "PosterImageUrl", "ProductName", "ProductPrice", "QuantityInStock", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6333), null, true, "Images/Products/dellxps.png", "Dell XPS", 17567m, 23, 1 },
                    { 2, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6335), null, true, "Images/Products/microsoft-surface.png", "Microsoft Surface", 23890m, 12, 1 },
                    { 3, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6338), null, true, "Images/Products/panasonic-tv.png", "Panasonic 4k TV", 29349m, 6, 2 },
                    { 4, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6339), null, true, "Images/Products/sony-lcd-tv.png", "Sony LCD TV", 18945m, 13, 2 },
                    { 5, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6341), null, false, "Images/Products/ikea-chair.png", "Ikea Chair", 129m, 239, 3 },
                    { 6, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6343), null, false, "Images/Products/ikea-soft-chair.png", "Ikea Soft Chair", 429m, 64, 3 },
                    { 7, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6345), null, true, "Images/Products/ikea-table.png", "Ikea Table", 349m, 123, 4 },
                    { 8, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6347), null, false, "Images/Products/ikea-glass-table.png", "Ikea Glass Table", 439m, 123, 4 },
                    { 9, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6348), null, false, "Images/Products/action-figure.png", "Action Figure", 599m, 38, 5 },
                    { 10, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6350), null, false, "Images/Products/toy-story-collection.png", "Ikea Table", 349m, 12, 5 },
                    { 11, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6352), null, false, "Images/Products/doll.png", "Dolly The Doll", 659m, 457, 6 },
                    { 12, new DateTime(2022, 11, 16, 11, 4, 5, 241, DateTimeKind.Utc).AddTicks(6353), null, true, "Images/Products/toy-story-doll.png", "Toy Story Doll", 189m, 21, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CartId",
                table: "OrderItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
