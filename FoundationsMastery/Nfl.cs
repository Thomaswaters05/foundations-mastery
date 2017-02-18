using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Nfl
    {
        public string Slogan { get; set; }
        public string Mascot { get; set; }
        public string Color { get; set; }
        public string Conference { get; set; }

        public virtual void TeamSlogan()
        {
           Slogan = "NFL ROCKS!";
        }

        public virtual void PickColor ()
        {
            Color = "All Different Team Colors";
        }
            
        public virtual void SetConference()
        {
            Conference = "American Football Conference";
        }
    }

}
