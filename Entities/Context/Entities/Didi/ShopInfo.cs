namespace Entities.Context.Entities.Didi
{
    public class ShopInfo
    {
        public long shop_id { get; set; }
        public string app_shop_id { get; set; }
        public string shop_addr { get; set; }
        public string shop_name { get; set; }
        public List<ShopPhone> shop_phone { get; set; }
    }


}
