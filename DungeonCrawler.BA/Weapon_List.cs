using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.BA
{
    public class Weapon_List
    {
        public DataTable List { get; set; } = new DataTable();

        public Weapon_List()
        {
            List.TableName = "WeaponList";
            List.Columns.Add("ID", typeof(int));
            List.Columns.Add("Name");
            List.Columns.Add("Damage", typeof(int));
            List.Columns.Add("Item_ID", typeof(int));

            ReadFile();
        }

        public void ReadFile()
        {
            if (System.IO.File.Exists("Weapons.xml"))
            {
                List.ReadXml("Weapons.xml");
            }
        }

        public void Insert(Weapon weapon)
        {
            int id = NewID();

            List.Rows.Add();
            int NewRow = List.Rows.Count - 1;
            List.Rows[NewRow]["ID"] = id;
            List.Rows[NewRow]["Name"] = weapon.Name;
            List.Rows[NewRow]["Damage"] = weapon.Damage;
            List.Rows[NewRow]["Item_ID"] = weapon.Item_ID;

            List.WriteXml("Weapons.xml");
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
            
            for (int j = 0; j < List.Rows.Count; j++)
            {

                if (Convert.ToInt32(List.Rows[j]["ID"]) == id)
                {

                    for (int i = j; i < List.Rows.Count - 1; i++)
                    {
                        List.Rows[i]["Name"] = List.Rows[i + 1]["Name"];
                        List.Rows[i]["Damage"] = List.Rows[i + 1]["Damage"];
                        List.Rows[i]["Item_ID"] = List.Rows[i + 1]["Item_ID"];

                    }
                    List.Rows.RemoveAt(List.Rows.Count - 1);
                    List.WriteXml("Weapons.xml");
                    return true;
                }

            }
            return false;
        }

        public Weapon Read(int id)
        {

            foreach (DataRow row in List.Rows)
            {

                if (Convert.ToInt32(row["ID"]) == id)
                {

                    Weapon weapon = new Weapon(
                        Convert.ToInt32(List.Rows[id - 1]["ID"]),
                        Convert.ToString(List.Rows[id - 1]["Name"]),
                        Convert.ToInt32(List.Rows[id - 1]["Damage"]),
                        Convert.ToInt32(List.Rows[id - 1]["Item_ID"])
                        );

                    return weapon;

                }
            }
            return null;
        }

        public bool Update(int id, string name, int dmg, int item)
        {
            foreach (DataRow row in List.Rows)
            {

                if (Convert.ToInt32(row["ID"]) == id)
                {
                    List.Rows[id - 1]["Name"] = name;
                    List.Rows[id - 1]["Damage"] = dmg;
                    List.Rows[id - 1]["Item_ID"] = item;
                    List.WriteXml("Weapons.xml");
                    return true;
                }

            }
            return false;
        }


    }
}
