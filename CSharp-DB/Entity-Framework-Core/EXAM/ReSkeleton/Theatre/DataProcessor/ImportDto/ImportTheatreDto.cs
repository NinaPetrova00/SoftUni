namespace Theatre.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Theatre.Common;

    public class ImportTheatreDto
    {
        [Required]
        [MinLength(GlobalConstants.Theatre_Name_Min_Length)]
        [MaxLength(GlobalConstants.Theatre_Name_Max_Length)]
        public string Name { get; set; }

        [Required]
        [Range(GlobalConstants.Theatre_NumberOfHalls_Min_Length, GlobalConstants.Theatre_NumberOfHalls_Max_Length)]
        public sbyte NumberOfHalls { get; set; }

        [Required]
        [MinLength(GlobalConstants.Theatre_Director_Min_Length)]
        [MaxLength(GlobalConstants.Theatre_Director_Max_Length)]
        public string Director { get; set; }

        public ImportTicketsDto[] Tickets { get; set; }
    }
}
