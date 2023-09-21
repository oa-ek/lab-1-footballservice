using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Core.Entities
{
    public class Team
    {
        //треба додати лого для команди

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        [Display(Name = "Year Founded")]
        public int YearFounded { get; set; }

        public List<Player> Players { get; set; }
        public List<Coach> Coaches { get; set; }
        public ICollection<TournamentTable> TournamentTables { get; set; }


    }
}
