namespace Theatre.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Theatre.Common;

    public class ImportTicketsDto
    {
        [Required]
        [Range(GlobalConstants.Ticket_Price_Min_Length, GlobalConstants.Ticket_Price_Max_Length)]
        public decimal Price { get; set; }

        [Required]
        [Range(GlobalConstants.Ticket_RowNumber_Min_Length, GlobalConstants.Ticket_RowNumber_Max_Length)]
        public sbyte RowNumber { get; set; }

        [Required]
        public int PlayId { get; set; }
    }
}
