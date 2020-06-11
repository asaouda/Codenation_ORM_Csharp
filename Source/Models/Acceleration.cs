using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
    {
        [Column("id",TypeName ="int")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar(100)")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("slug", TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        public string Slug { get; set; }


        [Column("created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_At { get; set; }


        [Column("challenge_id")]
        [Required]
        public int Challenge_Id { get; set; }
        [Required]
        [ForeignKey("challengeid")]
        public Challenge Challenge { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
