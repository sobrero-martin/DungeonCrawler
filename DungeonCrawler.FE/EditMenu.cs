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
    public partial class EditMenu : Form
    {
        public EditMenu()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditWeap_Click(object sender, EventArgs e)
        {
            EditWeapons editWeapons = new EditWeapons();
            editWeapons.MdiParent = this.MdiParent;
            editWeapons.Dock = DockStyle.Fill;
            editWeapons.Show();
        }
    }
}
