using System.ComponentModel.DataAnnotations;

namespace ForgetMeNot.Data
{
    public class Note
    {
        [Required]
        [StringLength(100, ErrorMessage = "Text is too long.")]
        public string? Text { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}