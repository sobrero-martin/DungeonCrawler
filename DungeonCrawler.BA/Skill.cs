using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.BA
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Base_Damage { get; set; }
        public string Scaling_Stat { get; set; }
        public int Scaling_Multiplier { get; set; }
    }
}
