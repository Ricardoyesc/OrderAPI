using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderAPI.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActionEligibility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CanAdjustReadyForPickupTime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CanMarkOutOfItem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Cancel = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionEligibility", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    instructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BillingsInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billing_type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingsInformation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Charges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    shipping = table.Column<int>(type: "int", nullable: false),
                    service_fee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PinCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryISO2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CurrentLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    Longitude = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentLocation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeliveriesInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complete_address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    neighborhood = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complement = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postal_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveriesInformation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeliveryDiscounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    total_percentage_discount = table.Column<int>(type: "int", nullable: false),
                    total_value_discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryDiscounts", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiscountedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscountedQuantity = table.Column<int>(type: "int", nullable: false),
                    DiscountAmountApplied = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountedItems", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EligibleActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CanAdjustReadyForPickupTime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CanMarkOutOfItem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Cancel = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EligibleActions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EncryptedTaxId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CipherText = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncryptedTaxId", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlaceId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StreetAddressLineOne = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StreetAddressLineTwo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    Longitude = table.Column<double>(type: "double", nullable: false),
                    UnitNumber = table.Column<int>(type: "int", nullable: false),
                    BusinessName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    LocationTypeValue = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientProvidedStreetAddressLineOne = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MetaInfos",
                columns: table => new
                {
                    resource_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resource_href = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaInfos", x => x.resource_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Monies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AmountE5 = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Formatted = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OAuthTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccessToken = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExpirationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OAuthTokens", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    provider = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OtherTotals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tip = table.Column<int>(type: "int", nullable: false),
                    total_rappi_pay = table.Column<int>(type: "int", nullable: false),
                    total_rappi_credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTotals", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PreparationTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReadyForPickupTimeSecs = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReadyForPickupTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreparationTimes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PricesInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order_price = table.Column<int>(type: "int", nullable: false),
                    shop_paid_money = table.Column<int>(type: "int", nullable: false),
                    refund_price = table.Column<int>(type: "int", nullable: false),
                    items_discount = table.Column<int>(type: "int", nullable: false),
                    delivery_discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricesInfo", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PromotionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    promo_type = table.Column<int>(type: "int", nullable: false),
                    promo_discount = table.Column<int>(type: "int", nullable: false),
                    shop_subside_price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetails", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quantity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantity", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReceiveAddresses",
                columns: table => new
                {
                    uid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calling_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    house_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_lat = table.Column<double>(type: "double", nullable: false),
                    poi_lng = table.Column<double>(type: "double", nullable: false),
                    coordinate_type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_display_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveAddresses", x => x.uid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RestrictedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContainAlcoholicItem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ContainTobaccoProduct = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestrictedItems", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RetailerLoyaltyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LoyaltyNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailerLoyaltyInfos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    shop_id = table.Column<long>(type: "bigint", nullable: false),
                    app_shop_id = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shop_addr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shop_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    internal_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    external_id = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.internal_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxReportings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxReportings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TimeRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeRanges", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberStores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Make = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LicensePlate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsAutonomous = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HandoffInstructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Passcode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Allergen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AllergyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergen_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpecialInstructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AllergyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerRequests_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxIds = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaxIdType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerFullName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LegalEntityName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BillingAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncryptedTaxIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxProfile_EncryptedTaxId_EncryptedTaxIdId",
                        column: x => x.EncryptedTaxIdId,
                        principalTable: "EncryptedTaxId",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Adjustments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjustments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adjustments_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CashAmountDue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisplayAmount = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NetId = table.Column<int>(type: "int", nullable: false),
                    TaxId = table.Column<int>(type: "int", nullable: false),
                    GrossId = table.Column<int>(type: "int", nullable: false),
                    IsTaxInclusive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashAmountDue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashAmountDue_Monies_GrossId",
                        column: x => x.GrossId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashAmountDue_Monies_NetId",
                        column: x => x.NetId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashAmountDue_Monies_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fees_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaymentDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderTotalDisplayAmount = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderTotalNetId = table.Column<int>(type: "int", nullable: false),
                    OrderTotalTaxId = table.Column<int>(type: "int", nullable: false),
                    OrderTotalGrossId = table.Column<int>(type: "int", nullable: false),
                    IsTaxInclusive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Monies_OrderTotalGrossId",
                        column: x => x.OrderTotalGrossId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Monies_OrderTotalNetId",
                        column: x => x.OrderTotalNetId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Monies_OrderTotalTaxId",
                        column: x => x.OrderTotalTaxId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RemittanceSummaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Entity = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AmountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemittanceSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemittanceSummaries_Monies_AmountId",
                        column: x => x.AmountId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tips_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Totals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    total_products = table.Column<int>(type: "int", nullable: false),
                    total_discounts = table.Column<int>(type: "int", nullable: false),
                    total_order = table.Column<int>(type: "int", nullable: false),
                    total_to_pay = table.Column<int>(type: "int", nullable: false),
                    discount_by_support = table.Column<int>(type: "int", nullable: false),
                    chargesId = table.Column<int>(type: "int", nullable: true),
                    other_totalsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Totals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Totals_Charges_chargesId",
                        column: x => x.chargesId,
                        principalTable: "Charges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Totals_OtherTotals_other_totalsId",
                        column: x => x.other_totalsId,
                        principalTable: "OtherTotals",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalId = table.Column<int>(type: "int", nullable: false),
                    QuantityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberDiscounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UberDiscounts_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberDiscounts_Quantity_QuantityId",
                        column: x => x.QuantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DidiOrders",
                columns: table => new
                {
                    order_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    status = table.Column<int>(type: "int", nullable: false),
                    shop_accept_status = table.Column<int>(type: "int", nullable: false),
                    before_status = table.Column<int>(type: "int", nullable: false),
                    order_index = table.Column<int>(type: "int", nullable: false),
                    remark = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    timezone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pay_type = table.Column<int>(type: "int", nullable: false),
                    delivery_type = table.Column<int>(type: "int", nullable: false),
                    expected_cook_eta = table.Column<int>(type: "int", nullable: false),
                    expected_arrived_eta = table.Column<int>(type: "int", nullable: false),
                    create_time = table.Column<int>(type: "int", nullable: false),
                    pay_time = table.Column<int>(type: "int", nullable: false),
                    complete_time = table.Column<int>(type: "int", nullable: false),
                    cancel_time = table.Column<int>(type: "int", nullable: false),
                    shop_confirm_time = table.Column<int>(type: "int", nullable: false),
                    priceid = table.Column<int>(type: "int", nullable: false),
                    shopid = table.Column<int>(type: "int", nullable: false),
                    receive_addressuid = table.Column<long>(type: "bigint", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DidiOrders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_DidiOrders_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DidiOrders_PricesInfo_priceid",
                        column: x => x.priceid,
                        principalTable: "PricesInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DidiOrders_ReceiveAddresses_receive_addressuid",
                        column: x => x.receive_addressuid,
                        principalTable: "ReceiveAddresses",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DidiOrders_Shops_shopid",
                        column: x => x.shopid,
                        principalTable: "Shops",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShopPhones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    calling_code = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShopInfoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopPhones", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShopPhones_Shops_ShopInfoid",
                        column: x => x.ShopInfoid,
                        principalTable: "Shops",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxBreakdown",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InstanceId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GrossAmountId = table.Column<int>(type: "int", nullable: false),
                    NetAmountId = table.Column<int>(type: "int", nullable: false),
                    TaxReportingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBreakdown", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxBreakdown_Monies_GrossAmountId",
                        column: x => x.GrossAmountId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxBreakdown_Monies_NetAmountId",
                        column: x => x.NetAmountId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxBreakdown_TaxReportings_TaxReportingId",
                        column: x => x.TaxReportingId,
                        principalTable: "TaxReportings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberPromotionDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalPromotionId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscountValue = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscountPercentage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscountDeliveryFeeValue = table.Column<int>(type: "int", nullable: false),
                    TaxReportingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberPromotionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UberPromotionDetail_TaxReportings_TaxReportingId",
                        column: x => x.TaxReportingId,
                        principalTable: "TaxReportings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartnerIdentifier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdentifierId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UberStoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerIdentifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartnerIdentifier_UberStores_UberStoreId",
                        column: x => x.UberStoreId,
                        principalTable: "UberStores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeliveryPartner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartnerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CurrentLocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPartner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryPartner_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryPartner_CurrentLocation_CurrentLocationId",
                        column: x => x.CurrentLocationId,
                        principalTable: "CurrentLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryPartner_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FeeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InstanceId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GrossAmountId = table.Column<int>(type: "int", nullable: false),
                    NetAmountId = table.Column<int>(type: "int", nullable: false),
                    FeesId = table.Column<int>(type: "int", nullable: true),
                    TaxReportingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeDetail_Fees_FeesId",
                        column: x => x.FeesId,
                        principalTable: "Fees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeeDetail_Monies_GrossAmountId",
                        column: x => x.GrossAmountId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeeDetail_Monies_NetAmountId",
                        column: x => x.NetAmountId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeeDetail_TaxReportings_TaxReportingId",
                        column: x => x.TaxReportingId,
                        principalTable: "TaxReportings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    order_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coooking_time = table.Column<int>(type: "int", nullable: false),
                    min_cooking_time = table.Column<int>(type: "int", nullable: false),
                    max_cooking_time = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delivery_method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    payment_method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delivery_discountid = table.Column<int>(type: "int", nullable: true),
                    delivery_informationId = table.Column<int>(type: "int", nullable: true),
                    totalsId = table.Column<int>(type: "int", nullable: true),
                    billing_informationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_BillingsInformation_billing_informationId",
                        column: x => x.billing_informationId,
                        principalTable: "BillingsInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_DeliveriesInformation_delivery_informationId",
                        column: x => x.delivery_informationId,
                        principalTable: "DeliveriesInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_DeliveryDiscounts_delivery_discountid",
                        column: x => x.delivery_discountid,
                        principalTable: "DeliveryDiscounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Totals_totalsId",
                        column: x => x.totalsId,
                        principalTable: "Totals",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discounteds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriceType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantityId = table.Column<int>(type: "int", nullable: false),
                    TotalId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounteds_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discounteds_Quantity_QuantityId",
                        column: x => x.QuantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discounteds_UberDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "UberDiscounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PriceBreakdowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantityId = table.Column<int>(type: "int", nullable: false),
                    TotalId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    IsTaxInclusive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceBreakdowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_Monies_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_Quantity_QuantityId",
                        column: x => x.QuantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_UberDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "UberDiscounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    order_item_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    app_item_id = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku_price = table.Column<int>(type: "int", nullable: false),
                    total_price = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    submit_refund_amount = table.Column<int>(type: "int", nullable: false),
                    real_price = table.Column<int>(type: "int", nullable: false),
                    promo_type = table.Column<int>(type: "int", nullable: false),
                    promotion_detailId = table.Column<int>(type: "int", nullable: true),
                    DidiOrderorder_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.order_item_id);
                    table.ForeignKey(
                        name: "FK_OrderItems_DidiOrders_DidiOrderorder_id",
                        column: x => x.DidiOrderorder_id,
                        principalTable: "DidiOrders",
                        principalColumn: "order_id");
                    table.ForeignKey(
                        name: "FK_OrderItems_PromotionDetails_promotion_detailId",
                        column: x => x.promotion_detailId,
                        principalTable: "PromotionDetails",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PromotionsInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    promo_type = table.Column<int>(type: "int", nullable: false),
                    promo_discount = table.Column<int>(type: "int", nullable: false),
                    shop_subside_price = table.Column<int>(type: "int", nullable: false),
                    DidiOrderorder_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionsInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_PromotionsInfo_DidiOrders_DidiOrderorder_id",
                        column: x => x.DidiOrderorder_id,
                        principalTable: "DidiOrders",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shoppers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DidiOrderorder_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Shoppers_DidiOrders_DidiOrderorder_id",
                        column: x => x.DidiOrderorder_id,
                        principalTable: "DidiOrders",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiscountedItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscountAmountId = table.Column<int>(type: "int", nullable: false),
                    ExternalItemDiscountId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UberPromotionDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountedItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountedItem_Monies_DiscountAmountId",
                        column: x => x.DiscountAmountId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountedItem_UberPromotionDetail_UberPromotionDetailId",
                        column: x => x.UberPromotionDetailId,
                        principalTable: "UberPromotionDetail",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalId = table.Column<int>(type: "int", nullable: false),
                    DetailsId = table.Column<int>(type: "int", nullable: false),
                    OrderTotalExcludingPromosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotions_Monies_OrderTotalExcludingPromosId",
                        column: x => x.OrderTotalExcludingPromosId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotions_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotions_UberPromotionDetail_DetailsId",
                        column: x => x.DetailsId,
                        principalTable: "UberPromotionDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    value = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    sku = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    raw_value = table.Column<int>(type: "int", nullable: false),
                    value_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    max_value = table.Column<int>(type: "int", nullable: true),
                    includes_toppings = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    percentage_by_rappi = table.Column<int>(type: "int", nullable: false),
                    percentage_by_partners = table.Column<int>(type: "int", nullable: false),
                    amount_by_rappi = table.Column<int>(type: "int", nullable: false),
                    amount_by_partner = table.Column<int>(type: "int", nullable: false),
                    discount_product_units = table.Column<int>(type: "int", nullable: false),
                    discount_product_unit_value = table.Column<int>(type: "int", nullable: true),
                    OrderDetailorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_OrderDetail_OrderDetailorder_id",
                        column: x => x.OrderDetailorder_id,
                        principalTable: "OrderDetail",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comments = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<int>(type: "int", nullable: false),
                    percentage_discount = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDetailorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_OrderDetail_OrderDetailorder_id",
                        column: x => x.OrderDetailorder_id,
                        principalTable: "OrderDetail",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RappiOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order_detailorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    storeinternal_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    customerId = table.Column<int>(type: "int", nullable: true),
                    orderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RappiOrders", x => x.id);
                    table.ForeignKey(
                        name: "FK_RappiOrders_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RappiOrders_OrderDetail_order_detailorder_id",
                        column: x => x.order_detailorder_id,
                        principalTable: "OrderDetail",
                        principalColumn: "order_id");
                    table.ForeignKey(
                        name: "FK_RappiOrders_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RappiOrders_Stores_storeinternal_id",
                        column: x => x.storeinternal_id,
                        principalTable: "Stores",
                        principalColumn: "internal_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemCharges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalId = table.Column<int>(type: "int", nullable: false),
                    SubtotalIncludingPromosId = table.Column<int>(type: "int", nullable: false),
                    PriceBreakdownId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCharges_Monies_SubtotalIncludingPromosId",
                        column: x => x.SubtotalIncludingPromosId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCharges_Monies_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCharges_Monies_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Monies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCharges_PriceBreakdowns_PriceBreakdownId",
                        column: x => x.PriceBreakdownId,
                        principalTable: "PriceBreakdowns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCharges_UberDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "UberDiscounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DidiSubItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    app_item_id = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku_price = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    OrderItemInfoorder_item_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DidiSubItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_DidiSubItems_OrderItems_OrderItemInfoorder_item_id",
                        column: x => x.OrderItemInfoorder_item_id,
                        principalTable: "OrderItems",
                        principalColumn: "order_item_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RappiSubItems",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<int>(type: "int", nullable: false),
                    percentage_discount = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    Itemid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RappiSubItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_RappiSubItems_Items_Itemid",
                        column: x => x.Itemid,
                        principalTable: "Items",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false),
                    ItemChargesId = table.Column<int>(type: "int", nullable: false),
                    FeesId = table.Column<int>(type: "int", nullable: false),
                    TipsId = table.Column<int>(type: "int", nullable: false),
                    PromotionsId = table.Column<int>(type: "int", nullable: false),
                    AdjustmentId = table.Column<int>(type: "int", nullable: false),
                    CashAmountDueId = table.Column<int>(type: "int", nullable: false),
                    TaxReportingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Adjustments_AdjustmentId",
                        column: x => x.AdjustmentId,
                        principalTable: "Adjustments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_CashAmountDue_CashAmountDueId",
                        column: x => x.CashAmountDueId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Fees_FeesId",
                        column: x => x.FeesId,
                        principalTable: "Fees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_ItemCharges_ItemChargesId",
                        column: x => x.ItemChargesId,
                        principalTable: "ItemCharges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentDetail_PaymentDetailId",
                        column: x => x.PaymentDetailId,
                        principalTable: "PaymentDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Promotions_PromotionsId",
                        column: x => x.PromotionsId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_TaxReportings_TaxReportingId",
                        column: x => x.TaxReportingId,
                        principalTable: "TaxReportings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Tips_TipsId",
                        column: x => x.TipsId,
                        principalTable: "Tips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExternalId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PreparationStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderingPlatform = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FulfillmentType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ScheduledOrderTargetDeliveryStartTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ScheduledOrderTargetDeliveryEndTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    IsOrderAccuracyRisk = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StoreInstructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompletedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HasMembershipPass = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    PreparationTimeId = table.Column<int>(type: "int", nullable: false),
                    EligibleActionsId = table.Column<int>(type: "int", nullable: false),
                    RetailerLoyaltyInfoId = table.Column<int>(type: "int", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UberOrders_ActionEligibility_EligibleActionsId",
                        column: x => x.EligibleActionsId,
                        principalTable: "ActionEligibility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberOrders_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberOrders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberOrders_PreparationTimes_PreparationTimeId",
                        column: x => x.PreparationTimeId,
                        principalTable: "PreparationTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberOrders_RetailerLoyaltyInfos_RetailerLoyaltyInfoId",
                        column: x => x.RetailerLoyaltyInfoId,
                        principalTable: "RetailerLoyaltyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberOrders_UberStores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "UberStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeliveryId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstimatedPickUpTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InteractionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryPartnerMarkedNotReadyTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Instructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    DeliveryPartnerId = table.Column<int>(type: "int", nullable: false),
                    UberOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_DeliveryPartner_DeliveryPartnerId",
                        column: x => x.DeliveryPartnerId,
                        principalTable: "DeliveryPartner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_UberOrders_UberOrderId",
                        column: x => x.UberOrderId,
                        principalTable: "UberOrders",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FailureInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reason = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FailureAttributedToParty = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WillMerchantBePaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TimeRangeId = table.Column<int>(type: "int", nullable: false),
                    UberOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailureInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FailureInfos_TimeRanges_TimeRangeId",
                        column: x => x.TimeRangeId,
                        principalTable: "TimeRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FailureInfos_UberOrders_UberOrderId",
                        column: x => x.UberOrderId,
                        principalTable: "UberOrders",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpecialInstructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncludeSingleUseItems = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RestrictedItemsId = table.Column<int>(type: "int", nullable: false),
                    UberOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_RestrictedItems_RestrictedItemsId",
                        column: x => x.RestrictedItemsId,
                        principalTable: "RestrictedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_UberOrders_UberOrderId",
                        column: x => x.UberOrderId,
                        principalTable: "UberOrders",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderHistory = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    IsPrimaryCustomer = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TaxProfileId = table.Column<int>(type: "int", nullable: false),
                    CanResponseToFulfillmentIssues = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UberOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UberCustomers_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberCustomers_TaxProfile_TaxProfileId",
                        column: x => x.TaxProfileId,
                        principalTable: "TaxProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberCustomers_UberOrders_UberOrderId",
                        column: x => x.UberOrderId,
                        principalTable: "UberOrders",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CartItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExternalData = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantityId = table.Column<int>(type: "int", nullable: false),
                    DefaultQuantityId = table.Column<int>(type: "int", nullable: false),
                    CustomerRequestsId = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_CustomerRequests_CustomerRequestsId",
                        column: x => x.CustomerRequestsId,
                        principalTable: "CustomerRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Quantity_DefaultQuantityId",
                        column: x => x.DefaultQuantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Quantity_QuantityId",
                        column: x => x.QuantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FulfillmentIssue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IssueType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CartItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SuspendUntil = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StoreResponse = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FulfillmentIssue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FulfillmentIssue_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SelectedModifierGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifierGroupId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExternalData = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CartItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedModifierGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedModifierGroup_CartItem_CartItemId",
                        column: x => x.CartItemId,
                        principalTable: "CartItem",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RemovedModifierItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifierItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SelectedModifierGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemovedModifierItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemovedModifierItem_SelectedModifierGroup_SelectedModifierGr~",
                        column: x => x.SelectedModifierGroupId,
                        principalTable: "SelectedModifierGroup",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SelectedModifierItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifierItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SelectedModifierGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedModifierItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedModifierItem_SelectedModifierGroup_SelectedModifierG~",
                        column: x => x.SelectedModifierGroupId,
                        principalTable: "SelectedModifierGroup",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Adjustments_TotalId",
                table: "Adjustments",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergen_AllergyId",
                table: "Allergen",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CustomerRequestsId",
                table: "CartItem",
                column: "CustomerRequestsId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_DefaultQuantityId",
                table: "CartItem",
                column: "DefaultQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_QuantityId",
                table: "CartItem",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ShoppingCartId",
                table: "CartItem",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_CashAmountDue_GrossId",
                table: "CashAmountDue",
                column: "GrossId");

            migrationBuilder.CreateIndex(
                name: "IX_CashAmountDue_NetId",
                table: "CashAmountDue",
                column: "NetId");

            migrationBuilder.CreateIndex(
                name: "IX_CashAmountDue_TaxId",
                table: "CashAmountDue",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_AllergyId",
                table: "CustomerRequests",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DeliveryPartnerId",
                table: "Deliveries",
                column: "DeliveryPartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_LocationId",
                table: "Deliveries",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UberOrderId",
                table: "Deliveries",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPartner_ContactId",
                table: "DeliveryPartner",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPartner_CurrentLocationId",
                table: "DeliveryPartner",
                column: "CurrentLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPartner_VehicleId",
                table: "DeliveryPartner",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_orderId",
                table: "DidiOrders",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_priceid",
                table: "DidiOrders",
                column: "priceid");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_receive_addressuid",
                table: "DidiOrders",
                column: "receive_addressuid");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_shopid",
                table: "DidiOrders",
                column: "shopid");

            migrationBuilder.CreateIndex(
                name: "IX_DidiSubItems_OrderItemInfoorder_item_id",
                table: "DidiSubItems",
                column: "OrderItemInfoorder_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountedItem_DiscountAmountId",
                table: "DiscountedItem",
                column: "DiscountAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountedItem_UberPromotionDetailId",
                table: "DiscountedItem",
                column: "UberPromotionDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounteds_DiscountId",
                table: "Discounteds",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounteds_QuantityId",
                table: "Discounteds",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounteds_TotalId",
                table: "Discounteds",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_OrderDetailorder_id",
                table: "Discounts",
                column: "OrderDetailorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_FailureInfos_TimeRangeId",
                table: "FailureInfos",
                column: "TimeRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_FailureInfos_UberOrderId",
                table: "FailureInfos",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_FeesId",
                table: "FeeDetail",
                column: "FeesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_GrossAmountId",
                table: "FeeDetail",
                column: "GrossAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_NetAmountId",
                table: "FeeDetail",
                column: "NetAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_TaxReportingId",
                table: "FeeDetail",
                column: "TaxReportingId");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_TotalId",
                table: "Fees",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_FulfillmentIssue_ShoppingCartId",
                table: "FulfillmentIssue",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_DiscountId",
                table: "ItemCharges",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_PriceBreakdownId",
                table: "ItemCharges",
                column: "PriceBreakdownId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_SubtotalIncludingPromosId",
                table: "ItemCharges",
                column: "SubtotalIncludingPromosId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_TotalId",
                table: "ItemCharges",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_UnitId",
                table: "ItemCharges",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderDetailorder_id",
                table: "Items",
                column: "OrderDetailorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_billing_informationId",
                table: "OrderDetail",
                column: "billing_informationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_delivery_discountid",
                table: "OrderDetail",
                column: "delivery_discountid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_delivery_informationId",
                table: "OrderDetail",
                column: "delivery_informationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_totalsId",
                table: "OrderDetail",
                column: "totalsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DidiOrderorder_id",
                table: "OrderItems",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_promotion_detailId",
                table: "OrderItems",
                column: "promotion_detailId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerIdentifier_UberStoreId",
                table: "PartnerIdentifier",
                column: "UberStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_OrderTotalGrossId",
                table: "PaymentDetail",
                column: "OrderTotalGrossId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_OrderTotalNetId",
                table: "PaymentDetail",
                column: "OrderTotalNetId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_OrderTotalTaxId",
                table: "PaymentDetail",
                column: "OrderTotalTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AdjustmentId",
                table: "Payments",
                column: "AdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CashAmountDueId",
                table: "Payments",
                column: "CashAmountDueId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_FeesId",
                table: "Payments",
                column: "FeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ItemChargesId",
                table: "Payments",
                column: "ItemChargesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentDetailId",
                table: "Payments",
                column: "PaymentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PromotionsId",
                table: "Payments",
                column: "PromotionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TaxReportingId",
                table: "Payments",
                column: "TaxReportingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TipsId",
                table: "Payments",
                column: "TipsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_DiscountId",
                table: "PriceBreakdowns",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_QuantityId",
                table: "PriceBreakdowns",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_TotalId",
                table: "PriceBreakdowns",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_UnitId",
                table: "PriceBreakdowns",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_DetailsId",
                table: "Promotions",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_OrderTotalExcludingPromosId",
                table: "Promotions",
                column: "OrderTotalExcludingPromosId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_TotalId",
                table: "Promotions",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionsInfo_DidiOrderorder_id",
                table: "PromotionsInfo",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_customerId",
                table: "RappiOrders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_order_detailorder_id",
                table: "RappiOrders",
                column: "order_detailorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_orderId",
                table: "RappiOrders",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_storeinternal_id",
                table: "RappiOrders",
                column: "storeinternal_id");

            migrationBuilder.CreateIndex(
                name: "IX_RappiSubItems_Itemid",
                table: "RappiSubItems",
                column: "Itemid");

            migrationBuilder.CreateIndex(
                name: "IX_RemittanceSummaries_AmountId",
                table: "RemittanceSummaries",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_RemovedModifierItem_SelectedModifierGroupId",
                table: "RemovedModifierItem",
                column: "SelectedModifierGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedModifierGroup_CartItemId",
                table: "SelectedModifierGroup",
                column: "CartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedModifierItem_SelectedModifierGroupId",
                table: "SelectedModifierItem",
                column: "SelectedModifierGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoppers_DidiOrderorder_id",
                table: "Shoppers",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPhones_ShopInfoid",
                table: "ShopPhones",
                column: "ShopInfoid");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_RestrictedItemsId",
                table: "ShoppingCarts",
                column: "RestrictedItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UberOrderId",
                table: "ShoppingCarts",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBreakdown_GrossAmountId",
                table: "TaxBreakdown",
                column: "GrossAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBreakdown_NetAmountId",
                table: "TaxBreakdown",
                column: "NetAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBreakdown_TaxReportingId",
                table: "TaxBreakdown",
                column: "TaxReportingId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxProfile_EncryptedTaxIdId",
                table: "TaxProfile",
                column: "EncryptedTaxIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Tips_TotalId",
                table: "Tips",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_chargesId",
                table: "Totals",
                column: "chargesId");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_other_totalsId",
                table: "Totals",
                column: "other_totalsId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_ContactId",
                table: "UberCustomers",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_TaxProfileId",
                table: "UberCustomers",
                column: "TaxProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_UberOrderId",
                table: "UberCustomers",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UberDiscounts_QuantityId",
                table: "UberDiscounts",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_UberDiscounts_TotalId",
                table: "UberDiscounts",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_EligibleActionsId",
                table: "UberOrders",
                column: "EligibleActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_orderId",
                table: "UberOrders",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_PaymentId",
                table: "UberOrders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_PreparationTimeId",
                table: "UberOrders",
                column: "PreparationTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_RetailerLoyaltyInfoId",
                table: "UberOrders",
                column: "RetailerLoyaltyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_StoreId",
                table: "UberOrders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UberPromotionDetail_TaxReportingId",
                table: "UberPromotionDetail",
                column: "TaxReportingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergen");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "DidiSubItems");

            migrationBuilder.DropTable(
                name: "DiscountedItem");

            migrationBuilder.DropTable(
                name: "DiscountedItems");

            migrationBuilder.DropTable(
                name: "Discounteds");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "EligibleActions");

            migrationBuilder.DropTable(
                name: "FailureInfos");

            migrationBuilder.DropTable(
                name: "FeeDetail");

            migrationBuilder.DropTable(
                name: "FulfillmentIssue");

            migrationBuilder.DropTable(
                name: "MetaInfos");

            migrationBuilder.DropTable(
                name: "OAuthTokens");

            migrationBuilder.DropTable(
                name: "PartnerIdentifier");

            migrationBuilder.DropTable(
                name: "PromotionsInfo");

            migrationBuilder.DropTable(
                name: "RappiOrders");

            migrationBuilder.DropTable(
                name: "RappiSubItems");

            migrationBuilder.DropTable(
                name: "RemittanceSummaries");

            migrationBuilder.DropTable(
                name: "RemovedModifierItem");

            migrationBuilder.DropTable(
                name: "SelectedModifierItem");

            migrationBuilder.DropTable(
                name: "Shoppers");

            migrationBuilder.DropTable(
                name: "ShopPhones");

            migrationBuilder.DropTable(
                name: "TaxBreakdown");

            migrationBuilder.DropTable(
                name: "UberCustomers");

            migrationBuilder.DropTable(
                name: "DeliveryPartner");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "TimeRanges");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SelectedModifierGroup");

            migrationBuilder.DropTable(
                name: "TaxProfile");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "CurrentLocation");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "DidiOrders");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "EncryptedTaxId");

            migrationBuilder.DropTable(
                name: "PricesInfo");

            migrationBuilder.DropTable(
                name: "ReceiveAddresses");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "BillingsInformation");

            migrationBuilder.DropTable(
                name: "DeliveriesInformation");

            migrationBuilder.DropTable(
                name: "DeliveryDiscounts");

            migrationBuilder.DropTable(
                name: "Totals");

            migrationBuilder.DropTable(
                name: "CustomerRequests");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "OtherTotals");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "RestrictedItems");

            migrationBuilder.DropTable(
                name: "UberOrders");

            migrationBuilder.DropTable(
                name: "ActionEligibility");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PreparationTimes");

            migrationBuilder.DropTable(
                name: "RetailerLoyaltyInfos");

            migrationBuilder.DropTable(
                name: "UberStores");

            migrationBuilder.DropTable(
                name: "Adjustments");

            migrationBuilder.DropTable(
                name: "CashAmountDue");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "ItemCharges");

            migrationBuilder.DropTable(
                name: "PaymentDetail");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "PriceBreakdowns");

            migrationBuilder.DropTable(
                name: "UberPromotionDetail");

            migrationBuilder.DropTable(
                name: "UberDiscounts");

            migrationBuilder.DropTable(
                name: "TaxReportings");

            migrationBuilder.DropTable(
                name: "Monies");

            migrationBuilder.DropTable(
                name: "Quantity");
        }
    }
}
