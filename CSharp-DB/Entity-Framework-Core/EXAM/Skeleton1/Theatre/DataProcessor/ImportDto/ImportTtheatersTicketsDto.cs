namespace Theatre.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using Theatre.Common;

    public class ImportTtheatersTicketsDto
    {
        [Required]
        [Range(GlobalConstants.TICKETS_PRICE_MIN_VALUE,GlobalConstants.TICKETS_PRICE_MAX_VALUE)]
        public decimal Price { get; set; }

        [Required]
        [Range(GlobalConstants.TICKETS_ROWNUMBER_MIN_VALUE,GlobalConstants.TICKETS_ROWNUMBER_MAX_VALUE)]
        public sbyte RowNumber { get; set; }

        [Required]
        public int PlayId { get; set; }
    }
}
