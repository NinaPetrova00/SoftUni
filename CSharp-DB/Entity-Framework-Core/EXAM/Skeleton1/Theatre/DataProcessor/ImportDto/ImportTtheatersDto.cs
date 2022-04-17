namespace Theatre.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using Theatre.Common;

    public class ImportTtheatersDto
    {
        [Required]
        [MinLength(GlobalConstants.THEATRE_NAME_MIN_LENGTH)]
        [MaxLength(GlobalConstants.THEATRE_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        [Required]
        [Range(GlobalConstants.THEATRE_NUMBEROFHALLS_MIN_LENGTH,GlobalConstants.THEATRE_NUMBEROFHALLS_MAX_LENGTH)]
        public sbyte NumberOfHalls { get; set; }

        [Required]
        [MinLength(GlobalConstants.THEATRE_DIRECTOR_MIN_LENGTH)]
        [MaxLength(GlobalConstants.THEATRE_DIRECTOR_MAX_LENGTH)]
        public string Director { get; set; }

        public ImportTtheatersTicketsDto[] Tickets { get; set; }
    }
}
