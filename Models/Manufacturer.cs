using System.ComponentModel.DataAnnotations;

namespace CIDM_3312_Final_Project.Models
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Faction { get; set; }

        public string PlanetOfOrigin { get; set; }

        public int YearFounded { get; set; }

        [Range(1, 5)]
        public decimal ReputationRating { get; set; }

        public List<Weapon> Weapons { get; set; }
    }
}