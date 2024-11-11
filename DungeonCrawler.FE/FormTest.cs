using DungeonCrawler.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DungeonCrawler.FE
{
    public partial class FormTest : Form
    {
        Player_List pList = new Player_List();
        private SoundPlayer player;
        public FormTest()
        {
            InitializeComponent();
            dgvPlayers.DataSource = pList.List;
            player = new SoundPlayer(@"Resources\Music\Debussy _ Arabesque No. 1.WAV");
            player.PlayLooping();
            lblPlayerList.Text = pList.ToString();
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player(0, txtName.Text, 0, 1, 0, 10, 10, 10, 10, 10, 1, 1, null);

            pList.Insert(player);

          /*  Player pl = new Player();

            pl.ID = Convert.ToInt32(txtID.Text);
            pl.Name = txtName.Text;
            pl.Score = 0;
            pl.Level = 1;
            pl.Experience = 0;
            pl.Health = 10;
            pl.Mana = 5;
            pl.Strength = 10;
            pl.Dexterity = 10;
            pl.Wisdom = 10;
            pl.Weapon_ID = 0;
            pl.Inventory_ID = Convert.ToInt32(txtID.Text);

            pList.Insert(pl);
            lblPlayerList.Text = pList.ToString();*/

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {


           /* Player pl = new Player();

            pl.ID = Convert.ToInt32(txtID.Text);
            pl.Name = txtName.Text;
            pl.Score = 0;
            pl.Level = 1;
            pl.Experience = 0;
            pl.Health = 10;
            pl.Mana = 5;
            pl.Strength = 10;
            pl.Dexterity = 10;
            pl.Wisdom = 10;
            pl.Weapon_ID = 0;
            pl.Inventory_ID = Convert.ToInt32(txtID.Text);

            pList.Update(pl, Convert.ToInt32(txtID.Text));
            lblPlayerList.Text = pList.ToString();*/
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            pList.Delete(Convert.ToInt32(txtID.Text));
            /*
            pList.Delete(Convert.ToInt32(txtID.Text));
            lblPlayerList.Text = pList.ToString();*/
        }

        private void btRead_Click(object sender, EventArgs e)
        {

            Player player = pList.Read(Convert.ToInt32(txtID.Text));
            lblPlayerList.Text = player.ToString();
            /*
            Player pl = pList.Read(Convert.ToInt32(txtID.Text));

            if (pl != null)
            {
                lblRead.Text = pl.ToString();
            }*/
            
        }

        private void btReadAll_Click(object sender, EventArgs e)
        {     
           /* lblRead.Text = pList.ToString();*/
        }
    }
}
