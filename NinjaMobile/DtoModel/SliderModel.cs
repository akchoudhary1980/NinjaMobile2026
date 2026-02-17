using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class SliderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SliderID { get; set; }


        [Required(ErrorMessage = "Please slider title")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please slider sub title")]
        [MaxLength(100, ErrorMessage = "Sub Title cannot exceed 100 characters.")]
        public string SubTitle { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(100)]
        public string UrlLink { get; set; }

        [MaxLength(100)]
        public string WebPicture { get; set; }

        [MaxLength(100)]
        public string MobilePicture { get; set; }
    }
}
