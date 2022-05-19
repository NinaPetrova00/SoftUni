﻿namespace P03_FootballBetting.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        public Game()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
            this.Bets = new HashSet<Bet>();
        }

        public int GameId { get; set; }
        


        //navigational properties
        // •A Game has one HomeTeam and one AwayTeam 
        [ForeignKey(nameof(HomeTeam))]
        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }


        [ForeignKey(nameof(AwayTeam))]
        public int AwayTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }


        public byte HomeTeamGoals { get; set; } //byte 255

        public byte AwayTeamGoals { get; set; }

        public DateTime DateTime { get; set; }

        public double HomeTeamBetRate { get; set; }

        public double AwayTeamBetRate { get; set; }

        public double DrawBetRate { get; set; }

        [MaxLength(6)]
        public string Result { get; set; }

        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }

        //Many Bets can be placed on one Game,
        public virtual ICollection<Bet> Bets { get; set; }
    }
}