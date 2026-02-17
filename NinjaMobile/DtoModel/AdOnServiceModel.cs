using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class AdOnServiceModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdOnServiceID { get; set; }

        [Required(ErrorMessage = "Please enter ad-on service name !")]
        public string AdOnServiceName { get; set; }       
        public int AdonCategoryID { get; set; }
        public int AdonSubCategoryID { get; set; }
        public double Charges { get; set; }
        public string Note { get; set; }
        public string BackgroundColor { get; set; } // Hex color 
        public string TextColor { get; set; } // Hex color 
        public string Picture { get; set; }


        [NotMapped]
        public double Quantity { get; set; }

        [NotMapped]
        public double Amount { get; set; }

        [NotMapped]
        public string AdonCategoryName { get; set; }

        [NotMapped]
        public string AdonSubCategoryName { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
