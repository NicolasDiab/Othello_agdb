﻿using System;
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
        public int mode;
        public int difficulty;
        public IA ia;
        private List<int[]> nextAbleMove;

        
        public FOthello()
        {
            InitializeComponent();
            mode = 1;
            difficulty = 4;
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
            dgv.ClearSelection();
            if (map.getMatrix()[i, j] == 0)
            {
                if (map.isPlayableMove(map.getPlayerValue(), i, j)) {
                    HumanPlay(i, j);
                    refresh();
                    printWinner();

                    switch (mode)
                    {
                        case 2:
                            modPlayerVSIA();
                            break;
                        case 3:
                            modIAVSIA();
                            break;
                    }
                }
            }
            if (map.getNbFreeSpace() == 0) {
                MessageBox.Show("Joueur " + ((map.getScore(1) > map.getScore(-1)) ? "1" : "2") + " a gagné");
            } else if (nextAbleMove.Count == 0) {
                MessageBox.Show("Vous ne pouvez pas jouer !!");
                map.passMove();
                refresh();
            }
        }

        public void modPlayerVSIA() {
            if (map.getNbFreeSpace() > 0)
            {
                ComputerPlay();
                refresh();
                printWinner();
            }
        }
        public void modIAVSIA() { }

        private void HumanPlay(int i, int j) {
            map.playMove(i, j);
        }

        private void ComputerPlay() {
            if (map.findMove(map.getPlayerValue()).Count > 0)
            {
                int player = map.getPlayerValue();
                int[] move  = ia.play();
            }
            else {
                map.passMove();
            }
            
            
        }

        private void refresh() {
            printPlayerInfo();
            dgv.ClearSelection();
            colorizeBoard();
            nextAbleMove = map.findMove(map.getPlayerValue());
            colorizePlayableSpace(nextAbleMove);
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
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                    if (map.getMatrix()[i, j] == 0)
                    {
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgv.Columns[j];
                        c.FlatStyle = FlatStyle.Popup;
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Green;
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

        private void colorizePlayableSpace(List<int[]>move) {
            foreach (int[] position in move) {
                dgv.Rows[position[0]].Cells[position[1]].Style.BackColor = Color.OrangeRed;
                dgv.Rows[position[0]].Cells[position[1]].Style.ForeColor = Color.OrangeRed;
            }
        }

        // colore les bordures du dgv
        private void dgv_Paint(object sender, PaintEventArgs e)
        {
            Point currentPoint = new Point(0, 0);
            Size size = new Size(60, 60);
            Pen myPen = new Pen(Color.Gray, 3);

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
            string player = (map.getPlayerValue() == 1 ? "blanc" : "noir");
            txbJoueur.Text = "Joueur " + player + " joue";
            txbScoreBlue.Text = ""+map.getScore(1);
            txbScoreBlack.Text = ""+map.getScore(-1);
        }

        // remet le plateau de jeu à 0
        private void resetJeu()
        {


            this.map = new Map();

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
            if (map.getNbFreeSpace() == 0)
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
            resetJeu();
            refresh();
        }

        private void joueurVsIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 2;            
            resetJeu();
            ia = new IA(map, -1);
            refresh();
        }


        private void btnSurrend_Click(object sender, EventArgs e)
        {
            resetJeu();
            refresh();
            MessageBox.Show("PLEUTRE");
        }

        private void eventSetDifficulty(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int.TryParse(item.Text, out difficulty);
            resetJeu();
            refresh();
            ia = new IA(map, -1,difficulty); 
        }

    }
}
