namespace Theatre.Data.Models
{
    using global::Theatre.Common;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cast
    {
        [Key]
        public int Id { get; set; }

        [Required]
        // [MaxLength(30)]
        [MaxLength(GlobalConstants.CAST_FULLNAME_MAX_LENGTH)]
        public string FullName { get; set; }

        [Required]
        public bool IsMainCharacter { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [ForeignKey(nameof(Play))]
        public int PlayId { get; set; }
        public virtual Play Play { get; set; }

    }
}
