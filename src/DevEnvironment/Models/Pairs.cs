using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevEnvironment.Models
{
    public class Pairs
    {
        public int PairId { get; set; }
        public Participant Player1 { get; set; }
        public Participant Player2 { get; set; }
    }
}
