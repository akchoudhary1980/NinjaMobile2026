using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class BentoPackageModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BentoPackageID { get; set; }

        [Required(ErrorMessage = "Please enter bento package name !")]
        public string BentoPackageName { get; set; }

        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        public int PackingCompartmentID { get; set; } //3cp, 5cp, 
        public int CuisineID { get; set; } // indian, asian, 
        public int FoodCategoryID { get; set; } // indian, asian, 
        public int CuisinePreferanceID { get; set; } // Veg, Non-Veg, Jain, 

        public double DiscountPrice { get; set; } // 
        public double DisplayPrice { get; set; }
        public double ActualPrice { get; set; }
        public double KitchenPrice { get; set; }

        public bool IsCustomised { get; set; } // yes // no 
        public bool Active { get; set; }  
        public string Picture { get; set; }

        [NotMapped]
        public string PackingCompartmentName { get; set; }
        [NotMapped]
        public string CuisineName { get; set; }
        [NotMapped]
        public string CuisinePreferanceName { get; set; }

        [NotMapped]
        public int TotalGuestCount { get; set; }
        [NotMapped]
        public double AdonCost { get; set; }
    }
}
