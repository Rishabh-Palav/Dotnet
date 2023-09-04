using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotNetComputerSekho.Entities
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int payment_id { get; set; }
        public string? payment_transaction_id { get; set; }
        public DateOnly payment_date { get; set; }
        public bool payment_done { get; set; }
        public bool payment_receipt_send { get; set; }
        public double amount { get; set; }
        public string? payment_type { get; set; }
    }
}
