using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIDM_3312_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerID", "Faction", "Name", "PlanetOfOrigin", "ReputationRating", "YearFounded" },
                values: new object[,]
                {
                    { 1, "UNSC", "Misriah Armory", "Earth", 4.5m, 2160 },
                    { 2, "Covenant", "Assembly Forges", "High Charity", 4.8m, 2100 },
                    { 3, "Brutes", "Weapon Systems Tech Co.", "Doisac", 4.2m, 2200 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponID", "AmmoType", "DamageRating", "ManufacturerID", "Name", "Price", "StockQuantity", "WeaponType" },
                values: new object[,]
                {
                    { 1, "7.62mm", 300, 1, "Assault Rifle", 1500m, 50, "Rifle" },
                    { 2, "12.7mm", 200, 1, "Magnum", 800m, 75, "Pistol" },
                    { 3, "8 gauge", 450, 1, "Shotgun", 2200m, 25, "Shotgun" },
                    { 4, "14.5mm", 750, 1, "Sniper Rifle", 5000m, 15, "Sniper" },
                    { 5, "Rockets", 850, 1, "Rocket Launcher", 7000m, 8, "Launcher" },
                    { 6, "Plasma", 220, 2, "Plasma Pistol", 1200m, 40, "Pistol" },
                    { 7, "Plasma", 300, 2, "Plasma Rifle", 1600m, 40, "Rifle" },
                    { 8, "Plasma", 350, 2, "Carbine", 1700m, 30, "Rifle" },
                    { 9, "Crystal", 350, 2, "Needler", 2000m, 30, "SMG" },
                    { 10, "Energy", 600, 2, "Energy Sword", 5000m, 20, "Sword" },
                    { 11, "Explosive Shells", 700, 3, "Brute Shot", 5000m, 11, "Launcher" },
                    { 12, "Gravity", 800, 3, "Gravity Hammer", 6000m, 10, "Melee" },
                    { 13, "Metal Spikes", 320, 3, "Spiker", 1800m, 35, "SMG" },
                    { 14, "Particle Beam", 750, 2, "Beam Rifle", 6000m, 12, "Sniper" },
                    { 15, "Fuel Rod", 850, 2, "Fuel Rod Gun", 6800m, 9, "Launcher" },
                    { 16, "5x23mm", 300, 1, "SMG", 1000m, 50, "SMG" },
                    { 17, "9.5mm", 400, 1, "Battle Rifle", 1800m, 45, "Rifle" },
                    { 18, "Energy", 500, 2, "Sentinel Beam", 2500m, 15, "Beam" },
                    { 19, "8 gauge", 460, 1, "Tactical Shotgun", 2300m, 25, "Shotgun" },
                    { 20, "7.62mm", 410, 1, "DMR", 1900m, 40, "Rifle" },
                    { 21, "Crystal", 370, 2, "Needle Rifle", 2100m, 25, "Rifle" },
                    { 22, "Plasma", 880, 2, "Plasma Launcher", 7000m, 8, "Launcher" },
                    { 23, "Concussive Blast", 780, 3, "Concussion Rifle", 5200m, 10, "Launcher" },
                    { 24, "Plasma", 310, 2, "Plasma Repeater", 1650m, 37, "Rifle" },
                    { 25, "Shells", 400, 3, "Mauler", 2000m, 30, "Shotgun" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerID",
                keyValue: 3);
        }
    }
}
