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
        private int depth_const;
        private int BEST_WHITE;
        private int BEST_BLACK;

        public IA(Map map, int playerValue) :this(map, playerValue, 4) {}

        public IA(Map map, int playerValue, int depth) {
            this.map = map;
            this.playerValue = playerValue;
            this.depth_const = depth;
            BEST_WHITE = 18;
            BEST_BLACK = 1;
        }

        public int[] play() {
            var returnedValue = minmaxAlex(map, 4/*this.depth_const*/);

            //var returnedValue = minmaxAlphaBeta(this.map, this.playerValue,
            //    depth_const, this.BEST_BLACK, this.BEST_WHITE);

            int theScore = returnedValue.Key;
            int[] theMove = returnedValue.Value;

            if (theMove[0] != -1 && theMove[1] != -1) map.playMove(theMove[0], theMove[1]);
            else map.passMove();
            return theMove;
        }


        // recursive minmax algorithme without alpha beta cutoffs
        // return multiple values of multiple types : int score ; int[] chosenMove
        private KeyValuePair<int, int[]> minmax(Map map, int depth, int maxDepth)
        {
            int[] chosenMove = new int[] { -1, -1 }; // default
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
                    int[] bestMove = new int[] { -1, -1 }; // default

                    for (int i = 1; i < moveList.Count; i++) {

                        Map map2 = (Map)map.Clone();
                        map2.playMove(moveList[i][0], moveList[i][1]);

                        // return 2 values
                        var returnedValue = minmax(map2, depth + 1, maxDepth);
                        int theScore = returnedValue.Key;
                        int[] theMove = new int[] { moveList[i][0], moveList[i][1] };

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
                        var returnedValue = minmaxAlphaBeta(map2, depth /*this.depth + 1 (erreur possible )*/, maxDepth,
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
                            bestMove = theMove;
                            bestScore = whiteBest;
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

        // recursive minmax algorithme without alpha beta cutoffs
        // return multiple values of multiple types : int score ; int[] chosenMove
        private KeyValuePair<int, int[]> minmaxAlex(Map map, int depth)
        {
            int[] chosenMove = new int[] { -1, -1 }; // default
            int chosenScore = 0;

            if (!(depth > 0) || map.getNbFreeSpace() == 0 /* End Game */)
            {
                chosenScore = evaluation(map);

            }
            else
            {
                List<int[]> moveList = map.findMove(this.playerValue);
                if (moveList.Count == 0)
                {
                    //chosenScore = (map.getPlayerValue()==this.playerValue)?-200:200; //Pas de cout possible valeur du coups précédent faible //map.getScore(this.playerValue);
                    Map map2 = (Map)map.Clone();
                    map.passMove();
                    var returnedValue = minmaxAlex(map2, depth--);
                    chosenScore += returnedValue.Key;
                }
                else
                {
                    int bestScore = -999999; 
                    int[] bestMove = new int[] { moveList[0][0], moveList[0][1] }; // default first move possible

                    for (int i = 1; i < moveList.Count; i++)
                    {

                        Map map2 = (Map)map.Clone();
                        map2.playMove(moveList[i][0], moveList[i][1]);

                        // return 2 values
                        var returnedValue = minmaxAlex(map2, depth-1);
                        int theScore = returnedValue.Key;
                        int[] theMove = new int[] { moveList[i][0], moveList[i][1] };

                        if (theScore > bestScore)
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

        private int evaluation(Map map) {            
            int computeScore = 0;
            if (map.getNbFreeSpace() == 0)
            {
                int[] mapScore = map.getScore();
                if (playerValue == -1)
                {
                    if (mapScore[1] > mapScore[0])
                    { // Victory computer
                        computeScore = 10000 + mapScore[1] - mapScore[0];
                    }
                    else
                    { //lose or draw
                        computeScore = -10000 + mapScore[1] - mapScore[0];
                    }
                }
                else
                {
                    if (mapScore[1] < mapScore[0])
                    { // Victory computer
                        computeScore = 10000 + mapScore[1] - mapScore[0];
                    }
                    else
                    { //lose or draw
                        computeScore = -10000 + mapScore[1] - mapScore[0];
                    }
                }
            }
            else {
                int[] mapScore = map.evaluation();
                if (playerValue == -1)
                {
                    computeScore =  mapScore[1] - mapScore[0];
                }
                else
                {
                    computeScore = mapScore[0] - mapScore[1];
                }
            }
            return computeScore;
        }

    }
}
