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

        }
        public void removePair(int pairId) {

        }
    }
}
