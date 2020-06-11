using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Column("user_id")]
        [Required]
        public int User_Id { get; set; }
        [Required]
        [ForeignKey("user_id")]
        public User User { get; set; }

        [Column("acceleration_id")]
        [Required]
        public int Acceleration_Id { get; set; }
        [Required]
        [ForeignKey("acceleration_id")]
        public Acceleration Acceleration { get; set; }

        [Column("company_id")]
        [Required]
        public int Company_Id { get; set; }
        [Required]
        [ForeignKey("company_id")]
        public Company Company { get; set; }

        [Column("status", TypeName = "int")]
        [Required]
        public int Status { get; set; }

        [Column("created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_At { get; set; }

    }
}
