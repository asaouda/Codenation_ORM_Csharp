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
        [Column("score", TypeName = "decimal(9,2)"),Required]
        public decimal Score { get; set; }

        [Column("created_at", TypeName = "timestamp"),Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("userid")]
        [Column("user_id"), Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("challengeid")]
        [Column("challenge_id"), Required]
        public int ChallengeId { get; set; }
        public Challenge Challenge { get; set; }
    }
}
