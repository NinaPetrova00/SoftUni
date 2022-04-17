namespace Theatre.Data.Models
{
    using global::Theatre.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Theatre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.Theatre_Name_Max_Length)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.Theatre_NumberOfHalls_Max_Length)]
        public sbyte  NumberOfHalls { get; set; }

        [Required]
        [MaxLength(GlobalConstants.Theatre_Director_Max_Length)]
        public string Director { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
