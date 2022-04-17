namespace Theatre.Data.Models
{
   using global::Theatre.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Theatre
    {
        public Theatre()
        {
            this.Tickets = new HashSet<Ticket>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.THEATRE_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        [Required]
        public sbyte NumberOfHalls  { get; set; }

        [Required]
        [MaxLength(GlobalConstants.THEATRE_DIRECTOR_MAX_LENGTH)]
        public string Director { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
