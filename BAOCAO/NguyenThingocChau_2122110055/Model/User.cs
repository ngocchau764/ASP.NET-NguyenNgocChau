using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThingocChau_2122110055.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }

        public string User_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Create_at { get; set; }
        public string Create_by { get; set; }
    }
}
