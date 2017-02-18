using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class TnTitans : Nfl
    {
        public int Rank { get; set; }

       public void TeamRank()
        {
            this.Rank = 19;
        }
       public override void TeamSlogan ()
        {
            this.Slogan = "Titan Up!";

        }

        public override void SetConference()
        {
            this.Conference = "AFC South";
        }


    }
}
