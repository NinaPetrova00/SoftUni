namespace TeisterMask.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;
    using TeisterMask.Common;

    [XmlType("Project")]
    public class ImportProjectDto
    {
        [XmlElement("Name")]
        [Required]
        [MinLength(GlobalConstants.PROJECT_NAME_MIN_LENGTH)] //validation for model projec
        [MaxLength(GlobalConstants.PROJECT_NAME_MAX_LENGTH)] //validation for model projec
        public string Name { get; set; }

        [Required]
        [XmlElement("OpenDate")]
        public string OpenDate { get; set; }

        [XmlElement("DueDate")]
        public string DueDate { get; set; }

        [XmlArray("Tasks")]
        public ImportProjectTaskDto[] Tasks { get; set; }
    }
}
