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
            this.matrix[4, 4] = 1;
            this.matrix[5, 5] = 1;
            this.matrix[4, 5] = -1;
            this.matrix[5, 4] = -1;
        }

        public List<int[]> findMove(int playerValue) {

            return null;
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
