using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("submission")]
    public class Submission
    {
        
        [Column("user_id")]
        [Required]
        public int User_Id { get; set; }
        [Required]
        [ForeignKey("user_id")]
        public User User { get; set; }

        [Column("challenge_id")]
        [Required]
        public int Challenge_Id { get; set; }
        [Required]
        [ForeignKey("challenge_id")]
        public Challenge Challenge { get; set; }

        [Column("score", TypeName = "decimal(9,2)")]
        [Required]
        public decimal Score { get; set; }

        [Column("created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_At { get; set; }
    }
}
