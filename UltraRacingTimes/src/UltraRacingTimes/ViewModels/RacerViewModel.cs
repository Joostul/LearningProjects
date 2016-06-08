using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UltraRacingTimes.ViewModels
{
    public class RacerViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Nickname { get; set; }
    }
}
