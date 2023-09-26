namespace Entities.Context.Entities.Uber
{
    public class UberWebhook
    {
        public string event_id { get; set; }
        public int event_time { get; set; }
        public string event_type { get; set; }
        public MetaInfo meta { get; set; }
    }


}