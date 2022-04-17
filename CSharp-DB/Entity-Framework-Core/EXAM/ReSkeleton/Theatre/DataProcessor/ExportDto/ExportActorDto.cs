namespace Theatre.DataProcessor.ExportDto
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;

    [XmlType("Actor")]
    public class ExportActorDto
    {
        [XmlAttribute("FullName")]
        public string FullName { get; set; }

        [XmlAttribute("MainCharacter")]
        public string MainCharacter { get; set; }
    }
}
