using System.ComponentModel.DataAnnotations;

namespace inventory_management_system.models
{
    public class Rawmetrials
    {
        [Key]
        public int Metrial_id { get; set; }
        public required string Metrial_name { get; set; }
        public int Purchase_id { get; set; }
        public int Quantity { get; set; }

    }
}
