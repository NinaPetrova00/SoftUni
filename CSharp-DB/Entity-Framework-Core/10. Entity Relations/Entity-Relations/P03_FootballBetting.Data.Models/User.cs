﻿namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class User
    {

        public User()
        {
            this.Bets = new HashSet<Bet>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        //Passwords in DB are stored hashed
        [Required]
        [MaxLength(256)]
        public string Password { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        public decimal Balance { get; set; }

        //and one User can place many Bets
        public virtual ICollection<Bet> Bets { get; set; }

    }
}
