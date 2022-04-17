namespace Theatre.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;
    using Theatre.Common;

    [XmlType("Cast")]
    public class ImportCastsDto
    {
        [XmlElement("FullName")]
        [MinLength(GlobalConstants.CAST_FULLNAME_MIN_LENGTH)]
        [MaxLength(GlobalConstants.CAST_FULLNAME_MAX_LENGTH)]
        [Required]
        public string FullName { get; set; }

        [XmlElement("IsMainCharacter")]
        [Required]
        public bool IsMainCharacter { get; set; }

        [XmlElement("PhoneNumber")]
        [MaxLength(GlobalConstants.CAST_PHONENUMBER_MAX_LENGTH)]
        [RegularExpression(GlobalConstants.CAST_PHONENUMBER_REGEX)]
        [Required]
        public string PhoneNumber { get; set; }

        [XmlElement("PlayId")]
        [Required]
        public int PlayId { get; set; }
    }
}
