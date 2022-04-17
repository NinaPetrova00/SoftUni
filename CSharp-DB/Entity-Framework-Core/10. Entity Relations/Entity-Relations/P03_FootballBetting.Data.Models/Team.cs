namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Team
    {
        public Team()
        {
            this.HomeGames = new HashSet<Game>();
            this.AwayGames = new HashSet<Game>();
            this.Players = new HashSet<Player>();
        }

        [Key]
        public int TeamId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(2048)]
        public string LogoUrl { get; set; }

        // required: пише се само за типовете, които са nullable: string,object....
        // int, decimal, double -> required by default
        [Required]
        [MaxLength(4)]
        public string Initials { get; set; }

        //decimal? = decimal nullable
        public decimal Budget { get; set; }

        //•	A Team has one PrimaryKitColor and one SecondaryKitColor
        // Write navigational properties: 
        //PK, който сочи към таблицата COLOR

        [ForeignKey(nameof(PrimaryKitColor))]
        public int PrimaryKitColorId { get; set; }
        public virtual Color PrimaryKitColor { get; set; }

        [ForeignKey(nameof(SecondaryKitColor))]
        public int SecondaryKitColorId { get; set; }
        public virtual Color SecondaryKitColor { get; set; }

        //•	A Team residents in one Town

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }

        //and a Team can have many HomeGames and many AwayGames

        [InverseProperty("HomeTeam")]
        public virtual ICollection<Game> HomeGames { get; set; }

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Game> AwayGames { get; set; }

        //and one Team can have many Players
        public virtual ICollection<Player> Players { get; set; }
    }
}
