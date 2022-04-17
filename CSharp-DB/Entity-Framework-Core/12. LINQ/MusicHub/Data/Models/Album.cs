namespace MusicHub.Data.Models
{
    using MusicHub.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.ALBUM_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        // auto - calculated column
        //•	Price – calculated property (the sum of all song prices in the album)
        public decimal Price 
            =>this.Songs.Sum(s=> s.Price); 


        //navigational properties
        //Producer – the album’s producer
        [ForeignKey(nameof(Producer))]
        public int? ProducerId { get; set; }
        public virtual Producer Producer { get; set; }


        //•	One Album can have many Songs
        public virtual ICollection<Song> Songs { get; set; }
    }
}
