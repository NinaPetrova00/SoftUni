namespace Artillery.DataProcessor.ImportDto
{
    using Artillery.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class GunsImportDto
    {
        public int ManufacturerId { get; set; }

        [Range(100, 1350000)]
        public int GunWeight { get; set; }

        [Range(2.00, 35.00)]
        public double BarrelLength { get; set; }
        public int? NumberBuild { get; set; }

        [Range(1, 100000)]
        public int Range { get; set; }

        [Required]
        public GunType? GunType { get; set; }

        public int ShellId { get; set; }

        public IEnumerable<CountryInputDto> Countries { get; set; }
    }

    public class CountryInputDto
    {
        public int Id { get; set; }
    }
}
//{
//    "ManufacturerId": 14,
//    "GunWeight": 531616,
//    "BarrelLength": 6.86,
//    "NumberBuild": 287,
//    "Range": 120000,
//    "GunType": "Howitzer",
//    "ShellId": 41,
//    "Countries": [
//      { "Id": 86 },
//      { "Id": 57 },
//      { "Id": 64 },
//      { "Id": 74 },
//      { "Id": 58 }
//    ]
//  }