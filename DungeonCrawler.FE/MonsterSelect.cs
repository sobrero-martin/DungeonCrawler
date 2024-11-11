using DungeonCrawler.BA;
using System;
using System.Collections;
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
    public partial class MonsterSelect : Form
    {
        int pID;
        int mID = 0;
        Monster_List mList = new Monster_List();
        public event Action battleStart;
        public MonsterSelect(int pID)
        {
            InitializeComponent();
            this.pID = pID;
            if(mList.Read(0) == null)
            {
                Monster skeleton = new Monster(1, "SKELETON", "A RELENTLESS UNDEAD WARRIOR...", 1, 10, 0);
                mList.Insert(skeleton);
            }
            lblMonsters.Text = mList.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (mList.Read(id) != null)
                {
                    mID = Convert.ToInt32(txtID.Text);
                    PracticeBattle pBattle = new PracticeBattle(pID, mID);
                    pBattle.MdiParent = this.MdiParent;
                    pBattle.Dock = DockStyle.Fill;
                    pBattle.Show();
                    battleStart?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Monster with specified number not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
