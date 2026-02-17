using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class FeastPackageModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FeastPackageID { get; set; }

        [Required(ErrorMessage = "Please enter box package name !")]
        public string FeastPackageName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        public int FoodCategoryID { get; set; } // starter, main course, 
        public int CuisineID { get; set; } // indian, asian,        
        public int CuisinePreferanceID { get; set; } // Veg, Non-Veg, Jain, 
        public string CuisinePreferance { get; set; } // Veg, Non-Veg, Jain, 

        // public double DiscountPrice { get; set; } // 



        [Range(1, double.MaxValue, ErrorMessage = "Please enter display price!")]
        public double DisplayPrice { get; set; }


        [Range(1, double.MaxValue, ErrorMessage = "Please actual price be greater then 0!")]
        public double ActualPrice { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Please standered charges be greater then 0!")]
        public double StanderedCharges { get; set; }


        [Range(1, double.MaxValue, ErrorMessage = "Please actual people should be greater then 0!")]
        public int ActualPeopleCount { get; set; } //  

        public int VegPeopleCount { get; set; } //  
        public int NonVegPeopleCount { get; set; } //  


        [Range(1, double.MaxValue, ErrorMessage = "Please display people should be greater then 0!")]
        public int DisplayPeopleCount { get; set; } //  


        public bool IsCustomised { get; set; } // yes // no 
        public bool Active { get; set; }  
        public string Picture { get; set; }
         
        [NotMapped]
        public string CuisineName { get; set; }
        [NotMapped]
        public string CuisinePreferanceName { get; set; }
    }
}
