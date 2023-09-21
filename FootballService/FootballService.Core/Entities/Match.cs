using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballService.Core.Entities
{
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime MatchDateTime { get; set; } 

        [Display(Name = "Stadium")]
        public int StadiumId { get; set; }
        public Stadium Stadium { get; set; }

        [Display(Name = "Home Team")]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        [Display(Name = "Away Team")]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

       
    }


}
