﻿namespace SoftJail.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class PrisonerMailInputModel
    {
        [Required]
        [StringLength(20,MinimumLength =3)]
        public string FullName { get; set; }

        [Required]
        [RegularExpression("The [A-Z]{1}[a-z]*")]
        public string Nickname { get; set; }

        [Range(18,65)]
        public int Age { get; set; }
        public string IncarcerationDate { get; set; }
        public string ReleaseDate { get; set; }

        [Range(typeof(decimal),"0", "79228162514264337593543950335")]
        public decimal? Bail { get; set; }
        //•	Bail– decimal(non - negative, minimum value: 0)
        public int? CellId { get; set; }
        public IEnumerable<MailInputModel> Mails { get; set; }
    }

    public class MailInputModel
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        [RegularExpression(@"^([A-z0-9\s]+ str.)$")]
        public string Address { get; set; }
    }
}

