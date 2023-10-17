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
                    can_adjust_ready_for_pickup_time = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_mark_out_of_item = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cancel = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                    instructions = table.Column<string>(type: "longtext", nullable: true)
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
                    address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billing_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: true)
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
                    number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pin_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_iso2 = table.Column<string>(type: "longtext", nullable: true)
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
                    latitude = table.Column<double>(type: "double", nullable: false),
                    longitude = table.Column<double>(type: "double", nullable: false)
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
                    city = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complete_address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    neighborhood = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complement = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postal_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_name = table.Column<string>(type: "longtext", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    total_percentage_discount = table.Column<int>(type: "int", nullable: false),
                    total_value_discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryDiscounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiscountedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    external_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discounted_quantity = table.Column<int>(type: "int", nullable: false),
                    discount_amount_applied = table.Column<int>(type: "int", nullable: false)
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
                    can_adjust_ready_for_pickup_time = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_mark_out_of_item = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    cancel = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                    key = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cipher_text = table.Column<string>(type: "longtext", nullable: true)
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
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_address_line_one = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_address_line_two = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    latitude = table.Column<double>(type: "double", nullable: false),
                    longitude = table.Column<double>(type: "double", nullable: false),
                    unit_number = table.Column<int>(type: "int", nullable: false),
                    business_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postal_code = table.Column<int>(type: "int", nullable: false),
                    location_type_value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_provided_street_address_line_one = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MetaInfos",
                columns: table => new
                {
                    resource_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resource_href = table.Column<string>(type: "longtext", nullable: true)
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
                    amount_e5 = table.Column<int>(type: "int", nullable: false),
                    currency_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formatted = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    display_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OAuthTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccessToken = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExpirationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OAuthTokens", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    past_order_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistory", x => x.Id);
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
                    ready_for_pickup_time_secs = table.Column<int>(type: "int", nullable: false),
                    source = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_for_pickup_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order_price = table.Column<int>(type: "int", nullable: false),
                    shop_paid_money = table.Column<int>(type: "int", nullable: false),
                    refund_price = table.Column<int>(type: "int", nullable: false),
                    items_discount = table.Column<int>(type: "int", nullable: false),
                    delivery_discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricesInfo", x => x.Id);
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
                    amount = table.Column<int>(type: "int", nullable: false),
                    unit = table.Column<string>(type: "longtext", nullable: true)
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
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calling_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    house_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_lat = table.Column<double>(type: "double", nullable: false),
                    poi_lng = table.Column<double>(type: "double", nullable: false),
                    coordinate_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_display_name = table.Column<string>(type: "longtext", nullable: true)
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
                    contain_alcoholic_item = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    contain_tobacco_product = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                    loyalty_number = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    shop_id = table.Column<long>(type: "bigint", nullable: false),
                    app_shop_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shop_addr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shop_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    internal_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    external_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.internal_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxBreakdown",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBreakdown", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxLocation",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_iso2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postal_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLocation", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TimeRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    start_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeRanges", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberPromotionDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    external_promotion_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_percentage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_delivery_fee_value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberPromotionDetail", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberStores",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberStores", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    make = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    model = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    license_plate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_autonomous = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    passcode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Allergens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AllergyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergens_Allergies_AllergyId",
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
                    special_instructions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    allergyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerRequests_Allergies_allergyId",
                        column: x => x.allergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tax_ids = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tax_id_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    customer_full_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    legal_entity_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billing_address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    encrypted_tax_idId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxProfile_EncryptedTaxId_encrypted_tax_idId",
                        column: x => x.encrypted_tax_idId,
                        principalTable: "EncryptedTaxId",
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
                    display_amount = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    netId = table.Column<int>(type: "int", nullable: true),
                    taxId = table.Column<int>(type: "int", nullable: true),
                    grossId = table.Column<int>(type: "int", nullable: true),
                    is_tax_inclusive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashAmountDue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashAmountDue_Monies_grossId",
                        column: x => x.grossId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CashAmountDue_Monies_netId",
                        column: x => x.netId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CashAmountDue_Monies_taxId",
                        column: x => x.taxId,
                        principalTable: "Monies",
                        principalColumn: "Id");
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
                    totalId = table.Column<int>(type: "int", nullable: true),
                    quantityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberDiscounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UberDiscounts_Monies_totalId",
                        column: x => x.totalId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UberDiscounts_Quantity_quantityId",
                        column: x => x.quantityId,
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
                    remark = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    timezone = table.Column<string>(type: "longtext", nullable: true)
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
                    priceId = table.Column<int>(type: "int", nullable: false),
                    shopId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_DidiOrders_PricesInfo_priceId",
                        column: x => x.priceId,
                        principalTable: "PricesInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DidiOrders_ReceiveAddresses_receive_addressuid",
                        column: x => x.receive_addressuid,
                        principalTable: "ReceiveAddresses",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DidiOrders_Shops_shopId",
                        column: x => x.shopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShopPhones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    calling_code = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShopInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopPhones_Shops_ShopInfoId",
                        column: x => x.ShopInfoId,
                        principalTable: "Shops",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FeeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    instance_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gross_amountId = table.Column<int>(type: "int", nullable: true),
                    net_amountId = table.Column<int>(type: "int", nullable: true),
                    TaxBreakdownId = table.Column<int>(type: "int", nullable: true),
                    TaxBreakdownId1 = table.Column<int>(type: "int", nullable: true),
                    TaxBreakdownId2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeDetail_Monies_gross_amountId",
                        column: x => x.gross_amountId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeeDetail_Monies_net_amountId",
                        column: x => x.net_amountId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeeDetail_TaxBreakdown_TaxBreakdownId",
                        column: x => x.TaxBreakdownId,
                        principalTable: "TaxBreakdown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeeDetail_TaxBreakdown_TaxBreakdownId1",
                        column: x => x.TaxBreakdownId1,
                        principalTable: "TaxBreakdown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeeDetail_TaxBreakdown_TaxBreakdownId2",
                        column: x => x.TaxBreakdownId2,
                        principalTable: "TaxBreakdown",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxReportings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    breakdownId = table.Column<int>(type: "int", nullable: true),
                    originid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    destinationid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxReportings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxReportings_TaxBreakdown_breakdownId",
                        column: x => x.breakdownId,
                        principalTable: "TaxBreakdown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxReportings_TaxLocation_destinationid",
                        column: x => x.destinationid,
                        principalTable: "TaxLocation",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TaxReportings_TaxLocation_originid",
                        column: x => x.originid,
                        principalTable: "TaxLocation",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiscountedItem",
                columns: table => new
                {
                    external_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discounted_quantity = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_amount_applied = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UberPromotionDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountedItem", x => x.external_id);
                    table.ForeignKey(
                        name: "FK_DiscountedItem_UberPromotionDetail_UberPromotionDetailId",
                        column: x => x.UberPromotionDetailId,
                        principalTable: "UberPromotionDetail",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartnerIdentifier",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UberStoreid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerIdentifier", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartnerIdentifier_UberStores_UberStoreid",
                        column: x => x.UberStoreid,
                        principalTable: "UberStores",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeliveryPartner",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vehicleId = table.Column<int>(type: "int", nullable: true),
                    contactId = table.Column<int>(type: "int", nullable: true),
                    current_locationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPartner", x => x.id);
                    table.ForeignKey(
                        name: "FK_DeliveryPartner_Contact_contactId",
                        column: x => x.contactId,
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DeliveryPartner_CurrentLocation_current_locationId",
                        column: x => x.current_locationId,
                        principalTable: "CurrentLocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DeliveryPartner_Vehicle_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdjustmentDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    amountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdjustmentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdjustmentDetail_CashAmountDue_amountId",
                        column: x => x.amountId,
                        principalTable: "CashAmountDue",
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
                    totalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fees_CashAmountDue_totalId",
                        column: x => x.totalId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    totalId = table.Column<int>(type: "int", nullable: true),
                    detailsId = table.Column<int>(type: "int", nullable: true),
                    order_total_excluding_promosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotions_CashAmountDue_order_total_excluding_promosId",
                        column: x => x.order_total_excluding_promosId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Promotions_CashAmountDue_totalId",
                        column: x => x.totalId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Promotions_UberPromotionDetail_detailsId",
                        column: x => x.detailsId,
                        principalTable: "UberPromotionDetail",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    totalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tips_CashAmountDue_totalId",
                        column: x => x.totalId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    delivery_discountId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_OrderDetail_DeliveryDiscounts_delivery_discountId",
                        column: x => x.delivery_discountId,
                        principalTable: "DeliveryDiscounts",
                        principalColumn: "Id");
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
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantityId = table.Column<int>(type: "int", nullable: false),
                    totalId = table.Column<int>(type: "int", nullable: true),
                    discountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounteds", x => x.id);
                    table.ForeignKey(
                        name: "FK_Discounteds_Monies_totalId",
                        column: x => x.totalId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Discounteds_Quantity_quantityId",
                        column: x => x.quantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discounteds_UberDiscounts_discountId",
                        column: x => x.discountId,
                        principalTable: "UberDiscounts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PriceBreakdowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cart_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantityId = table.Column<int>(type: "int", nullable: false),
                    totalId = table.Column<int>(type: "int", nullable: true),
                    discountId = table.Column<int>(type: "int", nullable: true),
                    unitId = table.Column<int>(type: "int", nullable: true),
                    is_tax_inclusive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceBreakdowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_Monies_totalId",
                        column: x => x.totalId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_Monies_unitId",
                        column: x => x.unitId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_Quantity_quantityId",
                        column: x => x.quantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceBreakdowns_UberDiscounts_discountId",
                        column: x => x.discountId,
                        principalTable: "UberDiscounts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    order_item_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    app_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    promo_type = table.Column<int>(type: "int", nullable: false),
                    promo_discount = table.Column<int>(type: "int", nullable: false),
                    shop_subside_price = table.Column<int>(type: "int", nullable: false),
                    DidiOrderorder_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionsInfo", x => x.Id);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DidiOrderorder_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoppers_DidiOrders_DidiOrderorder_id",
                        column: x => x.DidiOrderorder_id,
                        principalTable: "DidiOrders",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RemittanceSummaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    entity = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    amountId = table.Column<int>(type: "int", nullable: true),
                    TaxReportingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemittanceSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemittanceSummaries_Monies_amountId",
                        column: x => x.amountId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RemittanceSummaries_TaxReportings_TaxReportingId",
                        column: x => x.TaxReportingId,
                        principalTable: "TaxReportings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Adjustments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    totalId = table.Column<int>(type: "int", nullable: true),
                    detailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjustments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adjustments_AdjustmentDetail_detailsId",
                        column: x => x.detailsId,
                        principalTable: "AdjustmentDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Adjustments_CashAmountDue_totalId",
                        column: x => x.totalId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantFee",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    amountId = table.Column<int>(type: "int", nullable: true),
                    FeesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantFee", x => x.id);
                    table.ForeignKey(
                        name: "FK_MerchantFee_CashAmountDue_amountId",
                        column: x => x.amountId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MerchantFee_Fees_FeesId",
                        column: x => x.FeesId,
                        principalTable: "Fees",
                        principalColumn: "Id");
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
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_RappiOrders", x => x.Id);
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
                    totalId = table.Column<int>(type: "int", nullable: true),
                    subtotal_including_promosId = table.Column<int>(type: "int", nullable: true),
                    price_breakdownId = table.Column<int>(type: "int", nullable: true),
                    discountId = table.Column<int>(type: "int", nullable: true),
                    unitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCharges_Monies_subtotal_including_promosId",
                        column: x => x.subtotal_including_promosId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCharges_Monies_totalId",
                        column: x => x.totalId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCharges_Monies_unitId",
                        column: x => x.unitId,
                        principalTable: "Monies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCharges_PriceBreakdowns_price_breakdownId",
                        column: x => x.price_breakdownId,
                        principalTable: "PriceBreakdowns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCharges_UberDiscounts_discountId",
                        column: x => x.discountId,
                        principalTable: "UberDiscounts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DidiSubItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    app_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku_price = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    OrderItemInfoorder_item_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DidiSubItems", x => x.Id);
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
                name: "PaymentDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    is_tax_inclusive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cash_amount_dueId = table.Column<int>(type: "int", nullable: false),
                    order_totalId = table.Column<int>(type: "int", nullable: false),
                    item_chargesId = table.Column<int>(type: "int", nullable: false),
                    feesId = table.Column<int>(type: "int", nullable: false),
                    tipsId = table.Column<int>(type: "int", nullable: false),
                    promotionsId = table.Column<int>(type: "int", nullable: false),
                    adjustmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Adjustments_adjustmentId",
                        column: x => x.adjustmentId,
                        principalTable: "Adjustments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_CashAmountDue_cash_amount_dueId",
                        column: x => x.cash_amount_dueId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_CashAmountDue_order_totalId",
                        column: x => x.order_totalId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Fees_feesId",
                        column: x => x.feesId,
                        principalTable: "Fees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_ItemCharges_item_chargesId",
                        column: x => x.item_chargesId,
                        principalTable: "ItemCharges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Promotions_promotionsId",
                        column: x => x.promotionsId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Tips_tipsId",
                        column: x => x.tipsId,
                        principalTable: "Tips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    payment_detailId = table.Column<int>(type: "int", nullable: true),
                    item_chargesId = table.Column<int>(type: "int", nullable: true),
                    feesId = table.Column<int>(type: "int", nullable: true),
                    tipsId = table.Column<int>(type: "int", nullable: true),
                    promotionsId = table.Column<int>(type: "int", nullable: true),
                    adjustmentId = table.Column<int>(type: "int", nullable: true),
                    cash_amount_dueId = table.Column<int>(type: "int", nullable: true),
                    tax_reportingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Adjustments_adjustmentId",
                        column: x => x.adjustmentId,
                        principalTable: "Adjustments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_CashAmountDue_cash_amount_dueId",
                        column: x => x.cash_amount_dueId,
                        principalTable: "CashAmountDue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Fees_feesId",
                        column: x => x.feesId,
                        principalTable: "Fees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_ItemCharges_item_chargesId",
                        column: x => x.item_chargesId,
                        principalTable: "ItemCharges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_PaymentDetail_payment_detailId",
                        column: x => x.payment_detailId,
                        principalTable: "PaymentDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Promotions_promotionsId",
                        column: x => x.promotionsId,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_TaxReportings_tax_reportingId",
                        column: x => x.tax_reportingId,
                        principalTable: "TaxReportings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Tips_tipsId",
                        column: x => x.tipsId,
                        principalTable: "Tips",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    order_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    display_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    external_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preparation_status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordering_platform = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fulfillment_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    scheduled_order_target_delivery_start_time = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    scheduled_order_target_delivery_end_time = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    store_id = table.Column<int>(type: "int", nullable: false),
                    is_order_accuracy_risk = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    store_instructions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    completed_time = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    created_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    has_membership_pass = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    storeid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paymentId = table.Column<int>(type: "int", nullable: true),
                    preparation_timeId = table.Column<int>(type: "int", nullable: true),
                    eligible_actionsId = table.Column<int>(type: "int", nullable: true),
                    retailer_loyalty_infoId = table.Column<int>(type: "int", nullable: true),
                    orderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UberOrders_ActionEligibility_eligible_actionsId",
                        column: x => x.eligible_actionsId,
                        principalTable: "ActionEligibility",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UberOrders_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberOrders_Payments_paymentId",
                        column: x => x.paymentId,
                        principalTable: "Payments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UberOrders_PreparationTimes_preparation_timeId",
                        column: x => x.preparation_timeId,
                        principalTable: "PreparationTimes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UberOrders_RetailerLoyaltyInfos_retailer_loyalty_infoId",
                        column: x => x.retailer_loyalty_infoId,
                        principalTable: "RetailerLoyaltyInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UberOrders_UberStores_storeid",
                        column: x => x.storeid,
                        principalTable: "UberStores",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    delivery_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estimated_pick_up_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    interaction_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delivery_partner_marked_not_ready_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    instructions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    locationid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delivery_partnerid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UberOrderId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_DeliveryPartner_delivery_partnerid",
                        column: x => x.delivery_partnerid,
                        principalTable: "DeliveryPartner",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Deliveries_Locations_locationid",
                        column: x => x.locationid,
                        principalTable: "Locations",
                        principalColumn: "id");
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
                    reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    failure_attributed_to_party = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    will_merchant_be_paid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    time_rangeId = table.Column<int>(type: "int", nullable: false),
                    UberOrderId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailureInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FailureInfos_TimeRanges_time_rangeId",
                        column: x => x.time_rangeId,
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
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    special_instructions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    include_single_use_items = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    restricted_itemsId = table.Column<int>(type: "int", nullable: false),
                    UberOrderId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_RestrictedItems_restricted_itemsId",
                        column: x => x.restricted_itemsId,
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
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nameId = table.Column<int>(type: "int", nullable: false),
                    order_historyId = table.Column<int>(type: "int", nullable: false),
                    contactId = table.Column<int>(type: "int", nullable: false),
                    is_primary_customer = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    tax_profileId = table.Column<int>(type: "int", nullable: false),
                    can_response_to_fulfillment_issues = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UberOrderId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberCustomers", x => x.id);
                    table.ForeignKey(
                        name: "FK_UberCustomers_Contact_contactId",
                        column: x => x.contactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberCustomers_Name_nameId",
                        column: x => x.nameId,
                        principalTable: "Name",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberCustomers_OrderHistory_order_historyId",
                        column: x => x.order_historyId,
                        principalTable: "OrderHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UberCustomers_TaxProfile_tax_profileId",
                        column: x => x.tax_profileId,
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
                    item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    external_data = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    customer_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantityId = table.Column<int>(type: "int", nullable: false),
                    default_quantityId = table.Column<int>(type: "int", nullable: false),
                    customer_requestsId = table.Column<int>(type: "int", nullable: false),
                    picture_url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShoppingCartid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_CustomerRequests_customer_requestsId",
                        column: x => x.customer_requestsId,
                        principalTable: "CustomerRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Quantity_default_quantityId",
                        column: x => x.default_quantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Quantity_quantityId",
                        column: x => x.quantityId,
                        principalTable: "Quantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_ShoppingCarts_ShoppingCartid",
                        column: x => x.ShoppingCartid,
                        principalTable: "ShoppingCarts",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FulfillmentIssue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    issue_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    action_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    suspend_until = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    store_response = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShoppingCartid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FulfillmentIssue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FulfillmentIssue_ShoppingCarts_ShoppingCartid",
                        column: x => x.ShoppingCartid,
                        principalTable: "ShoppingCarts",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SelectedModifierGroup",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    external_data = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CartItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedModifierGroup", x => x.id);
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
                    modifier_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SelectedModifierGroupid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemovedModifierItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemovedModifierItem_SelectedModifierGroup_SelectedModifierGr~",
                        column: x => x.SelectedModifierGroupid,
                        principalTable: "SelectedModifierGroup",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SelectedModifierItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    modifier_item_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SelectedModifierGroupid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedModifierItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedModifierItem_SelectedModifierGroup_SelectedModifierG~",
                        column: x => x.SelectedModifierGroupid,
                        principalTable: "SelectedModifierGroup",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AdjustmentDetail_amountId",
                table: "AdjustmentDetail",
                column: "amountId");

            migrationBuilder.CreateIndex(
                name: "IX_Adjustments_detailsId",
                table: "Adjustments",
                column: "detailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Adjustments_totalId",
                table: "Adjustments",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergens_AllergyId",
                table: "Allergens",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_customer_requestsId",
                table: "CartItem",
                column: "customer_requestsId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_default_quantityId",
                table: "CartItem",
                column: "default_quantityId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_quantityId",
                table: "CartItem",
                column: "quantityId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ShoppingCartid",
                table: "CartItem",
                column: "ShoppingCartid");

            migrationBuilder.CreateIndex(
                name: "IX_CashAmountDue_grossId",
                table: "CashAmountDue",
                column: "grossId");

            migrationBuilder.CreateIndex(
                name: "IX_CashAmountDue_netId",
                table: "CashAmountDue",
                column: "netId");

            migrationBuilder.CreateIndex(
                name: "IX_CashAmountDue_taxId",
                table: "CashAmountDue",
                column: "taxId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_allergyId",
                table: "CustomerRequests",
                column: "allergyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_delivery_partnerid",
                table: "Deliveries",
                column: "delivery_partnerid");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_locationid",
                table: "Deliveries",
                column: "locationid");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UberOrderId",
                table: "Deliveries",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPartner_contactId",
                table: "DeliveryPartner",
                column: "contactId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPartner_current_locationId",
                table: "DeliveryPartner",
                column: "current_locationId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPartner_vehicleId",
                table: "DeliveryPartner",
                column: "vehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_orderId",
                table: "DidiOrders",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_priceId",
                table: "DidiOrders",
                column: "priceId");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_receive_addressuid",
                table: "DidiOrders",
                column: "receive_addressuid");

            migrationBuilder.CreateIndex(
                name: "IX_DidiOrders_shopId",
                table: "DidiOrders",
                column: "shopId");

            migrationBuilder.CreateIndex(
                name: "IX_DidiSubItems_OrderItemInfoorder_item_id",
                table: "DidiSubItems",
                column: "OrderItemInfoorder_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountedItem_UberPromotionDetailId",
                table: "DiscountedItem",
                column: "UberPromotionDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounteds_discountId",
                table: "Discounteds",
                column: "discountId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounteds_quantityId",
                table: "Discounteds",
                column: "quantityId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounteds_totalId",
                table: "Discounteds",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_OrderDetailorder_id",
                table: "Discounts",
                column: "OrderDetailorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_FailureInfos_time_rangeId",
                table: "FailureInfos",
                column: "time_rangeId");

            migrationBuilder.CreateIndex(
                name: "IX_FailureInfos_UberOrderId",
                table: "FailureInfos",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_gross_amountId",
                table: "FeeDetail",
                column: "gross_amountId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_net_amountId",
                table: "FeeDetail",
                column: "net_amountId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_TaxBreakdownId",
                table: "FeeDetail",
                column: "TaxBreakdownId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_TaxBreakdownId1",
                table: "FeeDetail",
                column: "TaxBreakdownId1");

            migrationBuilder.CreateIndex(
                name: "IX_FeeDetail_TaxBreakdownId2",
                table: "FeeDetail",
                column: "TaxBreakdownId2");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_totalId",
                table: "Fees",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_FulfillmentIssue_ShoppingCartid",
                table: "FulfillmentIssue",
                column: "ShoppingCartid");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_discountId",
                table: "ItemCharges",
                column: "discountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_price_breakdownId",
                table: "ItemCharges",
                column: "price_breakdownId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_subtotal_including_promosId",
                table: "ItemCharges",
                column: "subtotal_including_promosId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_totalId",
                table: "ItemCharges",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCharges_unitId",
                table: "ItemCharges",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderDetailorder_id",
                table: "Items",
                column: "OrderDetailorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantFee_amountId",
                table: "MerchantFee",
                column: "amountId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantFee_FeesId",
                table: "MerchantFee",
                column: "FeesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_billing_informationId",
                table: "OrderDetail",
                column: "billing_informationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_delivery_discountId",
                table: "OrderDetail",
                column: "delivery_discountId");

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
                name: "IX_PartnerIdentifier_UberStoreid",
                table: "PartnerIdentifier",
                column: "UberStoreid");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_adjustmentId",
                table: "PaymentDetail",
                column: "adjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_cash_amount_dueId",
                table: "PaymentDetail",
                column: "cash_amount_dueId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_feesId",
                table: "PaymentDetail",
                column: "feesId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_item_chargesId",
                table: "PaymentDetail",
                column: "item_chargesId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_order_totalId",
                table: "PaymentDetail",
                column: "order_totalId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_promotionsId",
                table: "PaymentDetail",
                column: "promotionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_tipsId",
                table: "PaymentDetail",
                column: "tipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_adjustmentId",
                table: "Payments",
                column: "adjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_cash_amount_dueId",
                table: "Payments",
                column: "cash_amount_dueId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_feesId",
                table: "Payments",
                column: "feesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_item_chargesId",
                table: "Payments",
                column: "item_chargesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_payment_detailId",
                table: "Payments",
                column: "payment_detailId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_promotionsId",
                table: "Payments",
                column: "promotionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_tax_reportingId",
                table: "Payments",
                column: "tax_reportingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_tipsId",
                table: "Payments",
                column: "tipsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_discountId",
                table: "PriceBreakdowns",
                column: "discountId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_quantityId",
                table: "PriceBreakdowns",
                column: "quantityId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_totalId",
                table: "PriceBreakdowns",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceBreakdowns_unitId",
                table: "PriceBreakdowns",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_detailsId",
                table: "Promotions",
                column: "detailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_order_total_excluding_promosId",
                table: "Promotions",
                column: "order_total_excluding_promosId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_totalId",
                table: "Promotions",
                column: "totalId");

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
                name: "IX_RemittanceSummaries_amountId",
                table: "RemittanceSummaries",
                column: "amountId");

            migrationBuilder.CreateIndex(
                name: "IX_RemittanceSummaries_TaxReportingId",
                table: "RemittanceSummaries",
                column: "TaxReportingId");

            migrationBuilder.CreateIndex(
                name: "IX_RemovedModifierItem_SelectedModifierGroupid",
                table: "RemovedModifierItem",
                column: "SelectedModifierGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedModifierGroup_CartItemId",
                table: "SelectedModifierGroup",
                column: "CartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedModifierItem_SelectedModifierGroupid",
                table: "SelectedModifierItem",
                column: "SelectedModifierGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_Shoppers_DidiOrderorder_id",
                table: "Shoppers",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPhones_ShopInfoId",
                table: "ShopPhones",
                column: "ShopInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_restricted_itemsId",
                table: "ShoppingCarts",
                column: "restricted_itemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UberOrderId",
                table: "ShoppingCarts",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxProfile_encrypted_tax_idId",
                table: "TaxProfile",
                column: "encrypted_tax_idId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxReportings_breakdownId",
                table: "TaxReportings",
                column: "breakdownId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxReportings_destinationid",
                table: "TaxReportings",
                column: "destinationid");

            migrationBuilder.CreateIndex(
                name: "IX_TaxReportings_originid",
                table: "TaxReportings",
                column: "originid");

            migrationBuilder.CreateIndex(
                name: "IX_Tips_totalId",
                table: "Tips",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_chargesId",
                table: "Totals",
                column: "chargesId");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_other_totalsId",
                table: "Totals",
                column: "other_totalsId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_contactId",
                table: "UberCustomers",
                column: "contactId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_nameId",
                table: "UberCustomers",
                column: "nameId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_order_historyId",
                table: "UberCustomers",
                column: "order_historyId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_tax_profileId",
                table: "UberCustomers",
                column: "tax_profileId");

            migrationBuilder.CreateIndex(
                name: "IX_UberCustomers_UberOrderId",
                table: "UberCustomers",
                column: "UberOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UberDiscounts_quantityId",
                table: "UberDiscounts",
                column: "quantityId");

            migrationBuilder.CreateIndex(
                name: "IX_UberDiscounts_totalId",
                table: "UberDiscounts",
                column: "totalId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_eligible_actionsId",
                table: "UberOrders",
                column: "eligible_actionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_orderId",
                table: "UberOrders",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_paymentId",
                table: "UberOrders",
                column: "paymentId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_preparation_timeId",
                table: "UberOrders",
                column: "preparation_timeId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_retailer_loyalty_infoId",
                table: "UberOrders",
                column: "retailer_loyalty_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_storeid",
                table: "UberOrders",
                column: "storeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergens");

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
                name: "MerchantFee");

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
                name: "Name");

            migrationBuilder.DropTable(
                name: "OrderHistory");

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
                name: "PaymentDetail");

            migrationBuilder.DropTable(
                name: "TaxReportings");

            migrationBuilder.DropTable(
                name: "Adjustments");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "ItemCharges");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "TaxBreakdown");

            migrationBuilder.DropTable(
                name: "TaxLocation");

            migrationBuilder.DropTable(
                name: "AdjustmentDetail");

            migrationBuilder.DropTable(
                name: "PriceBreakdowns");

            migrationBuilder.DropTable(
                name: "UberPromotionDetail");

            migrationBuilder.DropTable(
                name: "CashAmountDue");

            migrationBuilder.DropTable(
                name: "UberDiscounts");

            migrationBuilder.DropTable(
                name: "Monies");

            migrationBuilder.DropTable(
                name: "Quantity");
        }
    }
}
