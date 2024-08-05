using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AravaChat.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "שם")]
        public string? UserName { get; set; }

        [Display(Name = "כינוי")]
        public string? NickName { get; set; }

        [Display(Name = "סיסמא")]
        public string? Password { get; set; }

        [Display (Name = "אימות סיסמא"), NotMapped]
        public string? ValidPassword { get; set; }

        public List<Message>? MessageList { get; set; }
    }
}
