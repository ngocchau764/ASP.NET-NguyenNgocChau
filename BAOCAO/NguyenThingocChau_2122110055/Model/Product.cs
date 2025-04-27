using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThingocChau_2122110055.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_id { get; set; }

        public string Product_name { get; set; }
        public int Category_id { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime? Create_at { get; set; }
        public string Create_by { get; set; }

        [ForeignKey("Category_id")]
        public Category Category { get; set; }
    }
}
