using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderAPI.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_type = table.Column<string>(type: "longtext", nullable: false)
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
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    promo_type = table.Column<int>(type: "int", nullable: false),
                    promo_discount = table.Column<int>(type: "int", nullable: false),
                    shop_subside_price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetails", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReceiveAddresses",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false)
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
                    poi_lat = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poi_lng = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                name: "Totals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    total_products = table.Column<int>(type: "int", nullable: false),
                    total_discounts = table.Column<int>(type: "int", nullable: false),
                    total_order = table.Column<int>(type: "int", nullable: false),
                    total_to_pay = table.Column<int>(type: "int", nullable: false),
                    discount_by_support = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Totals", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UberOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    orderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UberOrders", x => x.id);
                    table.ForeignKey(
                        name: "FK_UberOrders_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
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
                    receive_addressuid = table.Column<int>(type: "int", nullable: false),
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
                    type = table.Column<string>(type: "longtext", nullable: false)
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
                name: "Charges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    shipping = table.Column<int>(type: "int", nullable: false),
                    service_fee = table.Column<int>(type: "int", nullable: false),
                    TotalsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charges_Totals_TotalsId",
                        column: x => x.TotalsId,
                        principalTable: "Totals",
                        principalColumn: "Id");
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
                    total_rappi_credits = table.Column<int>(type: "int", nullable: false),
                    TotalsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTotals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherTotals_Totals_TotalsId",
                        column: x => x.TotalsId,
                        principalTable: "Totals",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RappiOrders",
                columns: table => new
                {
                    order_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coooking_time = table.Column<int>(type: "int", nullable: false),
                    min_cooking_time = table.Column<int>(type: "int", nullable: false),
                    max_cooking_time = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delivery_method = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    payment_method = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delivery_discount = table.Column<int>(type: "int", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    delivery_informationId = table.Column<int>(type: "int", nullable: false),
                    totalsId = table.Column<int>(type: "int", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RappiOrders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_RappiOrders_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RappiOrders_DeliveriesInformation_delivery_informationId",
                        column: x => x.delivery_informationId,
                        principalTable: "DeliveriesInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RappiOrders_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RappiOrders_Totals_totalsId",
                        column: x => x.totalsId,
                        principalTable: "Totals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    app_item_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku_price = table.Column<int>(type: "int", nullable: false),
                    total_price = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    submit_refund_amount = table.Column<int>(type: "int", nullable: false),
                    real_price = table.Column<int>(type: "int", nullable: false),
                    promo_type = table.Column<int>(type: "int", nullable: false),
                    promotion_detailid = table.Column<int>(type: "int", nullable: false),
                    DidiOrderorder_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.app_item_id);
                    table.ForeignKey(
                        name: "FK_OrderItems_DidiOrders_DidiOrderorder_id",
                        column: x => x.DidiOrderorder_id,
                        principalTable: "DidiOrders",
                        principalColumn: "order_id");
                    table.ForeignKey(
                        name: "FK_OrderItems_PromotionDetails_promotion_detailid",
                        column: x => x.promotion_detailid,
                        principalTable: "PromotionDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RappiOrderorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingsInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingsInformation_RappiOrders_RappiOrderorder_id",
                        column: x => x.RappiOrderorder_id,
                        principalTable: "RappiOrders",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    value = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    raw_value = table.Column<int>(type: "int", nullable: false),
                    value_type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    max_value = table.Column<int>(type: "int", nullable: false),
                    includes_toppings = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    percentage_by_rappi = table.Column<int>(type: "int", nullable: false),
                    percentage_by_partners = table.Column<int>(type: "int", nullable: false),
                    amount_by_rappi = table.Column<int>(type: "int", nullable: false),
                    amount_by_partner = table.Column<int>(type: "int", nullable: false),
                    discount_product_units = table.Column<int>(type: "int", nullable: false),
                    discount_product_unit_value = table.Column<int>(type: "int", nullable: false),
                    RappiOrderorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discount_RappiOrders_RappiOrderorder_id",
                        column: x => x.RappiOrderorder_id,
                        principalTable: "RappiOrders",
                        principalColumn: "order_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comments = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<int>(type: "int", nullable: false),
                    percentage_discount = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    RappiOrderorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_RappiOrders_RappiOrderorder_id",
                        column: x => x.RappiOrderorder_id,
                        principalTable: "RappiOrders",
                        principalColumn: "order_id");
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RappiOrderorder_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.internal_id);
                    table.ForeignKey(
                        name: "FK_Stores_RappiOrders_RappiOrderorder_id",
                        column: x => x.RappiOrderorder_id,
                        principalTable: "RappiOrders",
                        principalColumn: "order_id");
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
                    OrderItemInfoapp_item_id = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DidiSubItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_DidiSubItems_OrderItems_OrderItemInfoapp_item_id",
                        column: x => x.OrderItemInfoapp_item_id,
                        principalTable: "OrderItems",
                        principalColumn: "app_item_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RappiSubItems",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sku = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_BillingsInformation_RappiOrderorder_id",
                table: "BillingsInformation",
                column: "RappiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_TotalsId",
                table: "Charges",
                column: "TotalsId");

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
                name: "IX_DidiSubItems_OrderItemInfoapp_item_id",
                table: "DidiSubItems",
                column: "OrderItemInfoapp_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_RappiOrderorder_id",
                table: "Discount",
                column: "RappiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RappiOrderorder_id",
                table: "Items",
                column: "RappiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DidiOrderorder_id",
                table: "OrderItems",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_promotion_detailid",
                table: "OrderItems",
                column: "promotion_detailid");

            migrationBuilder.CreateIndex(
                name: "IX_OtherTotals_TotalsId",
                table: "OtherTotals",
                column: "TotalsId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionsInfo_DidiOrderorder_id",
                table: "PromotionsInfo",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_customerId",
                table: "RappiOrders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_delivery_informationId",
                table: "RappiOrders",
                column: "delivery_informationId");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_orderId",
                table: "RappiOrders",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_RappiOrders_totalsId",
                table: "RappiOrders",
                column: "totalsId");

            migrationBuilder.CreateIndex(
                name: "IX_RappiSubItems_Itemid",
                table: "RappiSubItems",
                column: "Itemid");

            migrationBuilder.CreateIndex(
                name: "IX_Shoppers_DidiOrderorder_id",
                table: "Shoppers",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPhones_ShopInfoid",
                table: "ShopPhones",
                column: "ShopInfoid");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_RappiOrderorder_id",
                table: "Stores",
                column: "RappiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_orderId",
                table: "UberOrders",
                column: "orderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingsInformation");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "DidiSubItems");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "MetaInfos");

            migrationBuilder.DropTable(
                name: "OtherTotals");

            migrationBuilder.DropTable(
                name: "PromotionsInfo");

            migrationBuilder.DropTable(
                name: "RappiSubItems");

            migrationBuilder.DropTable(
                name: "Shoppers");

            migrationBuilder.DropTable(
                name: "ShopPhones");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "UberOrders");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "DidiOrders");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "RappiOrders");

            migrationBuilder.DropTable(
                name: "PricesInfo");

            migrationBuilder.DropTable(
                name: "ReceiveAddresses");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DeliveriesInformation");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Totals");
        }
    }
}
