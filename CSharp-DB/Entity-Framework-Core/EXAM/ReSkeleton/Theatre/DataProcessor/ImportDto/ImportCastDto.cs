namespace Theatre.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Common;

    [XmlType("Cast")]
    public class ImportCastDto
    {
        [XmlElement("FullName")]
        [MinLength(GlobalConstants.Cast_FullName_Min_Length)]
        [MaxLength(GlobalConstants.Cast_FullName_Max_Length)]
        [Required]
        public string FullName { get; set; }

        [XmlElement("IsMainCharacter")]
        [Required]
        public bool IsMainCharacter { get; set; }

        [XmlElement("PhoneNumber")]
        [MaxLength(GlobalConstants.Cast_PhoneNumber_Max_Length)]
        [RegularExpression(GlobalConstants.Cast_PhoneNumber_Regex)]
        [Required]
        public string PhoneNumber { get; set; }

        [XmlElement("PlayId")]
        [Required]
        public int PlayId { get; set; }
    }
}
