using DungeonCrawler.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler.FE
{
    public partial class MDIContainer : Form
    {
        public MDIContainer()
        {
            InitializeComponent();
            this.IsMdiContainer = true;    
            MainMenu mainMenu = new MainMenu();
            mainMenu.MdiParent = this;
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Show();
        }

    }
}
