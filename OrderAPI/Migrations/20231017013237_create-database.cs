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
                name: "IX_Discounts_OrderDetailorder_id",
                table: "Discounts",
                column: "OrderDetailorder_id");

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
                name: "IX_Shoppers_DidiOrderorder_id",
                table: "Shoppers",
                column: "DidiOrderorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPhones_ShopInfoid",
                table: "ShopPhones",
                column: "ShopInfoid");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_chargesId",
                table: "Totals",
                column: "chargesId");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_other_totalsId",
                table: "Totals",
                column: "other_totalsId");

            migrationBuilder.CreateIndex(
                name: "IX_UberOrders_orderId",
                table: "UberOrders",
                column: "orderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DidiSubItems");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "MetaInfos");

            migrationBuilder.DropTable(
                name: "PromotionsInfo");

            migrationBuilder.DropTable(
                name: "RappiOrders");

            migrationBuilder.DropTable(
                name: "RappiSubItems");

            migrationBuilder.DropTable(
                name: "Shoppers");

            migrationBuilder.DropTable(
                name: "ShopPhones");

            migrationBuilder.DropTable(
                name: "UberOrders");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "DidiOrders");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Orders");

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
                name: "Charges");

            migrationBuilder.DropTable(
                name: "OtherTotals");
        }
    }
}
