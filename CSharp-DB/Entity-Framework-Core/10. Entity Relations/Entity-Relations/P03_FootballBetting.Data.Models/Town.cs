namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Town
    {
        public Town()
        {
            this.Teams = new HashSet<Team>();
        }
        [Key] //primary key
        public int TownId { get; set; }

        [Required]
        [MaxLength(85)]
        public string Name { get; set; }

        //navigational properties
        //•	A Town can be placed in one Country 

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }


        //•	A Town can host several Teams
        public virtual ICollection<Team> Teams { get; set; }
    }
}
