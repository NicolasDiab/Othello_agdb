using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello_model
{
    public class Map
    {
        private int[,] matrix;

        public Map(int[,] matrix) {
            this.matrix = matrix;
        }

        public Map() {
            this.matrix = new int[8, 8];
            this.matrix[3, 3] = 1;
            this.matrix[4, 4] = 1;
            this.matrix[3, 4] = -1;
            this.matrix[4, 3] = -1;
        }

        public List<int[]> findMove(int playerValue) {
            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; l < 8; c++)
                {
                    
                }
            }
            return null;
        }

        private bool spacePlayable(int[] vecteur) {
            if (matrix[vecteur[0], vecteur[1]] != 0) {
                return false;
            }


            return true;//testLine(vecteur,
        }

        private bool testLine(int[] vecteur, int[] direction, int value) {
            int nextX = vecteur[0] + direction[0];
            int nextY = vecteur[1] + direction[1];
            bool test = validPoint(nextX, nextY);
            if (test & matrix[nextX, nextY] == value * -1) {                
                while (true) {
                    nextX = nextX + direction[0];
                    nextY = nextX + direction[1];
                    if (!validPoint(nextX, nextY)){
                        if (matrix[nextX, nextY] == value) {
                            return false;
                        }
                        if (matrix[nextX, nextY] == 0)
                        {
                            return true;
                        }
                    } else {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool validPoint(int x, int y) {
            if ((x >= 0 & x < 8) & (y >= 0 & x < 8)) {
                return true;
            }
            return false;
        }

        public void playMove(int value, int x, int y) {
            matrix[x,y] = value;
        }

        public int getScore(int playerValue) {
            int score = 0;
            for (int l = 0; l < 8; l++) {
                for (int c = 0; l < 8; c++) {
                    if (matrix[l,c] == playerValue) {
                        score++;
                    }
                }                
            }
            return score;
        }

        public int[,] getMatrix() {
            return matrix;
        }

    }
}
