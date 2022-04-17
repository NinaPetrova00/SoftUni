namespace SoftJail.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Department
    {
        public Department()
        {
            this.Cells = new HashSet<Cell>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Cell> Cells { get; set; }

        //TODO: add prisoners
    }
}
//•	Id – integer, Primary Key
//•	Name – text with min length 3 and max length 25 (required)
//•	Cells - collection of type Cell
