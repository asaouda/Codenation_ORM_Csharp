using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models

{
    [Table("challenge")]
    public class Challenge
    {

        [Column("id")]
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

        public ICollection<Acceleration> Accelerations { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}
