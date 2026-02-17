using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class BentoPackageTransModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BentoPackageTransID { get; set; }
        public int GatherrItemID { get; set; }      
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public string ProductType { get; set; }
        public int FoodCategoryID { get; set; }
        public double AddOnDiffrent { get; set; }
        public int RefrenceID { get; set; }
        public int BentoPackageID { get; set; } // key 

        [NotMapped]
        public string ProductName { get; set; }

        [NotMapped]
        public string ShortDescription { get; set; }

        [NotMapped]
        public int CuisinePreferanceID { get; set; }     

        [NotMapped]
        public string UnitID { get; set; }

        [NotMapped]
        public string UnitName { get; set; }


        [NotMapped]
        public bool IsAddonUsed { get; set; } = false;

    }
}
