using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Core.Entities
{
    public class TournamentTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TournamentId { get; set; } 

        [Required]
        public int TeamId { get; set; } 

        [Required]
        public int Points { get; set; } 

        [Required]
        public int GoalsScored { get; set; } 

        [Required]
        public int GoalsConceded { get; set; } 

        

        public Tournament Tournament { get; set; } // Зв'язок з турніром
        public Team Team { get; set; } // Зв'язок з командою
    }

}
