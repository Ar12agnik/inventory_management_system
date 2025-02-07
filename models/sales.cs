using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class sales
    {
        [Key]
        public int sale_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public int amount { get; set; }

    }
}
