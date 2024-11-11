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

namespace DungeonCrawler.FE
{
    public partial class CreatePopUp : Form
    {
        Player_List pList;
        public event Action PlayerCreated;
        public CreatePopUp(Player_List pList)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pList = pList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player(0, txtName.Text, 0, 1, 0, 10, 10, 10, 10, 10, 1, 1, cbClass.Text);

            pList.Insert(player);

            PlayerCreated?.Invoke();
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
