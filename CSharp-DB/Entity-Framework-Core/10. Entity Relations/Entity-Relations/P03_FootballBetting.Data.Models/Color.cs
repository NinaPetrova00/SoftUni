﻿namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Color
    {
        public Color()
        {
            this.PrimaryKitTeams = new HashSet<Team>();
            this.SecondaryKitTeams = new HashSet<Team>();
        }
        [Key]
        public int ColorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //•	A Color has many PrimaryKitTeams and many SecondaryKitTeams

        [InverseProperty("PrimaryKitColor")]
        public virtual ICollection<Team> PrimaryKitTeams { get; set; }

        [InverseProperty("SecondaryKitColor")]
        public virtual ICollection<Team> SecondaryKitTeams { get; set; }

    }
}
