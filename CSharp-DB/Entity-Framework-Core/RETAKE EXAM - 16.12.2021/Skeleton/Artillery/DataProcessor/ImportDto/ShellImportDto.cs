namespace Artillery.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;

    [XmlType("Shell")]
    public class ShellImportDto
    {
        [XmlElement("ShellWeight")]
        [Range(2, 1680)]
        public double ShellWeight { get; set; }

        [XmlElement("Caliber")]
        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        public string Caliber { get; set; }
    }
}
//< Shell >
//   < ShellWeight > 50 </ ShellWeight >
//   < Caliber > 155 mm(6.1 in) </ Caliber >

//    </ Shell >

//•	ShellWeight – double in range[2…1_680](required)
//•	Caliber – text with length [4…30] (required)
