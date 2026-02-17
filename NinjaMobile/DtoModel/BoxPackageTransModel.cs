using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class BoxPackageTransModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoxPackageTransID { get; set; }
        public int ProductID { get; set; }      
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }       
        public int FoodCategoryID { get; set; } 
        public int BoxPackageID { get; set; } // key 



        [NotMapped]
        public string ProductName { get; set; }

        [NotMapped]
        public string ShortDescription { get; set; }

        [NotMapped]
        public int UnitID { get; set; }

        [NotMapped]
        public string UnitName { get; set; }

        [NotMapped]
        public string MealTypeName { get; set; }

        [NotMapped]
        public string SubMealTypeName { get; set; }


        [NotMapped]
        public int CuisinePreferanceID { get; set; }

        [NotMapped]
        public string CuisinePreference { get; set; }


        [NotMapped]
        public int CuisineID { get; set; }

        [NotMapped]
        public string CuisineName { get; set; }        

        [NotMapped]
        public string Preperation { get; set; }

        [NotMapped]
        public bool IsTaken { get; set; } = false;

    }
}
