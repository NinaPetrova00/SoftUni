﻿namespace VaporStore.DataProcessor.Dto.Import
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class UserJsonInputModel
    {
        [Required]
        [RegularExpression("[A-Z]{1}[a-z]{2,} [A-Z]{1}[a-z]{2,}")]
        public string FullName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Range(3,103)]
        public int Age { get; set; }
        public IEnumerable<CardJsonInputModel> Cards { get; set; }
    }
}
