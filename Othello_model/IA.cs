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

        public IA(Map map, int playerValue) {
            this.map = map;
            this.playerValue = playerValue;
        }

        public void play() {
            var returnedValue = minimax(map, 0, 5);
            int theScore = returnedValue.Key;
            int[] theMove = returnedValue.Value;

            map.playMove(playerValue, theMove[0], theMove[1]);
        }

        // return multiple values : score and chosenMove[]
        private KeyValuePair<int, int[]> minimax(Map map, int depth, int maxDepth)
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
                        map2.playMove(playerValue, moveList[i][0], moveList[i][1]);

                        // return 2 values
                        var returnedValue = minimax(map2, depth + 1, maxDepth);
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
