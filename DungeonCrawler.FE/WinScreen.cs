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
    public partial class WinScreen : Form
    {
        public SoundPlayer player;
        public WinScreen()
        {
            InitializeComponent();
            player = new SoundPlayer(@"Resources\Music\16OldFrenchSong.WAV");
            player.PlayLooping();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(@"Resources\Music\Debussy _ Arabesque No. 1.WAV");
            player.PlayLooping();
            this.Close();
        }
    }
}
