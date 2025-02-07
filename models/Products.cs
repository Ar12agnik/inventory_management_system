using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class Products
    {
        [Key]
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Quantity { get; set; }
        public int transaction_id { get; set; }
        public string status { get; set; }

    }
}
