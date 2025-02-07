using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class Purchase
    {
        [Key]
        public int Purchase_id { get; set; }
        public string Item_name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Vendor_id { get; set; }

    }
}
