using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 0;
            ExperienceRemaining = 100;
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }

        public void LevelUp()
        {
            Random rand = new Random();
            Level++;

            switch (CombatClass.ToString())
            {
                case "Mage":
                    Health += rand.Next(1, 20);
                    Power += rand.Next(1, 10);
                    Luck += rand.Next(1, 10);
                    break;
                case "Warrior":
                    Health += rand.Next(10, 30);
                    Power += rand.Next(1, 10);
                    Luck += rand.Next(1, 10);
                    break;
                case "Rogue":
                    Health += rand.Next(1, 25);
                    Power += rand.Next(1, 10);
                    Luck += rand.Next(1, 10);
                    break;
            }
        }

        public void DisplayStats(bool showTotalStats = true)
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Luck: {Luck}");
            Console.WriteLine($"Mana: {Mana}");

            if (!showTotalStats)
            {
                Console.WriteLine("(Natural stats only - equipment stats not shown)");
            }
        }

        public void CalculateTotals()
        {
        }
    }
}
