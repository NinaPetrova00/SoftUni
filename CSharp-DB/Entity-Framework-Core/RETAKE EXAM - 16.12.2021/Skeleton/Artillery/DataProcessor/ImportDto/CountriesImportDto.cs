namespace Artillery.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;

    [XmlType("Country")]
    public class CountriesImportDto
    {
        [XmlElement("CountryName")]
        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string CountryName { get; set; }

        [XmlElement("ArmySize")]
        [Range(50000, 10000000)]
        public int ArmySize { get; set; }
    }
}
//< Country >
//    < CountryName > Afghanistan </ CountryName >
//    < ArmySize > 1697064 </ ArmySize >
//  </ Country >

//•	CountryName – text with length [4, 60] (required)
//•	ArmySize – integer in the range[50_000….10_000_000] (required)
