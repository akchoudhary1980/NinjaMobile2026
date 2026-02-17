using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class VideoSliderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VideoSliderID { get; set; }
        
        [Required(ErrorMessage = "Please  enter slider title")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Please enter slider color")]
        [MaxLength(40, ErrorMessage = "Slider color cannot exceed 40 characters.")]
        public string SliderColor { get; set; }



        [Required(ErrorMessage = "Please slider content")]
        [MaxLength(1000, ErrorMessage = "Slider content cannot exceed 1000 characters.")]
        public string Content { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(100)]
        public string UrlLink { get; set; }

        [MaxLength(100)]
        public string WebVideo { get; set; }
        
    }
}
