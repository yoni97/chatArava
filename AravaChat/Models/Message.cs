using System.ComponentModel.DataAnnotations;

namespace AravaChat.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Display (Name = "פוסט")]
        public string? Text { get; set; }

        [Display (Name = "שולח")]
        public User? Sender { get; set; }

        [Display (Name = "נמען")]
        public string? Reciever { get; set; }

        [Display (Name = "שעה"), ]
        public DateTime DateTime { get; set; }


        
    }
}
