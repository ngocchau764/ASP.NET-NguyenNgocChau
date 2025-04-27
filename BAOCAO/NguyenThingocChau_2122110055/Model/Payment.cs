using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThingocChau_2122110055.Model
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Payment_id { get; set; }

        public int Order_id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Payment_date { get; set; }
        public string Payment_method { get; set; }

        [ForeignKey("Order_id")]
        public Order Order { get; set; }
    }
}
