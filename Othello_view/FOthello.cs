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
        // Variables
        private int[,] matrix;

        
        // Fonctions générées
        public FOthello()
        {
            InitializeComponent();
        }

        private void FOthello_Load(object sender, EventArgs e)
        {
            initialiserInterface();
        }


        // Fonctions créées
        public void initialiserInterface()
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

        // fail
        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
