using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task_1
{
    public partial class frmUI : Form
    {
        public frmUI()
        {
            InitializeComponent();
        }

        GameEngine game = new GameEngine();

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PlayerUI_Load(object sender, EventArgs e)
        {
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
            fillEnemyBox();
            LoadButtons();
            CheckCost();
            EnemycomboBox.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillEnemyBox()
        {
            EnemycomboBox.Items.Clear();
            for (int i = 0; i < game.GetMap.GetEnemies.Length; i++)
            {
                EnemycomboBox.Items.Add(game.GetMap.GetEnemies[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            game.MovePlayer(movementEnum.Up);
            methods();
        }

        private void bttnDown_Click(object sender, EventArgs e)
        {
            
            game.MovePlayer(movementEnum.Down);
            methods();
        }

        private void bttnRight_Click(object sender, EventArgs e)
        {
            
            game.MovePlayer(movementEnum.Right);
            methods();
        }

        private void bttnLeft_Click(object sender, EventArgs e)
        {
            game.MovePlayer(movementEnum.Left);
            methods();
        }

        private void methods()
        {
            game.GetMap.UpdateGame();
            game.MoveEnemies(movementEnum.NoMovement);
            game.GetMap.UpdateGame();
            game.EnemyAttack();
            game.GetMap.UpdateGame();
            fillEnemyBox();
            game.GetMap.UpdateGame();
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
            LoadButtons();
            CheckCost();
            EnemycomboBox.SelectedIndex = 0;
        }
        private void bttnAttack_Click(object sender, EventArgs e)
        {
            rchtTxtBxLog.Text = game.PlayerAttack(EnemycomboBox.SelectedIndex);
            fillEnemyBox();
            methods();
        }

        private void LoadButtons()
        {
            bttnFirst.Text = game.GetShop.DisplayWeapon(0);
            bttnSecond.Text = game.GetShop.DisplayWeapon(1);
            bttnThird.Text = game.GetShop.DisplayWeapon(2);
        }

        private void CheckCost()
        {
            for (int i = 0; i < 3; i++)
            {
                if (game.GetShop.CanBuy(game.GetMap.GetPlayer.getpurse, i))
                    {
                    switch (i)
                    {
                        case 0:
                            bttnFirst.Enabled = true;
                            break;
                        case 1:
                            bttnSecond.Enabled = true;
                            break;
                        case 2:
                            bttnThird.Enabled = true;
                            break;
                    }

                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            bttnFirst.Enabled = false;
                            break;
                        case 1:
                            bttnSecond.Enabled = false;
                            break;
                        case 2:
                            bttnThird.Enabled = false;
                            break;
                    }
                }

            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            game.GetShop.Buy(game.GetMap.GetPlayer.getpurse, 0);
            LoadButtons();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.GetShop.Buy(game.GetMap.GetPlayer.getpurse, 1);
            LoadButtons();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnThird_Click(object sender, EventArgs e)
        {
            game.GetShop.Buy(game.GetMap.GetPlayer.getpurse, 2);
            LoadButtons();
        }
    }
}
