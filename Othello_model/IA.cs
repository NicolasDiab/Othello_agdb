using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello_model
{
    public class IA
    {
        private Map map;
        private int playerValue;
        private int depth;
        private int BEST_WHITE;
        private int BEST_BLACK;

        public IA(Map map, int playerValue) :this(map, playerValue, 4) {}

        public IA(Map map, int playerValue, int depth) {
            this.map = map;
            this.playerValue = playerValue;
            this.depth = depth;
            BEST_WHITE = 1;
            BEST_BLACK = 18;
        }

        public int[] play() {
            //var returnedValue = minimax(map, playerValue, this.depth);
            var returnedValue = minmaxAlphaBeta(this.map, this.playerValue,
                this.depth, this.BEST_BLACK, this.BEST_WHITE);
            int theScore = returnedValue.Key;
            int[] theMove = returnedValue.Value;

            if (theMove[0] != -1 && theMove[1] != -1) map.playMove(theMove[0], theMove[1]);
            return theMove;
        }

        // recursive minmax algorithme without alpha beta cutoffs
        // return multiple values of multiple types : int score ; int[] chosenMove
        private KeyValuePair<int, int[]> minmax(Map map, int depth, int maxDepth)
        {
            int[] chosenMove = new int[] { 0, 0 }; // default
            int chosenScore = 0;

            if (depth == maxDepth)
            {
                chosenScore = map.getScore(this.playerValue);
            }
            else {
                List<int[]> moveList = map.findMove(this.playerValue);
                if (moveList.Count == 0)
                {
                    chosenScore = map.getScore(this.playerValue);
                }
                else {
                    int bestScore = 666; //infinity
                    int[] bestMove = new int[] { 0, 0 }; // default

                    bestScore = 666; // infinity

                    for (int i = 1; i < moveList.Count; i++)
                    {

                        Map map2 = (Map)map.Clone();
                        map2.playMove(moveList[i][0], moveList[i][1]);

                        // return 2 values
                        var returnedValue = minimax(map2, depth + 1, maxDepth);
                        int theScore = returnedValue.Key;
                        int[] theMove = new int[] { moveList[i][0], moveList[i][1] };

                        if (theScore < bestScore)
                        {
                            bestScore = theScore;
                            bestMove = theMove;
                        }
                    }
                    chosenScore = bestScore;
                    chosenMove = bestMove;
                }
            }
            // return multiple values : score and chosenMove[]
            return new KeyValuePair<int, int[]>(chosenScore, chosenMove);
        }

        // recursive minmax algorithme with alpha beta cutoffs
        // return multiple values of multiple types : int score ; int[] chosenMove
        private KeyValuePair<int, int[]> minmaxAlphaBeta(Map map, int depth, int maxDepth,
            int blackBest, int whiteBest) {
            int[] chosenMove = new int[] { -1, -1 }; // default move
            int chosenScore = 0;

            if (depth == maxDepth) {
                chosenScore = map.getScore(this.playerValue);
            }
            else {
                List<int[]> moveList = map.findMove(this.playerValue);
                if (moveList.Count == 0) {
                    chosenScore = map.getScore(this.playerValue);
                }
                else {
                    int bestScore = 666; // infinity
                    int[] bestMove = new int[] { -1, -1 }; // default move

                    for (int i = 1; i < moveList.Count; i++) {
                        Map map2 = (Map)map.Clone();
                        map2.playMove(moveList[i][0], moveList[i][1]);

                        // return 2 values
                        var returnedValue = minmaxAlphaBeta(map2, this.depth + 1, maxDepth,
                            blackBest, whiteBest);
                        int theScore = returnedValue.Key;
                        int[] theMove = new int[] { moveList[i][0], moveList[i][1] };

                        // black turn - change score
                        if ((map.getPlayerValue() == -1) && (theScore > blackBest)) {
                            bestMove = theMove;
                            bestScore = blackBest;
                            if (theScore >= whiteBest) break;  //  alpha_beta cutoff
                            else blackBest = theScore;
                            bestMove = theMove;
                            bestScore = blackBest;
                        } // white turn - change score
                        if ((map.getPlayerValue() == 1) && (theScore < whiteBest)) {
                            
                            if (theScore <= whiteBest) break;  //  alpha_beta cutoff
                            else whiteBest = theScore;
                            bestMove = theMove;
                            bestScore = whiteBest;
                        }
                    }
                    chosenScore = bestScore;
                    chosenMove = bestMove;
                }
            }
            // return multiple values : score and chosenMove[]
            return new KeyValuePair<int, int[]>(chosenScore, chosenMove);
        }

        // IA buguéeeee ONE SHOT
        private KeyValuePair<int, int[]> minimaxImpossible(Map map, int depth, int maxDepth)
        {
            int[] chosenMove = new int[] { 0, 0 }; // default
            int chosenScore = 0;

            if (depth == maxDepth) {
                chosenScore = map.getScore(this.playerValue);
            }
            else {
                List<int[]> moveList = map.findMove(this.playerValue);
                if (moveList.Count == 0) {
                    chosenScore = map.getScore(this.playerValue);
                }
                else {
                    int bestScore = 666; //infinity
                    int[] bestMove = new int[] { 0, 0 }; // default

                    for (int i = 1; i < moveList.Count; i++) {
                        bestScore = 666; // infinity

                        Map map2 = map;
                        map2.playMove(moveList[i][0], moveList[i][1]);

                        // return 2 values
                        var returnedValue = minimaxImpossible(map2, depth + 1, maxDepth);
                        int theScore = returnedValue.Key;
                        int[] theMove = returnedValue.Value;
                        
                        if (theScore < bestScore) {
                            bestScore = theScore;
                            bestMove = theMove;
                        }
                    }
                    chosenScore = bestScore;
                    chosenMove = bestMove;
                }
            }
            // return multiple values : score and chosenMove[]
            return new KeyValuePair<int, int[]>(chosenScore, chosenMove);
        }

    }
}
