using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class transaction
    {
        [Key]
        public int Transaction_Id { get; set; }
        //public required string metrial_ids { get; set; }
        public required string item_ids { get; set; }
        public int qty { get; set; }
        public DateTime tdate { get; set; }
    }
}
