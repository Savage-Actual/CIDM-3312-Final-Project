using Microsoft.EntityFrameworkCore;
using CIDM_3312_Final_Project.Models;

namespace CIDM_3312_Final_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Manufacturers
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ManufacturerID = 1, Name = "Misriah Armory", Faction = "UNSC", PlanetOfOrigin = "Earth", YearFounded = 2160, ReputationRating = 4.5M },
                new Manufacturer { ManufacturerID = 2, Name = "Assembly Forges", Faction = "Covenant", PlanetOfOrigin = "High Charity", YearFounded = 2100, ReputationRating = 4.8M },
                new Manufacturer { ManufacturerID = 3, Name = "Weapon Systems Tech Co.", Faction = "Brutes", PlanetOfOrigin = "Doisac", YearFounded = 2200, ReputationRating = 4.2M }
            );

            // Seed Weapons
            modelBuilder.Entity<Weapon>().HasData(
                new Weapon { WeaponID = 1, Name = "Assault Rifle", WeaponType = "Rifle", DamageRating = 300, AmmoType = "7.62mm", Price = 1500M, StockQuantity = 50, ManufacturerID = 1 },
                new Weapon { WeaponID = 2, Name = "Magnum", WeaponType = "Pistol", DamageRating = 200, AmmoType = "12.7mm", Price = 800M, StockQuantity = 75, ManufacturerID = 1 },
                new Weapon { WeaponID = 3, Name = "Shotgun", WeaponType = "Shotgun", DamageRating = 450, AmmoType = "8 gauge", Price = 2200M, StockQuantity = 25, ManufacturerID = 1 },
                new Weapon { WeaponID = 4, Name = "Sniper Rifle", WeaponType = "Sniper", DamageRating = 750, AmmoType = "14.5mm", Price = 5000M, StockQuantity = 15, ManufacturerID = 1 },
                new Weapon { WeaponID = 5, Name = "Rocket Launcher", WeaponType = "Launcher", DamageRating = 850, AmmoType = "Rockets", Price = 7000M, StockQuantity = 8, ManufacturerID = 1 },
                new Weapon { WeaponID = 6, Name = "Plasma Pistol", WeaponType = "Pistol", DamageRating = 220, AmmoType = "Plasma", Price = 1200M, StockQuantity = 40, ManufacturerID = 2 },
                new Weapon { WeaponID = 7, Name = "Plasma Rifle", WeaponType = "Rifle", DamageRating = 300, AmmoType = "Plasma", Price = 1600M, StockQuantity = 40, ManufacturerID = 2 },
                new Weapon { WeaponID = 8, Name = "Carbine", WeaponType = "Rifle", DamageRating = 350, AmmoType = "Plasma", Price = 1700M, StockQuantity = 30, ManufacturerID = 2 },
                new Weapon { WeaponID = 9, Name = "Needler", WeaponType = "SMG", DamageRating = 350, AmmoType = "Crystal", Price = 2000M, StockQuantity = 30, ManufacturerID = 2 },
                new Weapon { WeaponID = 10, Name = "Energy Sword", WeaponType = "Sword", DamageRating = 600, AmmoType = "Energy", Price = 5000M, StockQuantity = 20, ManufacturerID = 2 },
                new Weapon { WeaponID = 11, Name = "Brute Shot", WeaponType = "Launcher", DamageRating = 700, AmmoType = "Explosive Shells", Price = 5000M, StockQuantity = 11, ManufacturerID = 3 },
                new Weapon { WeaponID = 12, Name = "Gravity Hammer", WeaponType = "Melee", DamageRating = 800, AmmoType = "Gravity", Price = 6000M, StockQuantity = 10, ManufacturerID = 3 },
                new Weapon { WeaponID = 13, Name = "Spiker", WeaponType = "SMG", DamageRating = 320, AmmoType = "Metal Spikes", Price = 1800M, StockQuantity = 35, ManufacturerID = 3 },
                new Weapon { WeaponID = 14, Name = "Beam Rifle", WeaponType = "Sniper", DamageRating = 750, AmmoType = "Particle Beam", Price = 6000M, StockQuantity = 12, ManufacturerID = 2 },
                new Weapon { WeaponID = 15, Name = "Fuel Rod Gun", WeaponType = "Launcher", DamageRating = 850, AmmoType = "Fuel Rod", Price = 6800M, StockQuantity = 9, ManufacturerID = 2 },
                new Weapon { WeaponID = 16, Name = "SMG", WeaponType = "SMG", DamageRating = 300, AmmoType = "5x23mm", Price = 1000M, StockQuantity = 50, ManufacturerID = 1 },
                new Weapon { WeaponID = 17, Name = "Battle Rifle", WeaponType = "Rifle", DamageRating = 400, AmmoType = "9.5mm", Price = 1800M, StockQuantity = 45, ManufacturerID = 1 },
                new Weapon { WeaponID = 18, Name = "Sentinel Beam", WeaponType = "Beam", DamageRating = 500, AmmoType = "Energy", Price = 2500M, StockQuantity = 15, ManufacturerID = 2 },
                new Weapon { WeaponID = 19, Name = "Tactical Shotgun", WeaponType = "Shotgun", DamageRating = 460, AmmoType = "8 gauge", Price = 2300M, StockQuantity = 25, ManufacturerID = 1 },
                new Weapon { WeaponID = 20, Name = "DMR", WeaponType = "Rifle", DamageRating = 410, AmmoType = "7.62mm", Price = 1900M, StockQuantity = 40, ManufacturerID = 1 },
                new Weapon { WeaponID = 21, Name = "Needle Rifle", WeaponType = "Rifle", DamageRating = 370, AmmoType = "Crystal", Price = 2100M, StockQuantity = 25, ManufacturerID = 2 },
                new Weapon { WeaponID = 22, Name = "Plasma Launcher", WeaponType = "Launcher", DamageRating = 880, AmmoType = "Plasma", Price = 7000M, StockQuantity = 8, ManufacturerID = 2 },
                new Weapon { WeaponID = 23, Name = "Concussion Rifle", WeaponType = "Launcher", DamageRating = 780, AmmoType = "Concussive Blast", Price = 5200M, StockQuantity = 10, ManufacturerID = 3 },
                new Weapon { WeaponID = 24, Name = "Plasma Repeater", WeaponType = "Rifle", DamageRating = 310, AmmoType = "Plasma", Price = 1650M, StockQuantity = 37, ManufacturerID = 2 },
                new Weapon { WeaponID = 25, Name = "Mauler", WeaponType = "Shotgun", DamageRating = 400, AmmoType = "Shells", Price = 2000M, StockQuantity = 30, ManufacturerID = 3 }
            );
        }
    }
}
