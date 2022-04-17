namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Player
    {
        public Player()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
        }
        [Key]
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        public byte SquadNumber { get; set; }

        //navigational properties
        //•	A Player can play for one Team and one Team can have many Players
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }


        //•	A Player can play at one Position and one Position can be played by many Players
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }


        public bool IsInjured { get; set; } //bool - Отоваря на bit

        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}
