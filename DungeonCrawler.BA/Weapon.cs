using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonCrawler.BA
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Item_ID { get; set; }

        public Weapon(int id, string name, int dmg, int item)
        {
            ID = id; 
            Name = name;
            Damage = dmg;
            Item_ID = item;
        }
  
    }
}
