using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class TestimonialsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TestimonialsID { get; set; }

        [Required(ErrorMessage = "Please slider title")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please slider sub title")]
        [MaxLength(100, ErrorMessage = "Sub Title cannot exceed 100 characters.")]
        public string Designation { get; set; }


        [Required(ErrorMessage = "Please slider content")]
        [MaxLength(1000, ErrorMessage = "Slider content cannot exceed 1000 characters.")]
        public string Content { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(100)]
        public string UrlLink { get; set; }

        [MaxLength(100)]
        public string WebPicture { get; set; }

        [MaxLength(100)]
        public string MobilePicture { get; set; }
    }
}
