using DungeonCrawler.BA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler.FE
{
    public partial class DeletePopUp : Form
    {
        Player_List pList;
        public event Action PlayerDeleted;
        public DeletePopUp(Player_List pList)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pList = pList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id)) 
            {
                if (pList.Delete(id))
                {
                   
                    PlayerDeleted?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Player with specified ID not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID");
            }
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
