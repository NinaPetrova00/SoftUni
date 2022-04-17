namespace Theatre.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;
    using Theatre.Common;
    using Theatre.Data.Models.Enums;

    [XmlType("Play")]
    public class ImportPlaysDto
    {
        [XmlElement("Title")]
        [MinLength(GlobalConstants.PLAY_TITLE_MIN_LENGTH)]
        [MaxLength(GlobalConstants.PLAY_TITLE_MAX_LENGTH)]
        [Required]
        public string Title { get; set; }

        [XmlElement("Duration")]
        [MinLength(GlobalConstants.PLAY_DURATION_MIN_LENGTH)]
        [Required]
        public string Duration { get; set; }

        [XmlElement("Rating")]
        [Range(GlobalConstants.PLAY_RAITING_MIN_VALUE, GlobalConstants.PLAY_RAITING_MAX_VALUE)]
        public float Rating { get; set; }

        [XmlElement("Genre")]
        [Required]
        public string Genre { get; set; }

        [XmlElement("Description")]
        [MaxLength(GlobalConstants.PLAY_DESCRIPTION_MAX_LENGTH)]
        [Required]
        public string Description { get; set; }

        [XmlElement("Screenwriter")]
        [MinLength(GlobalConstants.PLAY_SCREENWRITER_MIN_LENGTH)]
        [MaxLength(GlobalConstants.PLAY_SCREENWRITER_MAX_LENGTH)]
        [Required]
        public string Screenwriter { get; set; }
    }
}
