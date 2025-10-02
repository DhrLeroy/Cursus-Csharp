using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Toets
    {
        public string Naam { get; set; }
        public int Maximum { get; set; }
        public int Behaalde_score { get; private set; }

        public void VulScoreIn(int score)
        {
            if(score <= Maximum)
                Behaalde_score = score;
        }
    }
}
