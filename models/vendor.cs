using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class vendor
    {
        [Key]
        public int vendor_id { get; set; }
        public string vendor_name { get; set; }
        public string vendor_address { get; set; }
        public string vendor_contact { get; set; }

    }
}
