using DungeonCrawler.BA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler.FE
{
    public partial class EditWeapons : Form
    {
        Weapon_List wList = new Weapon_List();
        public EditWeapons()
        {
            InitializeComponent();
            dgvWeapons.DataSource = wList.List;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon(0,txtName.Text, Convert.ToInt32(txtDmg.Text), Convert.ToInt32(txtItem.Text));
            wList.Insert(weapon);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (wList.Read(id) != null)
                {
                    wList.Update(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtDmg.Text), Convert.ToInt32(txtItem.Text));
                }
                else
                {
                    MessageBox.Show("Player with specified ID not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID");
            }
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (wList.Read(id) != null)
                {
                    wList.Delete(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    MessageBox.Show("Player with specified ID not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID");
            }
            
        }
    }
}
