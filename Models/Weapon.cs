using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIDM_3312_Final_Project.Models
{
    public class Weapon
    {
        public int WeaponID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string WeaponType { get; set; }

        [Range(1, 1000)]
        public int DamageRating { get; set; }

        [Required]
        public string AmmoType { get; set; }

        [Range(0.01, 1000000)]
        public decimal Price { get; set; }

        [Range(0, 1000)]
        public int StockQuantity { get; set; }

        public int ManufacturerID { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
