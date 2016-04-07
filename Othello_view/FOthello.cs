using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Othello_model;

namespace Othello_view
{
    public partial class FOthello : Form
    {
        private Map map;
        public int free;
        public int mode;
        public int lastPlayed;

        
        public FOthello()
        {
            InitializeComponent();
            free = 64;
            mode = 1;
            lastPlayed = -1;
        }

        private void FOthello_Load(object sender, EventArgs e)
        {
            initializeInterface();
        }

        
        public void initializeInterface()
        {
            // ajuste la taille des cases
            // Hauteur
            dgv.Rows[0].Height = 60;
            // Largeur
            for (int i = 0; i <= 7; i++)
            {
                dgv.Columns[i].Width = 60;
            }

            // ajout de 8x8 cases
            DataGridViewRow row;
            for (int i = 0; i <= 6; i++)
            {
                row = (DataGridViewRow)dgv.Rows[i].Clone();
                dgv.Rows.Add(row);
            }

            // Remplit la matrice de 0
            map = new Map();
            refresh();
        }



        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = e.ColumnIndex;
            int i = e.RowIndex;
            LBTest.Text = " x:" + j + "  y:" + i;
            dgv.ClearSelection();

            if (map.getMatrix()[i, j] == 0)
            {
                if (lastPlayed == -1) map.playMove(1,i,j); else map.playMove(-1, i, j);
                lastPlayed = -lastPlayed;

                free--;
                if (mode != 0)
                {
                    /*if (free > 0 && othello.computeWin() == 0)
                    {
                        // Choix IA
                        othello.computeChoice();
                        free--;
                    }*/
                }
                refresh();
                printWinner();
            }
        }

        private void refresh() {
            printPlayerInfo();
            dgv.ClearSelection();
            colorizeBoard();
            colorizePlayableSpace(-lastPlayed);
        }
        


        // Colorise le plateau de jeu
        private void colorizeBoard()
        {
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (map.getMatrix()[i, j] == 1)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Aqua;
                    }
                    if (map.getMatrix()[i, j] == 0)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                    else if (map.getMatrix()[i, j] == -1)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void colorizePlayableSpace(int playerValue) {
            foreach (int[] position in map.findMove(playerValue)) {
                dgv.Rows[position[0]].Cells[position[1]].Style.BackColor = Color.Green;
                dgv.Rows[position[0]].Cells[position[1]].Style.ForeColor = Color.Green;
            }
        }

        // colore les bordures du dgv
        private void dgv_Paint(object sender, PaintEventArgs e)
        {
            Point currentPoint = new Point(0, 0);
            Size size = new Size(60, 60);
            Pen myPen = new Pen(Color.Red, 3);

            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    currentPoint.X = i * 60;
                    currentPoint.Y = j * 60;
                    Rectangle rect = new Rectangle(currentPoint, size);
                    e.Graphics.DrawRectangle(myPen, rect);
                }
            }
        }

        public void printPlayerInfo()
        {
            string player = (lastPlayed == 1 ? "noir" : "bleu");
            txbJoueur.Text = "Joueur " + player + " joue";
            txbScoreBlue.Text = ""+map.getScore(1);
            txbScoreBlack.Text = ""+map.getScore(-1);
        }

        // remet le plateau de jeu à 0
        private void resetJeu()
        {
            free = 64;

            // Remplit la matrice de 0
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    map.getMatrix()[i, j] = 0;
                }
            }

            // Supprime les lignes
            // ajoute les lignes
            for (int i = 0; i <= 7; i++)
            {
                dgv.Rows.RemoveAt(0);
                dgv.Rows.Add();
            }

            for (int i = 0; i <= 7; i++)
            {
                dgv.Rows[i].Height = 60;
            }

            dgv.ClearSelection();
        }

        private void printWinner()
        {
            if (free == 0)
            {

                /*if (winner == 0 && free == 0)
                {
                    MessageBox.Show("Egalité");
                    resetJeu();
                }
                else if (winner == 1)
                {
                    MessageBox.Show("Joueur 1 gagne");
                    resetJeu();
                }
                else if (winner == -1)
                {
                    MessageBox.Show("Joueur 2 gagne");
                    resetJeu();
                }*/
            }

        }

        // menus
        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void joueurVsJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void joueurVsIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void iAVsIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 3;
        }
    }
}
