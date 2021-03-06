﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello_model
{
    public class Map : ICloneable
    {
        private List<int[]> moves; // move[0] = player -1 | 1 move[1] = x | move[2] = y
        private int[,] matrix;
        private int playerValue;

        public Map(int[,] matrix)
        {
            this.matrix = matrix;
            this.moves = new List<int[]>();
            this.playerValue = 1;
        }

        public Map()
        {
            this.matrix = new int[8, 8];
            this.matrix[3, 3] = 1;
            this.matrix[4, 4] = 1;
            this.matrix[3, 4] = -1;
            this.matrix[4, 3] = -1;
            this.playerValue = 1;
            this.moves = new List<int[]>();
        }

        public List<int[]> findMove(int playerValue)
        {
            List<int[]> spacesPlayabe = new List<int[]>();
            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    int[] position = new int[] { l, c };
                    if (spacePlayable(position, playerValue))
                    {
                        spacesPlayabe.Add(position);
                    }
                }
            }
            return spacesPlayabe;
        }

        public bool isPlayableMove(int playerValue, int x, int y)
        {
            foreach (int[] move in findMove(playerValue))
            {
                if (move[0] == x && move[1] == y)
                    return true;
            }
            return false;
        }

        private bool spacePlayable(int[] position, int playerValue)
        {
            if (matrix[position[0], position[1]] != 0)
            {
                return false;
            }

            foreach (int[] direction in getDirections())
            {
                if (testLine(position, direction, playerValue))
                    return true;
            }
            return false;
        }

        private bool testLine(int[] position, int[] direction, int playerValue)
        {
            int nextX = position[0] + direction[0];
            int nextY = position[1] + direction[1];
            bool test = validPoint(nextX, nextY);

            if (!test)
            {
                return false;
            }
            if (matrix[nextX, nextY] == playerValue * -1)
            {
                while (true)
                {
                    nextX = nextX + direction[0];
                    nextY = nextY + direction[1];
                    test = validPoint(nextX, nextY);
                    if (test)
                    {
                        if (matrix[nextX, nextY] == playerValue)
                        {
                            return true;
                        }
                        if (matrix[nextX, nextY] == 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool validPoint(int x, int y)
        {
            if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
            {
                return true;
            }
            return false;
        }

        public void playMove(int x, int y)
        {
            if (!validPoint(x, y))
            {
                throw new Exception();
            }
            matrix[x, y] = playerValue;
            this.moves.Add(new int[] { playerValue, x, y });
            computeStoneSteal(playerValue, x, y);
            this.playerValue = -this.playerValue;
        }

        public void passMove()
        {
            this.playerValue = -this.playerValue;
        }

        private void computeStoneSteal(int playerValue, int x, int y)
        {
            int[] position = new int[] { x, y };
            foreach (int[] direction in getDirections())
            {
                if (testLine(position, direction, playerValue))
                {
                    stealLine(position, direction, playerValue);
                }

            }
        }

        private void stealLine(int[] position, int[] direction, int playerValue)
        {
            int nextX = position[0];
            int nextY = position[1];

            bool test = true;
            while (test)
            {
                nextX = nextX + direction[0];
                nextY = nextY + direction[1];
                if (matrix[nextX, nextY] == -playerValue)
                {
                    matrix[nextX, nextY] = playerValue;
                }
                else
                {
                    test = false;
                }

            }
        }

        public int getScore(int playerValue)
        {
            int score = 0;
            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (matrix[l, c] == playerValue)
                    {
                        score++;
                    }
                }
            }
            return score;
        }
        public int[] getScore()
        {
            int[] score = new int[] { 0, 0 };

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (matrix[l, c] == 1) { score[0]++; }
                    else if (matrix[l, c] == -1) { score[1]++; }
                }
            }
            return score;
        }


        public int getPlayerValue()
        {
            return this.playerValue;
        }

        public int[,] getMatrix()
        {
            return matrix;
        }

        public List<int[]> getDirections()
        {
            List<int[]> direction = new List<int[]>();

            direction.Add(new int[] { 0, 1 });
            direction.Add(new int[] { 1, 1 });
            direction.Add(new int[] { 1, 0 });
            direction.Add(new int[] { 1, -1 });
            direction.Add(new int[] { 0, -1 });
            direction.Add(new int[] { -1, -1 });
            direction.Add(new int[] { -1, 0 });
            direction.Add(new int[] { -1, 1 });
            return direction;
        }

        public int getNbFreeSpace()
        {
            return getScore(0);
        }

        public Object Clone()
        {
            return new Map((int[,])matrix.Clone());
        }

        public int[] evaluation()
        {
            int[,] matixEval = new int[,] {    { 500,  -150, 30, 10, 10, 30,  -150,500},
                                               {  -150, -250,  0, 0, 0,  0, -250,  -150},
                                               { 30,   0,  1, 2, 2,  1,   0,  30},
                                               { 10,   0,  2, 16, 16,  2,   0,   10},
                                               { 10,   0,  2, 16, 16,  2,   0,   10},
                                               { 30,   0,  1, 2, 2,  1,   0,  30},
                                               {  -150, -250,  0, 0, 0,  0, -250, -150},
                                               { 75,  -150, 30, 10, 10, 30,  -150, 500},};
            int[] score = new int[] { 0, 0 };

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (matrix[l, c] == 1) { score[0] += matixEval[l, c]; }
                    else if (matrix[l, c] == -1) { score[1] += matixEval[l, c]; }
                }
            }
            return score;
        }
    }
}
