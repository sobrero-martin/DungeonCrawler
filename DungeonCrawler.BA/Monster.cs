using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.BA
{
    public class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Experience { get; set; }

        public Monster(int id, string name, string description, int level, int hp, int xp)
        {
            ID = id;
            Name = name;
            Description = description;
            Level = level;
            Health = hp;
            Experience = xp;

        }

        public override string ToString()
        {
            string res = "";

            res = $"NAME: {Name} | DESC: {Description} \r\n LVL: {Level} | HP: {Health}";

            return res;
        }
    }
}
