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
        [Column("status", TypeName = "int"),Required]
        public int Status { get; set; }

        [Column("created_at", TypeName = "timestamp"),Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("userid")]
        [Column("user_id"), Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("accelerationid")]
        [Column("acceleration_id"), Required]
        public int AccelerationId { get; set; }
        public Acceleration Acceleration { get; set; }

        [ForeignKey("companyid")]
        [Column("company_id"), Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
