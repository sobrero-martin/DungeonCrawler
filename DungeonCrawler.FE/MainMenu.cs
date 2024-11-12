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
using DungeonCrawler.BA;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Collections;
using System.Xml.Linq;

namespace DungeonCrawler.FE
{
    public partial class MainMenu : Form
    {
        public SoundPlayer player;
        Weapon_List wList = new Weapon_List();
        public MainMenu()
        {
            InitializeComponent();
            player = new SoundPlayer(@"Resources\Music\Debussy _ Arabesque No. 1.WAV");
            player.PlayLooping();
            if (wList.Read(1) == null)
            {
                Weapon sword = new Weapon(0, "LONGSWORD", 3, 1);
                wList.Insert(sword);
            }
            if (wList.Read(2) == null)
            {
                Weapon bow = new Weapon(0, "BOW", 3, 2);
                wList.Insert(bow);
            }
            if (wList.Read(3) == null)
            {
                Weapon wand = new Weapon(0, "WAND", 3, 3);
                wList.Insert(wand);
            }
        }

        
        private void btPractice_Click(object sender, EventArgs e)
        {
            PracticeMenu practiceMenu = new PracticeMenu();
            practiceMenu.MdiParent = this.MdiParent;
            practiceMenu.Dock = DockStyle.Fill;
            practiceMenu.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditMenu editMenu = new EditMenu();
            editMenu.MdiParent = this.MdiParent;
            editMenu.Dock = DockStyle.Fill;
            editMenu.Show();
        }
    }
}
