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
    public partial class PracticeMenu : Form
    {
        Player_List pList = new Player_List();
        public PracticeMenu()
        {
            InitializeComponent();
            lblCharacters.Text = pList.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {  
            this.Hide();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            CreatePopUp create = new CreatePopUp(pList);
            create.MdiParent = this.MdiParent;
            create.Dock = DockStyle.None;
            create.PlayerCreated += () =>
            {
                lblCharacters.Text = pList.ToString();
            };
            create.Show();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            DeletePopUp delete = new DeletePopUp(pList);
            delete.MdiParent = this.MdiParent;
            delete.Dock = DockStyle.None;
            delete.PlayerDeleted += () =>
            {
                lblCharacters.Text = pList.ToString();
            };
            delete.Show();
           
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            SelectPopUp select = new SelectPopUp();
            select.MdiParent = this.MdiParent;
            select.Dock = DockStyle.None;
            select.battleStart += () =>
            {
                this.Close();
            };
            select.Show();
        }
    }
}
