using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.BA
{

  
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Weapon_ID { get; set; }
        public int Inventory_ID { get; set; }

        public Player(int id, string name, int score, int level, int xp, int hp, int mp, int st, int dex, int wis, int weap, int inv, string pclass)
        {
            ID = id;
            Name = name;
            Score = score;
            Level = level;
            Experience = xp;
            Health = hp;
            Mana = mp;
            Strength = st;
            Dexterity = dex;
            Wisdom = wis;
            Weapon_ID = weap;
            Inventory_ID = inv;


            if (pclass == "WARRIOR")
            {
                Health = 15;
                Mana = 5;
                Strength = 14;
                Dexterity = 10;
                Wisdom = 6;
                Weapon_ID = 1;
            }
            else if (pclass == "RANGER")
            {
                Health = 12;
                Mana = 8;
                Strength = 12;
                Dexterity = 14;
                Wisdom = 6;
                Weapon_ID = 2;
            }
            else if (pclass == "WIZARD")
            {
                Health = 8;
                Mana = 12;
                Strength = 6;
                Dexterity = 10;
                Wisdom = 14;
                Weapon_ID = 3;
            }
            else
            {
                Health = 10;
                Mana = 10;
                Strength = 10;
                Dexterity = 10;
                Wisdom = 10;
                Weapon_ID = 1;
            }
        }
        

       /*
        public Player Create(int id, string name, int hp, int mp, int st, int dex, int wis, int weap, int inv)
        {
            Player player = new Player();
            player.ID = id;
            player.Name = name;
            player.Score = 0;
            player.Level = 1;
            player.Experience = 0;
            player.Health = hp;
            player.Mana = mp;
            player.Strength = st;
            player.Dexterity = dex;
            player.Wisdom = wis;
            player.Weapon_ID = weap;
            player.Inventory_ID = inv;
            return player;
        }*/

        public override string ToString()
        {
            string res = "";

            res = $"SLOT: {ID} | NAME: {Name} | HP: {Health} | MP: {Mana} | ST: {Strength} | DEX: {Dexterity} | WIS: {Wisdom} | WEAPON: {Weapon_ID}";

            return res;
        }

    }

}
