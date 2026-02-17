using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace NinjaMobile.Models
{
    public class SelectItems
    {
        public int ItemID { get; set; }

        [Required(ErrorMessage = "please enter item name!")]
        public string ItemName { get; set; }
    }
}
