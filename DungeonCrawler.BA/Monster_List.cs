using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.BA
{
    public class Monster_List
    {
        public DataTable List { get; set; } = new DataTable();

        public Monster_List()
        {
            List.TableName = "MonsterList";
            List.Columns.Add("ID", typeof(int));
            List.Columns.Add("Name");
            List.Columns.Add("Description");
            List.Columns.Add("Level", typeof(int));
            List.Columns.Add("Health", typeof(int));
            List.Columns.Add("Experience", typeof(int));

            ReadFile();
        }
        public void ReadFile()
        {
            if (System.IO.File.Exists("Monsters.xml"))
            {
                List.ReadXml("Monsters.xml");
            }
        }

        public void Insert(Monster monster)
        {
            int id = NewID();

            List.Rows.Add();
            int NewRow = List.Rows.Count - 1;
            List.Rows[NewRow]["ID"] = id;
            List.Rows[NewRow]["Name"] = monster.Name;
            List.Rows[NewRow]["Description"] = monster.Description;
            List.Rows[NewRow]["Level"] = monster.Level;
            List.Rows[NewRow]["Health"] = monster.Health;
            List.Rows[NewRow]["Experience"] = monster.Experience;

            List.WriteXml("Monsters.xml");
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

        public Monster Read(int id)
        {

            foreach (DataRow row in List.Rows)
            {

                if (Convert.ToInt32(row["ID"]) == id)
                {

                    Monster monster = new Monster(
                        Convert.ToInt32(List.Rows[id - 1]["ID"]),
                        Convert.ToString(List.Rows[id - 1]["Name"]),
                        Convert.ToString(List.Rows[id - 1]["Description"]),
                        Convert.ToInt32(List.Rows[id - 1]["Level"]),
                        Convert.ToInt32(List.Rows[id - 1]["Health"]),
                        Convert.ToInt32(List.Rows[id - 1]["Experience"])
                      );

                    return monster;

                }
            }
            return null;
        }

        public void Attacked(int id, int hp)
        {
            foreach (DataRow row in List.Rows)
            {

                if (Convert.ToInt32(row["ID"]) == id)
                {
                    List.Rows[id-1]["Health"] = hp;
                }

            }
        }

        public override string ToString()
        {
            string res = "";


            foreach (DataRow row in List.Rows)
            {
                if (row != null)
                {
                    res = res + $"N°{row["ID"]} | NAME: {row["Name"]} | LVL: {row["Level"]} | HP: {row["Health"]} | {row["Description"]}" + "\r\n" + "\r\n";
                }
            }
            return res;



        }
    }
}
