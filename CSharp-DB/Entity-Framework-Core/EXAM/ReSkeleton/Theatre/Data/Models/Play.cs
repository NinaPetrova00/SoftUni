namespace Theatre.Data.Models
{
    using global::Theatre.Common;
    using global::Theatre.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Play
    {
        public Play()
        {
            this.Casts = new HashSet<Cast>();
            this.Tickets = new HashSet<Ticket>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.Play_Title_Max_Length)]
        public string Title { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [MaxLength(GlobalConstants.Play_Description_Max_Length)]
        public string Description { get; set; }

        [Required]
        [MaxLength(GlobalConstants.Play_Screenwriter_Max_Length)]
        public string Screenwriter { get; set; }

        public virtual ICollection<Cast> Casts { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
