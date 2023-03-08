using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDesktopAppLogic
{
    public class LoveFinderTriviaStatistic
    {
        public int MatchPercentage  { get; set; }

        public string MatchedFriendName { get; set; }

        public DateTime PlayingDate { get; set; }

        public LoveFinderTriviaStatistic()
        {
        }

        public override string ToString()
        {
            return $"{PlayingDate.ToShortDateString()}: {MatchedFriendName} - {MatchPercentage}%";
        }

    }
}
