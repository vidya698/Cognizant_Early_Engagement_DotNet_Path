using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam1
{
    public class Delivery
    {
        private long _over;
        private long _ball;
        private long _runs;
        private string _nonStriker;
        private string _batsman;
        private string _bowler;

        public long Over { get => _over; set => _over = value; }
        public long Ball { get => _ball; set => _ball = value; }
        public long Runs { get => _runs; set => _runs = value; }
        public string NonStriker { get => _nonStriker; set => _nonStriker = value; }
        public string Batsman { get => _batsman; set => _batsman = value; }
        public string Bowler { get => _bowler; set => _bowler = value; }

        public Delivery(long over, long balls, long runs, string nonStricker, string batsman, string bowler)
        {
            Over = over;
            Ball = balls;
            Runs = runs;
            NonStriker = nonStricker;
            Batsman = batsman;
            Bowler = bowler;
        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}", Over, Ball, Runs, NonStriker, Batsman, Bowler);
        }
    }
}
