using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class vendor
    {
        [Key]
        public int vendor_id { get; set; }
        public required string vendor_name { get; set; }
        public required string vendor_address { get; set; }
        public required string vendor_contact { get; set; }

    }
}
