using DungeonCrawler.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler.FE
{
    
    public partial class PracticeBattle : Form
    {
        public SoundPlayer player;
        int mID;
        Monster_List mList = new Monster_List();
        Monster monster = new Monster(0,"","",0,0,0);
        public PracticeBattle(int pID, int mID)
        {
            InitializeComponent();
            player = new SoundPlayer(@"Resources\Music\Tschaikowsky-op37.8.WAV");
            player.PlayLooping();
            this.mID = mID;
            if (mID == 1)
            {
                pbMain.Image = Image.FromFile(@"Resources\Images\skeleton.png");
                pbMain.Parent = pbBackground;
                pbMain.BackColor = Color.Transparent;
            }
            monster = mList.Read(mID);
        }
       
           
        private void btBack_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(@"Resources\Music\Debussy _ Arabesque No. 1.WAV");
            player.PlayLooping();
            this.Close();
            mList.Attacked(monster.ID, 10);
        }

        private void btAttack_Click(object sender, EventArgs e)
        {
            monster.Health--;
            mList.Attacked(monster.ID, monster.Health);
            lblHP.Text = $"HP: {monster.Health}";
            if(monster.Health == 0)
            {
                WinScreen wScreen = new WinScreen();
                wScreen.MdiParent = this.MdiParent;
                wScreen.Dock = DockStyle.Fill;
                wScreen.Show();
                mList.Attacked(monster.ID, 10);
                this.Close();
            }
        }
    }
}
