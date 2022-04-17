namespace P03_FootballBetting.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PlayerStatistic
    {
        //create composite PK using fluent API

        //navigational properties
        //•	One Player can play in many Games and in each Game, many Players take part (both collections must be named PlayerStatistics)
        [ForeignKey(nameof(Game))]
         public int GameId { get; set; }
        public virtual Game Game { get; set; }

        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }



        public byte ScoredGoals { get; set; }

        public byte Assists { get; set; }

        public byte MinutesPlayed { get; set; }
    }
}
