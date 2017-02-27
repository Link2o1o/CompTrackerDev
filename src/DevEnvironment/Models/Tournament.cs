using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEnvironment.Models
{
    public class Tournament
    {
        public int MaxRounds { get; set; }
        private List<Rounds> roundsList = new List<Rounds>();

    }
}
