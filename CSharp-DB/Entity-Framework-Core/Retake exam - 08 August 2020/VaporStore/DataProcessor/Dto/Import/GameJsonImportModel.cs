namespace VaporStore.DataProcessor.Dto.Import
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class GameJsonImportModel
    {
        [Required]
        public string Name { get; set; }

        [Range(0,double.MaxValue)]
        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Developer { get; set; }

        [Required]
        public string Genre { get; set; }

        public IEnumerable<string> Tags { get; set; }
    }
}
//{
//	"Name": "Invalid",
//		"Price": -5,
//		"ReleaseDate": "2013-07-09",
//		"Developer": "Valid Dev",
//		"Genre": "Valid Genre",
//		"Tags": [
//			"Valid Tag"
//		]
//	}