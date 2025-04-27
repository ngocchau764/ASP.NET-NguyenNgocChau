using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThingocChau_2122110055.Model
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cart_id { get; set; }

        public int User_id { get; set; }
        public DateTime Create_at { get; set; }

        [ForeignKey("User_id")]
        public User User { get; set; }
    }
}
