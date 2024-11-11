using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DungeonCrawler.BA
{

    public class Player_List
    {

        public DataTable List { get; set; } = new DataTable();

        public Player_List()
        {
            List.TableName = "PlayerList";
            List.Columns.Add("ID", typeof(int));
            List.Columns.Add("Name");
            List.Columns.Add("Score", typeof(int));
            List.Columns.Add("Level", typeof(int));
            List.Columns.Add("Experience", typeof(int));
            List.Columns.Add("Health", typeof(int));
            List.Columns.Add("Mana", typeof(int));
            List.Columns.Add("Strength", typeof(int));
            List.Columns.Add("Dexterity", typeof(int));
            List.Columns.Add("Wisdom", typeof(int));
            List.Columns.Add("Weapon_ID", typeof(int));
            List.Columns.Add("Inventory_ID", typeof(int));

            ReadFile();
        }

        public void ReadFile()
        {
            if (System.IO.File.Exists("Players.xml"))
            {
                List.ReadXml("Players.xml");
            }
        }


        public void Insert(Player player)
        {
            int id = NewID();

            List.Rows.Add();
            int NewRow = List.Rows.Count - 1;
            List.Rows[NewRow]["ID"] = id;
            List.Rows[NewRow]["Name"] = player.Name;
            List.Rows[NewRow]["Score"] = player.Score;
            List.Rows[NewRow]["Level"] = player.Level;
            List.Rows[NewRow]["Experience"] = player.Experience;
            List.Rows[NewRow]["Health"] = player.Health;
            List.Rows[NewRow]["Mana"] = player.Mana;
            List.Rows[NewRow]["Strength"] = player.Strength;
            List.Rows[NewRow]["Dexterity"] = player.Dexterity;
            List.Rows[NewRow]["Wisdom"] = player.Wisdom;
            List.Rows[NewRow]["Weapon_ID"] = player.Weapon_ID;
            List.Rows[NewRow]["Inventory_ID"] = player.Inventory_ID;

            List.WriteXml("Players.xml");
        }

        private int NewID()
        {
            int NewID = 0;

            foreach (DataRow row in List.Rows)
            {
                if (NewID < Convert.ToInt32(row["ID"]))
                {
                    NewID = Convert.ToInt32(row["ID"]);
                }
            }

            NewID++;
            return NewID;
        }

        public bool Delete(int id)
        {
            /* foreach (DataRow row in List.Rows)
             {*/
            for (int j = 0; j < List.Rows.Count; j++) { 

            if (Convert.ToInt32(List.Rows[j]["ID"]) == id)
            {

                for (int i = j ; i < List.Rows.Count - 1; i++)
                {
                    List.Rows[i]["Name"] = List.Rows[i + 1]["Name"];
                    List.Rows[i]["Score"] = List.Rows[i + 1]["Score"];
                    List.Rows[i]["Level"] = List.Rows[i + 1]["Level"];
                    List.Rows[i]["Experience"] = List.Rows[i + 1]["Experience"];
                    List.Rows[i]["Health"] = List.Rows[i + 1]["Health"];
                    List.Rows[i]["Mana"] = List.Rows[i + 1]["Mana"];
                    List.Rows[i]["Strength"] = List.Rows[i + 1]["Strength"];
                    List.Rows[i]["Dexterity"] = List.Rows[i + 1]["Dexterity"];
                    List.Rows[i]["Wisdom"] = List.Rows[i + 1]["Wisdom"];
                    List.Rows[i]["Weapon_ID"] = List.Rows[i + 1]["Weapon_ID"];
                    List.Rows[i]["Inventory_ID"] = List.Rows[i + 1]["Inventory_ID"];
                }
                List.Rows.RemoveAt(List.Rows.Count - 1);
                    List.WriteXml("Players.xml");
                    return true;
            }
            
        }
            return false;
        }
            
        

        public Player Read(int id)
        {

            foreach (DataRow row in List.Rows)
            {

                if (Convert.ToInt32(row["ID"]) == id)
                {

                    Player player = new Player(
                        Convert.ToInt32(List.Rows[id - 1]["ID"]),
                        Convert.ToString(List.Rows[id - 1]["Name"]),
                        Convert.ToInt32(List.Rows[id - 1]["Score"]),
                        Convert.ToInt32(List.Rows[id - 1]["Level"]),
                        Convert.ToInt32(List.Rows[id - 1]["Experience"]),
                        Convert.ToInt32(List.Rows[id - 1]["Health"]),
                        Convert.ToInt32(List.Rows[id - 1]["Mana"]),
                        Convert.ToInt32(List.Rows[id - 1]["Strength"]),
                        Convert.ToInt32(List.Rows[id - 1]["Dexterity"]),
                        Convert.ToInt32(List.Rows[id - 1]["Wisdom"]),
                        Convert.ToInt32(List.Rows[id - 1]["Weapon_ID"]),
                        Convert.ToInt32(List.Rows[id - 1]["Inventory_ID"]),
                        null);

                    return player;

                }
            }
            return null;
        }


        public override string ToString()
        {
            string res = "";


            foreach (DataRow row in List.Rows)
            {
                if (row != null)
                {
                    res = res + $"SLOT: {row["ID"]} | NAME: {row["Name"]} | HP: {row["Health"]} | MP: {row["Mana"]} | ST: {row["Strength"]} | DEX: {row["Dexterity"]} | WIS: {row["Wisdom"]} | WEAPON: {row["Weapon_ID"]}" + "\r\n" + "\r\n";
                }
            }
            return res;

            /*
            public Player[] List { get; set; } = new Player[1];

            private int nextRow = 0;

            public bool Insert(Player player)
            {
                for (int i = 0; i < nextRow; i++)
                {
                    if (List[i].ID == player.ID)
                    {
                        return false;
                    }
                }

                if (nextRow == List.Length)
                {
                    ResizeArray();
                }
                List[nextRow] = player;
                nextRow++;
                return true;
            }

            public void ResizeArray()
            {
                int newSize = List.Length + 1;
                Player[] newList = new Player[newSize];
                for (int i = 0; i < List.Length; i++)
                {
                    newList[i] = List[i];
                }
                List = newList;
            }

            public bool Update(Player player, int id)
            {
                for (int i = 0; i < nextRow; i++)
                {
                    if (List[i].ID == id)
                    {
                        List[i] = player;
                        return true;
                    }
                }
                return false;
            }

            public bool Delete(int id)
            {
                for (int i = 0; i < nextRow; i++)
                {
                    if (List[i].ID == id)
                    {
                        for (int j = i; j < nextRow - 1; j++)
                        {
                            List[j] = List[j + 1];
                        }
                        nextRow--;
                        List[nextRow] = null;
                        return true;
                    }
                }
                return false;
            }

            public Player Read(int id)
            {
                for (int i = 0; i < nextRow; i++)
                {
                    if (List[i].ID == id)
                    {
                        return List[i];
                    }
                }
                return null;
            }

            public Player[] ReadAll()
            {
                Player[] result = new Player[nextRow];

                for (int i = 0; i < nextRow; i++)
                {
                    result[i] = List[i];
                }
                return result;
            }

            public override string ToString()
            {
                string res = "";


                foreach (Player p in List)
                {
                    if (p != null)
                    {
                        res = res + p.ToString() + "\r\n" + "\r\n";
                    }
                }
                return res;
            }*/
        }
    }
}