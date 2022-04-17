namespace Theatre.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Common;

    [XmlType("Play")]
    public class ImportPlayDto
    {
        [XmlElement("Title")]
        [MinLength(GlobalConstants.Play_Title_Min_Length)]
        [MaxLength(GlobalConstants.Play_Title_Max_Length)]
        [Required]
        public string Title { get; set; }

        [XmlElement("Duration")]
        [Required]
        public string Duration { get; set; }

        [XmlElement("Rating")]
        [Range(GlobalConstants.Play_Raiting_Min_Length, GlobalConstants.Play_Raiting_Min_Length)]
        public float Rating { get; set; }

        [XmlElement("Genre")]
        [Required]
        public string Genre { get; set; }

        [XmlElement("Description")]
        [MaxLength(GlobalConstants.Play_Description_Max_Length)]
        [Required]
        public string Description { get; set; }

        [XmlElement("Screenwriter")]
        [MinLength(GlobalConstants.Play_Screenwriter_Min_Length)]
        [MaxLength(GlobalConstants.Play_Screenwriter_Max_Length)]
        [Required]
        public string Screenwriter { get; set; }
    }
}
