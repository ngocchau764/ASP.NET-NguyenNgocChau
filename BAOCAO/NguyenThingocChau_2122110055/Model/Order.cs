using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThingocChau_2122110055.Model
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_id { get; set; }

        public int User_id { get; set; }
        public DateTime Order_date { get; set; }
        public decimal Total_amount { get; set; }
        public string Order_status { get; set; }

        [ForeignKey("User_id")]
        public User User { get; set; }
    }
}
