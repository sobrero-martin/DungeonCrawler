﻿using DungeonCrawler.BA;
using System;
using System.Collections;
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
    public partial class SelectPopUp : Form
    {
        int pID = 0;
        Player_List pList = new Player_List();
        public event Action battleStart;
        public SelectPopUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (pList.Read(id) != null)
                {
                    pID = Convert.ToInt32(txtID.Text);
                    MonsterSelect mSelect = new MonsterSelect(pID);
                    mSelect.MdiParent = this.MdiParent;
                    mSelect.Dock = DockStyle.Fill;
                    mSelect.Show();
                    mSelect.battleStart += () =>
                    {
                        battleStart?.Invoke();
                        this.Close();
                    };
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
    }
}