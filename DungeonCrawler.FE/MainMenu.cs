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

namespace DungeonCrawler.FE
{
    public partial class MainMenu : Form
    {
        public SoundPlayer player;

        public MainMenu()
        {
            InitializeComponent();
            player = new SoundPlayer(@"Resources\Music\Debussy _ Arabesque No. 1.WAV");
            player.PlayLooping();
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
