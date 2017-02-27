using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEnvironment.Models
{
    public class Rounds
    {
        public int MaxPairs { get; set; }
        public int RoundId { get; set; }
        private List<Pairs> pairList = new List<Pairs>();

        public void addPair(string player1, string player2) {
            Pairs temp = new Pairs();
            temp.Player1 = player1;
            temp.Player2 = player2;
            temp.PairId = temp.PairId + 1;
            pairList.Add(temp);
        }
        public void removePair(int pairId) {
            pairList.RemoveAt(pairId);
        }
        public Pairs getPairs(int pairId) {
            return pairList[pairId];
        }
    }
}
