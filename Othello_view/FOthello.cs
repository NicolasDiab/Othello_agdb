using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello_view
{
    public partial class FOthello : Form
    {
        private int[,] matrix;
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
            matrix = new int[8, 8];
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }



        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = e.ColumnIndex;
            int i = e.RowIndex;

            dgv.ClearSelection();

            if (matrix[i, j] == 0)
            {
                if (lastPlayed == -1) matrix[i, j] = 1; else matrix[i, j] = -1;
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
                colorizeBoard();
                printWinner();
            }
        }
        


        // Colorise le plateau de jeu
        private void colorizeBoard()
        {
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Aqua;
                    }
                    else if (matrix[i, j] == -1)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
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

        // remet le plateau de jeu à 0
        private void resetJeu()
        {
            free = 64;

            // Remplit la matrice de 0
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    matrix[i, j] = 0;
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
            /*int winner = othello.computeWin();
            if (winner == 0 && free == 0)
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
