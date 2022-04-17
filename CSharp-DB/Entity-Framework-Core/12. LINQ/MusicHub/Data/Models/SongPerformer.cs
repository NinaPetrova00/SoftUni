namespace MusicHub.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class SongPerformer
    {

        //composite PK in the Fluent API


        //•	Song – the performer’s Song (required)
        [ForeignKey(nameof(Song))]
        public int SongId { get; set; }
        public virtual Song Song { get; set; }

        //•	Performer – the song’s Performer (required)
        [ForeignKey(nameof(Performer))]
        public int PerformerId { get; set; }
        public virtual Performer Performer { get; set; }
    }
}
