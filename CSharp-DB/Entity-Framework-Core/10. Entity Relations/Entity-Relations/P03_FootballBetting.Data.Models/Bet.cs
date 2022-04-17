namespace P03_FootballBetting.Data.Models
{
    using P03_FootballBetting.Data.Models.Enumerations;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Bet
    {
        [Key]
        public int BetId { get; set; }
        public decimal Amount { get; set; }

        [Required]
        public Prediction Prediction { get; set; }
        public DateTime DateTime { get; set; }

        //navigational properties
        //•	A Bet can be placed by only one User 
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }


        //•	 but a Bet can be only on one Game
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

    }
}
