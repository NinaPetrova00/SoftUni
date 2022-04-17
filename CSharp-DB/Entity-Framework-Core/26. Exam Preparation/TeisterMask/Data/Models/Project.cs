﻿namespace TeisterMask.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TeisterMask.Common;

    public class Project
    {
        public Project()
        {
            this.Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.PROJECT_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        public DateTime OpenDate  { get; set; } //by default: required

        public DateTime? DueDate  { get; set; } //nullable 

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
