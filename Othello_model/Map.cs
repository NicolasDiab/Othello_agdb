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
            List<int[]> spacesPlayabe = new List<int[]>();
            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    int[] position = new int[] { l, c };
                    if (spacePlayable(position, playerValue)) {
                        spacesPlayabe.Add(position);
                    }
                }
            }
            return spacesPlayabe;
        }

        private bool spacePlayable(int[] position, int playerValue) {
            if (matrix[position[0], position[1]] != 0) {
                return false;
            }
            return testLine(position, (new int[] { 0, 1 }), playerValue) || 
                testLine(position, (new int[] { 1, 1 }), playerValue) ||
                testLine(position, (new int[] { 1, 0 }), playerValue) ||
                testLine(position, (new int[] { 1, -1 }), playerValue) ||
                testLine(position, (new int[] { 0, -1 }), playerValue) ||
                testLine(position, (new int[] { -1, -1 }), playerValue) ||
                testLine(position, (new int[] { -1, 0 }), playerValue) ||
                testLine(position, (new int[] { -1, 1 }), playerValue);
        }

        private bool testLine(int[] position, int[] direction, int playerValue) {
            int nextX = position[0] + direction[0];
            int nextY = position[1] + direction[1];
            bool test = validPoint(nextX, nextY);
            
            if (!test){
                return false;
            }
            if (matrix[nextX, nextY] == playerValue * -1) {                
                while (true) {
                    nextX = nextX + direction[0];
                    nextY = nextX + direction[1];
                    test = validPoint(nextX, nextY);
                    if (test){
                        if (matrix[nextX, nextY] == playerValue) {
                            return true;
                        }
                        if (matrix[nextX, nextY] == 0)
                        {
                            return false;
                        }
                    } else {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool validPoint(int x, int y) {
            if ((x >= 0 && x < 8) && (y >= 0 && y < 8)) {
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
