﻿namespace MusicHub.Data.Models
{
    using MusicHub.Common;
    using MusicHub.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Song
    {

        public Song()
        {
            this.SongPerformers = new HashSet<SongPerformer>();    
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.SONG_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime CreatedOn { get; set; }

        public Genre Genre { get; set; }

        // navigational properties

        //•	Album – the song’s album
        [ForeignKey(nameof(Album))]
        public int? AlbumId { get; set; }
        public virtual Album Album { get; set; }


        //•	Writer – the song’s writer
        [ForeignKey(nameof(Writer))]
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }


        public decimal Price { get; set; }

        //•	One Song can have many Performers
        public virtual ICollection<SongPerformer> SongPerformers { get; set; }

    }
}