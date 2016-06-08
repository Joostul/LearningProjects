using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltraRacingTimes.Models
{
    public class Racetime
    {
        public int Id { get; set; }
        public Racer Racer { get; set; }
        public Racetrack Racetrack { get; set; }
        public Car Car { get; set; }
        public TimeSpan Racingtime { get; set; }
        public bool AchievedAlone { get; set; }
    }
}
