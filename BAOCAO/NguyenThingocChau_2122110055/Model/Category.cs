using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NguyenThingocChau_2122110055.Model
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Category_id { get; set; }

        public string Category_name { get; set; }

        public DateTime? Create_at { get; set; }
        public string Create_by { get; set; } // Chỉnh sửa thành string
        public DateTime? Update_at { get; set; }
        public string Update_by { get; set; } // Chỉnh sửa thành string
        public DateTime? Delete_at { get; set; }
        public string? Delete_by { get; set; } // Thay đổi thành string? để cho phép null

        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>(); // Khởi tạo danh sách để tránh null
    }
}
